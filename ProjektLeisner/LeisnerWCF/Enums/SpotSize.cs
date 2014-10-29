using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LeisnerWCF.Enums
{
    [DataContract]
    public enum SpotSize
    {
        [EnumMember]
        XS,
        [EnumMember]
        S,
        [EnumMember]
        M,
        [EnumMember]
        L,
        [EnumMember]
        XL
    }
}