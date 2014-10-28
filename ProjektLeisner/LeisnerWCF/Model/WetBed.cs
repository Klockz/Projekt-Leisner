using LeisnerWCF.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWCF.Model
{
    public class WetBed
    {
        public int Id { get; set; }
        public SpotSize Size { get; set; }
        public DateTime Time { get; set; }
    }
}