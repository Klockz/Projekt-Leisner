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
using System.

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

            gridQ.Visibility = Visibility.Hidden;

            
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
