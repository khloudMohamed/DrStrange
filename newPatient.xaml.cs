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
using System.Windows.Shapes;

namespace DoctorStrange
{
    /// <summary>
    /// Interaction logic for newPatient.xaml
    /// </summary>
    public partial class newPatient : Window
    {
        public newPatient()
        {
            InitializeComponent();
            string currentLanguage = System.Globalization.CultureInfo.CurrentCulture.IetfLanguageTag;

            AddNewPatient.Language = System.Windows.Markup.XmlLanguage.GetLanguage("ar-SA");
            AddNewPatient.FlowDirection = FlowDirection.RightToLeft;

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddNewP_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
