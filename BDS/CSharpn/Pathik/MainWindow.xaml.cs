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

namespace Pathik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResetForm();
            
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ResetForm();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Activity activity = new Activity(int.Parse(LaneNumberTextBox.Text), VehicleNumberTextBox.Text, VehicleTypeComboBox.SelectedIndex);
            ResetForm();
        }

        private void ResetForm()
        {
            LaneNumberTextBox.Text = "";
            VehicleNumberTextBox.Text = "";
            VehicleTypeComboBox.SelectedItem = 0;
        }
    }
}
