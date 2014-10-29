using LeisnerWebForm.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeisnerWebForm
{
    public partial class LoginUserControl : System.Web.UI.UserControl
    {
        BedwetterServiceClient client = new BedwetterServiceClient();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer customer = client.GetCustomer(LoginControl.UserName);
            
            if (customer.Email != null)
            {
                
            }
            else
            {
                ErrorMessage.Text = LoginControl.UserNameRequiredErrorMessage;
            }

            
        }
    }
}