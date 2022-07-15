using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace aracSecimi.Models.Siniflar
{
    public class Arac
    {
        [Key]
        public int Id { get; set; }
        public string FotoUrl { get; set; }
        public string FotoUrl2 { get; set; }
        public string FotoUrl3 { get; set; }
        public string FotoUrl4 { get; set; }
        public string FotoUrl5 { get; set; }
        public int Fiyat { get; set; }
        public string Marka { get; set; }
        public string Seri { get; set; }
        public string Model { get; set; }
        public int UretimYili { get; set; }
        public string Yakit { get; set; }
        public string Vites { get; set; }
        public int AracKm { get; set; }
        public string KasaTipi { get; set; }
        public string MotorGucu { get; set; }
        public string MotorHacmi { get; set; }
        public string Cekis { get; set; }
        public string Renk { get; set; }
        public string YakitTuketimi { get; set; }
        public string SehirIci { get; set; }
        public string OrtalamaTuketim { get; set; }
        public string Hizlanma0_100 { get; set; }
        public string AzamiSurat { get; set; }
        public string MaxTork { get; set; }
        public string DepoHacmi { get; set; }
    }
}