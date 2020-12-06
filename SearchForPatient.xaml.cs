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
    /// Interaction logic for SearchForPatient.xaml
    /// </summary>
    public partial class SearchForPatient : Window
    {
        public SearchForPatient()
        {
            InitializeComponent();
            string currentLanguage = System.Globalization.CultureInfo.CurrentCulture.IetfLanguageTag;

            Search.Language = System.Windows.Markup.XmlLanguage.GetLanguage("ar-SA");
            Search.FlowDirection = FlowDirection.RightToLeft;
        }

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
