using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YesilmaviMonitor.Models
{
    public class VirtualposTransModel
    {
        public string SlsmanName { get; set; }
        public string ClcardName { get; set; }
        public int logicalref { get; set; }
        public int clientref { get; set; }   
        public System.DateTime date { get; set; }
        public int vposref { get; set; }
        public Nullable<int> logobankaccref { get; set; }
        public Nullable<int> vtaksitref { get; set; }
        public string vclientid { get; set; }
        public short taksit_sayi { get; set; }
        public decimal anapara { get; set; }
        public decimal toplam { get; set; }     
        public string maskedpan { get; set; }
        public string cardholder { get; set; }
        public string tranid { get; set; }
        public string authcode { get; set; }
        public string hostrefnum { get; set; }
        public string response { get; set; }
        public string mdstatus { get; set; }
        public string mderrmsg { get; set; }      
        public short status { get; set; }
       
    }
}