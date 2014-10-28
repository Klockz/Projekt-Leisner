using LeisnerWCF.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LeisnerWCF.Model
{
    [DataContract]
    public class WetBed
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public SpotSize Size { get; set; }
        [DataMember]
        public DateTime Time { get; set; }

        public WetBed(SpotSize size, DateTime time)
        {
            Size = size;
            Time = time;
        }
    }
}