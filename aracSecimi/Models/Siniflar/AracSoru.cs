using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace aracSecimi.Models.Siniflar
{
    public class AracSoru
    {
        [Key]
        public int Id { get; set; }
        public string Soru { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public int AId { get; set; }
        public int BId { get; set; }
        public int CId { get; set; }
        public int DId { get; set; }
        public int AracId { get; set; }
    }
}