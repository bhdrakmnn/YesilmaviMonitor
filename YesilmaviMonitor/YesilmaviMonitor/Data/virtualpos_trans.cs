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
    
    public partial class virtualpos_trans
    {
        public int logicalref { get; set; }
        public int clientref { get; set; }
        public Nullable<int> subclientref { get; set; }
        public Nullable<int> slsmanref { get; set; }
        public string cyphcode { get; set; }
        public System.DateTime date { get; set; }
        public int vposref { get; set; }
        public Nullable<int> logobankaccref { get; set; }
        public Nullable<int> vtaksitref { get; set; }
        public string vclientid { get; set; }
        public short taksit_sayi { get; set; }
        public decimal anapara { get; set; }
        public decimal toplam { get; set; }
        public Nullable<short> trcurr { get; set; }
        public Nullable<decimal> trrate { get; set; }
        public Nullable<decimal> trnet { get; set; }
        public Nullable<decimal> reportrate { get; set; }
        public Nullable<decimal> reportnet { get; set; }
        public string maskedpan { get; set; }
        public string cardholder { get; set; }
        public string tranid { get; set; }
        public string authcode { get; set; }
        public string hostrefnum { get; set; }
        public string response { get; set; }
        public string mdstatus { get; set; }
        public string mderrmsg { get; set; }
        public Nullable<int> client_logicalref1 { get; set; }
        public Nullable<int> client_logicalref2 { get; set; }
        public short status { get; set; }
        public Nullable<int> orderref { get; set; }
    }
}