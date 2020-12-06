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

namespace DoctorStrange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string currentLanguage = System.Globalization.CultureInfo.CurrentCulture.IetfLanguageTag;

            Tasks.Language = System.Windows.Markup.XmlLanguage.GetLanguage("ar-SA");
            Tasks.FlowDirection = FlowDirection.RightToLeft;
        }

        private void btnAddNewP_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                newPatient _frmNewPatient = new newPatient();
                _frmNewPatient.Show();
            }
            catch
            {

            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnShowAll_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ShowAll _showAll = new ShowAll();
                _showAll.Show();
            }
            catch
            {

            }
        }

        private void btninfo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAppointments_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SearchForPatient _searchForPatient = new SearchForPatient();
                _searchForPatient.Show();
            }
            catch
            {

            }
        }
    }
}
