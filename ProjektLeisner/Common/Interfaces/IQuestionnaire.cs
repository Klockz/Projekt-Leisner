using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    interface IQuestionnaire
    {
        DateTime Date { get; set; }
        List<IWetBed> WetBeds { get; set; }
        List<IToiletVisit> ToiletVisits { get; set; }
        int Motivation { get; set; }
        string Comment { get; set; }
        bool PleaseContact { get; set; }
    }
}
