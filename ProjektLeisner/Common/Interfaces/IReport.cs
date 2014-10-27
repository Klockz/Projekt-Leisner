using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    interface IReport
    {
        DateTime Date { get; set; }
        List<IPeeSpot> PeeSpots { get; set; }
    }
}
