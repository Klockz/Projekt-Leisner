using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LeisnerWCF.Model
{
    [DataContract]
    public class ToiletVisit
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime Time { get; set; }

        public ToiletVisit(DateTime time)
        {
            Time = time;
        }
    }
}