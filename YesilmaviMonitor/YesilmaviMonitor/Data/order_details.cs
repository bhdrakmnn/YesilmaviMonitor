//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YesilmaviMonitor.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class order_details
    {
        public long LOGICALREF { get; set; }
        public long ORDERREF { get; set; }
        public long ITEMREF { get; set; }
        public Nullable<int> VARIANTREF { get; set; }
        public string SERILOTCODE { get; set; }
        public Nullable<int> PAYMENTREF { get; set; }
        public Nullable<int> SOURCEINDEX { get; set; }
        public int UOMREF { get; set; }
        public float UINFO1 { get; set; }
        public float UINFO2 { get; set; }
        public string UNIT { get; set; }
        public float PRICE { get; set; }
        public int VAT { get; set; }
        public string CUR { get; set; }
        public Nullable<float> SATIS_FIYAT { get; set; }
        public Nullable<float> ISKONTO_TUTAR { get; set; }
        public Nullable<float> KDV_TUTAR { get; set; }
        public Nullable<float> NET_TUTAR { get; set; }
        public Nullable<int> PRCURR { get; set; }
        public Nullable<float> PRRATE { get; set; }
        public Nullable<float> PRPRICE { get; set; }
        public Nullable<float> TRCURR { get; set; }
        public Nullable<float> TRRATE { get; set; }
        public Nullable<float> REPORTRATE { get; set; }
        public Nullable<float> SEVKEDILEN_MIKTAR { get; set; }
        public string CLIENT_LOGICALREF { get; set; }
        public Nullable<System.DateTime> SEVK_TARIH { get; set; }
        public Nullable<int> VATINC { get; set; }
        public Nullable<float> ADDTAXRATE { get; set; }
        public Nullable<float> ADDTAXCONVFACT { get; set; }
        public Nullable<float> ADDTAXAMOUNT { get; set; }
        public Nullable<int> CLOSED { get; set; }
        public string LINEEXP { get; set; }
        public Nullable<int> KAZANILAN_PUAN { get; set; }
        public string DISCOUNT_LIST { get; set; }
        public Nullable<int> OFFERREF { get; set; }
        public Nullable<int> OFFERLINEREF { get; set; }
        public Nullable<int> PARENTITEMREF { get; set; }
        public Nullable<int> CAMPAIGNREF { get; set; }
        public Nullable<bool> KAMPAYALI_URUN_MU { get; set; }
    }
}
