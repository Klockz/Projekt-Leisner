using LeisnerWebForm.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeisnerWebForm
{
    public partial class Default : System.Web.UI.Page
    {
        BedwetterServiceClient client = new BedwetterServiceClient();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginControl_Authenticate(object sender, AuthenticateEventArgs e)
        {
            Customer customer = client.GetCustomer(LoginControl.UserName);

            if (customer != null)
            {
                Response.Redirect("QuestionnairePage.aspx");
            }
            else
            {
                ErrorMessage.Text = LoginControl.UserNameRequiredErrorMessage;
            }
        }

        protected void LoginControl_LoggingIn(object sender, LoginCancelEventArgs e)
        {

        }
    }
}