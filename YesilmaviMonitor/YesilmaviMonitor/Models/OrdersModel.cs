﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YesilmaviMonitor.Models
{
    public class OrdersModel
    {
        public string SlsmanName { get; set; }
        public string ClcardName { get; set; }
        public long LOGICALREF { get; set; }
        public short B2B_ORDER_TYPE { get; set; }
        public System.DateTime TARIH { get; set; }
        public string CYPHCODE { get; set; }
        public Nullable<long> CLIENTREF { get; set; }
        public Nullable<long> SLSMANREF { get; set; }
        public decimal TOPLAM { get; set; }
        public decimal ISKONTO_ORAN { get; set; }
        public Nullable<decimal> ISKONTO_ORAN_2 { get; set; }
        public decimal ISKONTO_TOPLAM { get; set; }
        public decimal ISKONTOLU_TUTAR { get; set; }
        public Nullable<decimal> KAPIDA_ODEME_TUTAR { get; set; }
        public Nullable<decimal> KARGO_TUTAR { get; set; }
        public decimal TOPLAM_EKVERGI { get; set; }
        public decimal TOPLAM_KDV { get; set; }
        public decimal NET_TOPLAM { get; set; }
        public Nullable<int> TRCURR { get; set; }
        public Nullable<decimal> TRRATE { get; set; }
        public Nullable<decimal> TRNET { get; set; }
        public Nullable<decimal> REPORTRATE { get; set; }
        public Nullable<decimal> REPORTNET { get; set; }
        public string STATUS { get; set; }
        public string CLIENT_LOGICALREF { get; set; }
        public Nullable<long> PAYPLANREF { get; set; }
        public string ACIKLAMA { get; set; }
        public string SEVK_ADRES_TIP { get; set; }
        public string SEVK_ADRES { get; set; }
        public string SEVK_SEHIR { get; set; }
        public Nullable<System.DateTime> SEVK_TARIH { get; set; }
        public string SEVK_SEKLI { get; set; }
        public string SEVK_SEKLI_KODU { get; set; }
        public Nullable<int> TOPLAM_PUAN { get; set; }
        public Nullable<bool> PUAN_ONAY { get; set; }
        public Nullable<short> CLIENT_STATUS { get; set; }
        public string CLIENT_EXP { get; set; }
        public Nullable<float> GEO_LATITUDE { get; set; }
        public Nullable<float> GEO_LONGITUDE { get; set; }
        public Nullable<float> GEO_ALTITUDE { get; set; }
        public Nullable<float> GEO_ACCURACY { get; set; }
        public Nullable<int> CLIENT_SHIPINFOREF { get; set; }
        public Nullable<int> APPROVE1USERREF { get; set; }
        public Nullable<int> APPROVE2USERREF { get; set; }
        public Nullable<int> APPROVE3USERREF { get; set; }
        public Nullable<int> APPROVE1USERSTATE { get; set; }
        public Nullable<int> APPROVE2USERSTATE { get; set; }
        public Nullable<int> APPROVE3USERSTATE { get; set; }
        public Nullable<int> APPROVESTATE { get; set; }
        public Nullable<int> ORDERLOGISTICID { get; set; }
        public string SASNO { get; set; }
    }
}