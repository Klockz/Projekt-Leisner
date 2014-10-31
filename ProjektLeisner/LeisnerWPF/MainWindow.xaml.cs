using LeisnerWPF.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace LeisnerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BedwetterServiceClient client;

        public MainWindow()
        {
            InitializeComponent();

            client = new BedwetterServiceClient();

        }

        private void btnGetCustomers_Click(object sender, RoutedEventArgs e)
        {
            listCustomer.ItemsSource = client.GetAllCustomers();
            

        }

        private void listCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Customer customer = (Customer)listCustomer.SelectedItem;

            listPatient.ItemsSource = customer.Patients;
        }

        private void listPatient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Patient patient = (Patient)listPatient.SelectedItem;

            listQuestionnaire.ItemsSource = patient.Questionnaires;

            // make graph
            WetBed wb2 = new WetBed()
            {
                Time = DateTime.Parse("2010-10-10").AddHours(8).AddMinutes(10),
                Size = SpotSize.L,
            };
            WetBed wb1 = new WetBed()
            {
                Time = DateTime.Parse("2010-10-10").AddHours(10).AddMinutes(10),
                Size = SpotSize.M,
            };
            WetBed wb3 = new WetBed()
            {
                Time = DateTime.Parse("2010-10-10").AddHours(8).AddMinutes(40),
                Size = SpotSize.S,
            };
            WetBed wb4 = new WetBed()
            {
                Time = DateTime.Parse("2010-10-10").AddHours(9).AddMinutes(10),
                Size = SpotSize.XL,
            };

            PlotModel peeTrendPlotModel = new PlotModel {Title = "Tissetrends"};
            DateTimeAxis dateTimeAxis = new DateTimeAxis(AxisPosition.Bottom, "Tid og Dato", "dd/MM/yy HH:mm");
            LinearAxis valueAxis = new LinearAxis(AxisPosition.Left, 0);
            dateTimeAxis.Minimum = DateTimeAxis.ToDouble(wb2.Time.AddMinutes(-10));
            dateTimeAxis.Maximum = DateTimeAxis.ToDouble(wb1.Time.AddMinutes(10));
            valueAxis.Minimum = -0.1;
            valueAxis.Maximum = 5.1;
            peeTrendPlotModel.Axes.Add(dateTimeAxis);
            peeTrendPlotModel.Axes.Add(valueAxis);

            LineSeries series = new LineSeries
            {
                MarkerSize = 3,
                MarkerStroke = OxyColors.Green,
                StrokeThickness = 1,
                MarkerType = MarkerType.Star,
            };
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(wb2.Time), (double)wb2.Size));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(wb3.Time), (double)wb3.Size));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(wb4.Time), (double)wb4.Size));
            series.Points.Add(new DataPoint(DateTimeAxis.ToDouble(wb1.Time), (double)wb1.Size));
            peeTrendPlotModel.Series.Add(series);

            peeTrendPlotView.Model = peeTrendPlotModel;
        }

        private void listQuestionnaire_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Questionnaire questionnaire = (Questionnaire)listQuestionnaire.SelectedItem;

            gridQ.Visibility = Visibility.Visible;

            listWetBeds.ItemsSource = questionnaire.WetBeds;
            listToiletVisits.ItemsSource = questionnaire.ToiletVisits;

            txtQComment.Text = questionnaire.Comment;
            txtQContact.Text = questionnaire.PleaseContact.ToString();
            txtQDate.Text = questionnaire.Date.ToShortDateString();
            txtQMotivation.Text = questionnaire.Motivation.ToString();
        }

        private void listWetBeds_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            WetBed wetBed = (WetBed)listWetBeds.SelectedItem;

           
        }

        private void listToiletVisits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}
