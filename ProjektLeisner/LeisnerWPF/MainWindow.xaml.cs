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
            
            

        }
    }
}
