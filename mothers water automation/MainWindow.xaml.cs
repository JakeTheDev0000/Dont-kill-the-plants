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

namespace mothers_water_automation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void test_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hello", "hwello there");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string daysName = System.DateTime.Now.ToString("dddd");
            bool needsToWaterAtA = false;
            bool needsToWaterAtB= false;
            bool needsToWaterAtC = false;

            string monthName = DateTime.Now.ToString("MMMM");

            if (daysJakesName.Text == "")
            {

            }
            else
            {
                daysName = daysJakesName.Text;
            }

            if (daysName == "Monday")
            {
                needsToWaterAtA = true;
            }
            else if (daysName == "Tuesday")
            {
                needsToWaterAtB = true;
            }
            else if (daysName == "Wednesday")
            {
                needsToWaterAtC = true;
            }
            else if (daysName == "Thursday")
            {
                needsToWaterAtA = true;
                needsToWaterAtB = true;
            }
            else if (daysName == "Friday")
            {
                needsToWaterAtC = true;
            }
            else if (daysName == "Saturday")
            {
                needsToWaterAtB = true;
            }
            else if (daysName == "Sunday")
            {
                needsToWaterAtA = true;
                needsToWaterAtB = true;
                needsToWaterAtC = true;
            }

            MessageBox.Show($"its {monthName}\nIts also {daysName} so that means you need to water at section [sectionNameForToday]");



        }
    }
}
