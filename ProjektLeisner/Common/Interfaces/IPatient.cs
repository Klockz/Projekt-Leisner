using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    interface IPatient
    {
        string Name { get; set; }
        int Age { get; set; }
        List<IQuestionnaire> Questionnaires { get; set; }
    }
}
