using LeisnerWebForm.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LeisnerWebForm
{
    public partial class QuestionnairePage : System.Web.UI.Page
    {
        private BedwetterServiceClient bedwetterService = new BedwetterServiceClient();
        private int wetBedViewState = 1;
        private int toiletVisitsViewState = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == true)
            {
                if (ViewState["wetBedIncidents"] != null)
                {
                    wetBedViewState = (int)ViewState["wetBedIncidents"];
                }
                if (ViewState["toiletVisits"] != null)
                {
                    toiletVisitsViewState = (int)ViewState["toiletVisits"];
                }
            }

            CreatePostBackControls(wetBedViewState, toiletVisitsViewState);
        }

        protected void CreatePostBackControls(int _wetBedViewState, int _toiletVisitsViewState)
        {
            for (int i = 1; i <= _wetBedViewState; i++)
            {
                string id = i.ToString();
                createWetBedCtrl(id);
            }

            for (int i = 1; i <= _toiletVisitsViewState; i++)
            {
                string id = i.ToString();
                createToiletVisitCtrl(id);
            }
        }

        protected void addWetBedIncident_Click(object sender, EventArgs e)
        {
            wetBedViewState = wetBedViewState + 1;
            string id = wetBedViewState.ToString();
            createWetBedCtrl(id);
            ViewState["wetBedIncidents"] = wetBedViewState;
        }

        protected void addToiletVisit_Click(object sender, EventArgs e)
        {
            toiletVisitsViewState = toiletVisitsViewState + 1;
            string id = toiletVisitsViewState.ToString();
            createToiletVisitCtrl(id);
            ViewState["toiletVisits"] = toiletVisitsViewState;
        }

        protected void submitQuestionnaire_Click(object sender, EventArgs e)
        {
            Questionnaire questionnaire = new Questionnaire();

            DateTime date;
            DateTime.TryParse(dateTextBox.Text, out date);
            questionnaire.Date = date;

            List<WetBed> wetBeds = new List<WetBed>();
            foreach (Control ctrl in wetBedIncidentsPanel.Controls)
            {
                if (ctrl.ID.StartsWith("wetBedPanel"))
                {
                    WetBed wetBed = new WetBed();
                    wetBed.Id = 0;
                    foreach (Control ctrl2 in ctrl.Controls)
                    {
                        if (ctrl2.ID != null)
                        {
                            if (ctrl2.ID.StartsWith("wetBedTimeTextBox"))
                            {
                                TextBox textBox = (TextBox)ctrl2;
                                if (textBox.Text != "")
                                {
                                    string[] timeString = textBox.Text.Split(':');
                                    int hour;
                                    int minute;
                                    int.TryParse(timeString[0], out hour);
                                    int.TryParse(timeString[1], out minute);
                                    TimeSpan timeSpan = new TimeSpan(hour, minute, 0);
                                    DateTime time = date.Add(timeSpan);
                                    wetBed.Time = time;
                                    wetBeds.Add(wetBed);
                                }
                            }
                            if (ctrl2.ID.StartsWith("wetBedSizeDropDown"))
                            {
                                DropDownList dropDownList = (DropDownList)ctrl2;
                                foreach (SpotSize spotSize in Enum.GetValues(typeof(SpotSize)))
                                {
                                    if (dropDownList.SelectedItem.ToString() == spotSize.ToString())
                                    {
                                        wetBed.Size = spotSize;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            questionnaire.WetBeds = wetBeds;

            List<ToiletVisit> toiletVisits = new List<ToiletVisit>();
            foreach (Control ctrl in toiletVisitsPanel.Controls)
            {
                if (ctrl.ID != null)
                {
                    if (ctrl.ID.StartsWith("toiletVisitTimeTextBox"))
                    {
                        TextBox textBox = (TextBox)ctrl;
                        if (textBox.Text != "")
                        {
                            ToiletVisit toiletVisit = new ToiletVisit();
                            toiletVisit.Id = 0;

                            string[] timeString = textBox.Text.Split(':');
                            int hour;
                            int minute;
                            int.TryParse(timeString[0], out hour);
                            int.TryParse(timeString[1], out minute);
                            TimeSpan timeSpan = new TimeSpan(hour, minute, 0);
                            DateTime time = date.Add(timeSpan);
                            toiletVisit.Time = time;
                            toiletVisits.Add(toiletVisit);
                        }
                    }
                }
            }
            questionnaire.ToiletVisits = toiletVisits;
            questionnaire.Motivation = int.Parse(motivationDropDown.SelectedItem.ToString());
            questionnaire.Comment = commentTextBox.Text;
            questionnaire.PleaseContact = contactCheckBox.Checked;

            // Patient midlertidig:
            Patient patient = new Patient() { Age = 13, Id = 1, Name = "Poul" };
            patient.Questionnaires = new List<Questionnaire>() { questionnaire };

            if (bedwetterService.SubmitQuestionnaire(questionnaire, patient) == true)
            {
                Response.Redirect("QuestionnaireSuccess.aspx");
            }

        }

        private void createWetBedCtrl(string id)
        {
            Panel wetBedPanel = new Panel();
            wetBedPanel.ID = "wetBedPanel" + id;
            wetBedPanel.EnableViewState = true;
            wetBedIncidentsPanel.Controls.Add(wetBedPanel);

            Label timeLabel = new Label();
            timeLabel.ID = "wetBedTimeLabel" + id;
            timeLabel.Text = "Time:";
            timeLabel.Width = 60;
            timeLabel.EnableViewState = true;
            wetBedPanel.Controls.Add(timeLabel);

            TextBox timeTextBox = new TextBox();
            timeTextBox.ID = "wetBedTimeTextBox" + id;
            timeTextBox.EnableViewState = true;
            wetBedPanel.Controls.Add(timeTextBox);

            RegularExpressionValidator validator = new RegularExpressionValidator();
            validator.ValidationExpression = "(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$";
            validator.ControlToValidate = "wetBedTimeTextBox" + id;
            validator.ErrorMessage = "Time must entered in format HH:MM (ex. 22:15)";
            validator.ForeColor = System.Drawing.Color.Red;
            wetBedPanel.Controls.Add(validator);

            wetBedPanel.Controls.Add(new LiteralControl("<br/>"));

            Label sizeLabel = new Label();
            sizeLabel.ID = "wetBedSizeLabel" + id;
            sizeLabel.Text = "Size:";
            sizeLabel.Width = 60;
            sizeLabel.EnableViewState = true;
            wetBedPanel.Controls.Add(sizeLabel);

            DropDownList sizeDropDown = new DropDownList();
            sizeDropDown.ID = "wetBedSizeDropDown" + id;
            sizeDropDown.DataSource = Enum.GetValues(typeof(SpotSize));
            sizeDropDown.DataBind();
            sizeDropDown.EnableViewState = true;
            wetBedPanel.Controls.Add(sizeDropDown);

            wetBedPanel.Controls.Add(new LiteralControl("<br/>"));
            wetBedPanel.Controls.Add(new LiteralControl("<br/>"));
        }

        private void createToiletVisitCtrl(string id)
        {
            Label timeLabel = new Label();
            timeLabel.ID = "toiletVisitTimeLabel" + id;
            timeLabel.Text = "Time:";
            timeLabel.Width = 60;
            timeLabel.EnableViewState = true;
            toiletVisitsPanel.Controls.Add(timeLabel);

            TextBox timeTextBox = new TextBox();
            timeTextBox.ID = "toiletVisitTimeTextBox" + id;
            timeTextBox.EnableViewState = true;
            toiletVisitsPanel.Controls.Add(timeTextBox);

            RegularExpressionValidator validator = new RegularExpressionValidator();
            validator.ValidationExpression = "(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$";
            validator.ControlToValidate = "toiletVisitTimeTextBox" + id;
            validator.ErrorMessage = "Time must entered in format HH:MM (ex. 22:15)";
            validator.ForeColor = System.Drawing.Color.Red;
            toiletVisitsPanel.Controls.Add(validator);

            toiletVisitsPanel.Controls.Add(new LiteralControl("<br/>"));
            toiletVisitsPanel.Controls.Add(new LiteralControl("<br/>"));
        }
    }
}