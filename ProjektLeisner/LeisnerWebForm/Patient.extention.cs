using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeisnerWebForm.ServiceReference1
{
    public partial class Patient
    {
        public override string ToString()
        {
            return this.Name;
        } 
    }
}