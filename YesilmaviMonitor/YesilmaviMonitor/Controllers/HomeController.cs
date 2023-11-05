using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YesilmaviMonitor.Data;
using YesilmaviMonitor.Models;


namespace YesilmaviMonitor.Controllers
{
    public class HomeController : Controller
    {
        b2bdebugEntities db = new b2bdebugEntities();
        public ActionResult Index()
        {
            List<MonitorModel> viewModel = new List<MonitorModel>();
            List<sync_status> syncStatusList = new List<sync_status>();


            var databaseList = db.Database.SqlQuery<string>("SELECT schema_name FROM information_schema.`SCHEMATA`").ToList();



            foreach (string dbName in databaseList)
            {
                //her müşteri için dönüyoruz

                MonitorModel model = new MonitorModel();

                model.CustomerName = dbName;
                model.DataBaseName = dbName;
                model.CustomerLogo = " ";

                model.syncStatusList = new List<sync_status>();
                model.CustomerInfo = new SetupModel();




                try
                {
                    var STATUS = db.Database.SqlQuery<int>("SELECT COUNT(*) AS STATUS FROM " + dbName + ".orders WHERE (STATUS IS NULL)").FirstOrDefault();
                    model.waitingOrdersCount = STATUS;

                    var virtualpos_trans = db.Database.SqlQuery<int>("SELECT COUNT(STATUS) AS ORDERSFROMSTATUS0 FROM  " + dbName + " .virtualpos_trans WHERE (STATUS='0') AND (response= 'APPROVED') ").FirstOrDefault();
                    model.waitingCreditCardCount = virtualpos_trans;


                    var setup = db.Database.SqlQuery<SetupModel>("SELECT * FROM " + dbName + ".setup").FirstOrDefault();
                    model.CustomerInfo = setup;

                    var sonGorulme = db.Database.SqlQuery<sync_status>("SELECT Anahtar, Deger FROM " + dbName + ".sync_status WHERE(Anahtar = 'SonGorulme')").FirstOrDefault();

                    if (sonGorulme != null)
                    {
                        model.syncStatusList.Add(sonGorulme);
                    }


                }
                catch (Exception ex)
                {
                    model.CustomerName = "geçersiz";
                }

                viewModel.Add(model);
            }


            return View(viewModel);
        }

        public ActionResult Details(string dbName)
        {
            List<virtualpos_trans> waitingCreditCard = new List<virtualpos_trans>();
            List<orders> waitingOrders = new List<orders>();
            List<sync_status> syncStatusList = new List<sync_status>();
            List<sync_config> syncConfigList = new List<sync_config>();
            List<sync_log> syncLogList = new List<sync_log>();
            MonitorModel model = new MonitorModel();


            var databaseList = db.Database.SqlQuery<string>("SELECT schema_name FROM information_schema.`SCHEMATA`").ToList();



            model.CustomerName = dbName;
            model.DataBaseName = dbName;
            model.CustomerLogo = " ";
            model.CustomerInfo = new SetupModel();
            model.waitingCreditCardDetails = new List<VirtualposTransModel>();
            model.waitingCreditCard = new List<VirtualposTransModel>();
            model.waitingOrders = new List<OrdersModel>();
            model.syncStatusList = new List<sync_status>();
            model.syncLogList = new List<sync_log>();

            var setup = db.Database.SqlQuery<SetupModel>("SELECT * FROM " + dbName + ".setup").FirstOrDefault();
            model.CustomerInfo = setup;

            string strSQLS = $@"SELECT
                                       slsman.DEFINITION_ as SlsmanName, clcard.`DEFINITION_` as ClcardName,
                                       orders.*
                                       FROM {dbName}.orders
                                                    INNER JOIN {dbName}.slsman ON orders.slsmanref = slsman.LOGICALREF
                                                    INNER JOIN {dbName}.clcard ON orders.clientref = clcard.LOGICALREF
                                       WHERE (STATUS IS NULL)";

            var orders = db.Database.SqlQuery<OrdersModel>(strSQLS).ToList();
            model.waitingOrders = orders;

            string strSQL = $@"SELECT  
                                virtualpos_trans.logicalref,  slsman.DEFINITION_  SlsmanName, clcard.`DEFINITION_`  ClcardName,
                                virtualpos_trans.`clientref`, virtualpos_trans.`vposref`, virtualpos_trans.`slsmanref`, virtualpos.CODE, 
                                virtualpos_trans.date, virtualpos_trans.`vposref`, virtualpos_trans.`logobankaccref`,
                                virtualpos_trans.`vtaksitref`, virtualpos_trans.`vclientid`, virtualpos_trans.`taksit_sayi`, 
                                virtualpos_trans.`anapara`, virtualpos_trans.`toplam`, virtualpos_trans.`maskedpan`,
                                virtualpos_trans.`cardholder`, virtualpos_trans.`tranid`, virtualpos_trans.`authcode`, 
                                virtualpos_trans.`hostrefnum`, virtualpos_trans.`response`, virtualpos_trans.`mdstatus`,
                                virtualpos_trans.`mderrmsg`, virtualpos_trans.`status`
                                FROM {dbName}.virtualpos_trans 
                                        LEFT JOIN {dbName}.virtualpos ON virtualpos_trans.vposref = virtualpos.VPOSREF 
                                        LEFT JOIN {dbName}.slsman ON virtualpos_trans.slsmanref = slsman.LOGICALREF 
                                        LEFT JOIN {dbName}.clcard ON virtualpos_trans.clientref = clcard.LOGICALREF 
                               WHERE(STATUS = '0') AND(response = 'APPROVED') ORDER BY logicalref DESC LIMIT 20 ";

            var virtualpos_trans = db.Database.SqlQuery<VirtualposTransModel>(strSQL).ToList();
            model.waitingCreditCardDetails = virtualpos_trans;

            var sync_config = db.Database.SqlQuery<sync_config>("SELECT * FROM " + dbName + ".sync_config").ToList();
            model.syncConfigList = sync_config;

            var sync_log = db.Database.SqlQuery<sync_log>("SELECT * FROM " + dbName + ".sync_log ORDER BY Tarih DESC LIMIT 50 ").ToList();
            model.syncLogList = sync_log;

           

            var sync_status = db.Database.SqlQuery<sync_status>("SELECT * FROM " + dbName + ".sync_status ").ToList();
            model.syncStatusList = sync_status;

            return View(model);

        }
 
        public ActionResult OrderDetails(int orderref, string dbName)
        {
            List<OrderDetailsModel> orderDetailsList = new List<OrderDetailsModel>();
            MonitorModel model = new MonitorModel();



            model.orderDetailsList = new List<OrderDetailsModel>();

            string strSql = $@"SELECT order_details.*, 
                               items.NAME as ItemsName
                               FROM {dbName}.order_details
                                             INNER JOIN {dbName}.items ON order_details.itemref = items.LOGICALREF
                               WHERE (orderref = " + orderref + ")";


            var order_details = db.Database.SqlQuery<OrderDetailsModel>(strSql).ToList();
            model.orderDetailsList = order_details;


            return View(model);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
