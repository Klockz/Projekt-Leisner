using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    interface ICustomer
    {
        string Name { get; set; }
        string Email { get; set; }
        int CustomerNo { get; set; }
        List<IPatient> Patients { get; set; }
    }
}
