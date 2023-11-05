using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YesilmaviMonitor.Models
{
    public class OrderDetailsModel
    {
        public string ItemsName { get; set; }
        public long LOGICALREF { get; set; }
        public long ORDERREF { get; set; }
        public long ITEMREF { get; set; }
        public Nullable<int> VARIANTREF { get; set; }
        public string SERILOTCODE { get; set; }
        public Nullable<int> PAYMENTREF { get; set; }
        public Nullable<int> SOURCEINDEX { get; set; }
        public float PRICE { get; set; }
        public int VAT { get; set; }
        public string CUR { get; set; }
        public Nullable<float> SATIS_FIYAT { get; set; }
        public Nullable<float> ISKONTO_TUTAR { get; set; }
        public Nullable<float> KDV_TUTAR { get; set; }
        
    }
}