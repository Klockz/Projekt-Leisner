﻿using LeisnerWPF.ServiceReference1;
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

            plotPeeTrends(patient);
        }

        private void plotPeeTrends(Patient patient)
        {
            List<Questionnaire> questionnaires = patient.Questionnaires;
            questionnaires.Sort( (q1, q2) => q1.Date.CompareTo(q2.Date) );

            LineSeries wetBedSeries = new LineSeries
            {
                MarkerSize = 3,
                MarkerStroke = OxyColors.Red,
                Color = OxyColors.Red,
                StrokeThickness = 1,
                MarkerType = MarkerType.Star,
            };
            LineSeries toiletVisitSeries = new LineSeries
            {
                MarkerSize = 3,
                MarkerStroke = OxyColors.Green,
                Color = OxyColors.Green,
                StrokeThickness = 1,
                MarkerType = MarkerType.Star,
            };

            // forearch questionnaire, add wetbeds and toiletvisits
            foreach (var questionnaire in questionnaires)
            {
                double datePoint = DateTimeAxis.ToDouble(questionnaire.Date);
                wetBedSeries.Points.Add(new DataPoint(datePoint, questionnaire.WetBeds.Count));
                toiletVisitSeries.Points.Add(new DataPoint(datePoint, questionnaire.ToiletVisits.Count));
            }

            PlotModel peeTrendPlotModel = new PlotModel {Title = "Tissetrends"};
            DateTimeAxis dateTimeAxis = new DateTimeAxis(AxisPosition.Bottom, "Dato", "dd/MM/yy");
            LinearAxis valueAxis = new LinearAxis(AxisPosition.Left, 0);
            peeTrendPlotModel.Axes.Add(dateTimeAxis);
            peeTrendPlotModel.Axes.Add(valueAxis);
            peeTrendPlotModel.Series.Add(wetBedSeries);
            peeTrendPlotModel.Series.Add(toiletVisitSeries);

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