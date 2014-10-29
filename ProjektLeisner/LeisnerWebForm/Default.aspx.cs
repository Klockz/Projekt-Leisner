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
            //WetBed wetBed = new WetBed() { Id = 0, Time = DateTime.Now, Size = SpotSize.M };
            //wetBeds.Add(wetBed);
            //ViewState.Add("wetBeds", wetBeds);
            //WetBedListView.DataSource = wetBeds;
            //WetBedListView.DataBind();

            Table table = new Table();

            TableRow row1 = new TableRow();
            table.Rows.Add(row1);
            TableCell cell1 = new TableCell();
            TableCell cell2 = new TableCell();
            row1.Cells.Add(cell1);
            row1.Cells.Add(cell2);

            TableRow row2 = new TableRow();
            table.Rows.Add(row2);
            TableCell cell3 = new TableCell();
            TableCell cell4 = new TableCell();
            row2.Cells.Add(cell3);
            row2.Cells.Add(cell4);

            Label timeLabel = new Label();
            timeLabel.Text = "Time:";
            cell1.Controls.Add(timeLabel);
            TextBox timeTextBox = new TextBox();
            cell2.Controls.Add(timeTextBox);

            Label sizeLabel = new Label();
            sizeLabel.Text = "Size:";
            cell3.Controls.Add(sizeLabel);
            TextBox sizeTextBox = new TextBox();
            cell4.Controls.Add(sizeTextBox);
            
            wetBedPanel.Controls.Add(table);
        }
    }
}