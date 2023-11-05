using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YesilmaviMonitor.Data;

namespace YesilmaviMonitor.Models
{
    public class MonitorModel
    {
        public string DataBaseName { get; set; }
        public string CustomerName{ get; set; }
        public string CustomerLogo { get; set; }
        public SetupModel CustomerInfo { get; set; }
        public List<sync_config> syncConfigList { get; set; }
        public List<sync_log> syncLogList { get; set; }
        public List<sync_status> syncStatusList { get; set; }
        public int waitingOrdersCount { get; set; }
        public List<VirtualposTransModel> waitingCreditCardDetails { get; set; }
        public List<OrdersModel> waitingOrders { get; set; }
        public List<OrderDetailsModel> orderDetailsList { get; set; }
        public List<VirtualposTransModel> waitingCreditCard { get; set; }
        public int waitingCreditCardCount { get; set; }
        

    }
}