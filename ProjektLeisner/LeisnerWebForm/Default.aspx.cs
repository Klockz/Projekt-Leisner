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
        private BedwetterServiceClient bedwetterService = new BedwetterServiceClient();
        private List<WetBed> wetBeds = new List<WetBed>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["wetBeds"] != null)
            {
                wetBeds = (List<WetBed>)ViewState["wetBeds"];
            }
        }

        protected void createWetBedButton_Click(object sender, EventArgs e)
        {
            // Hurtig test:
            WetBed wetBed = new WetBed() { Id = 0, Time = DateTime.Now, Size = SpotSize.M };
            wetBeds.Add(wetBed);
            ViewState.Add("wetBeds", wetBeds);
            WetBedListView.DataSource = wetBeds;
            WetBedListView.DataBind();
        }
    }
}