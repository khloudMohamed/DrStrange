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
    /// Interaction logic for ShowAll.xaml
    /// </summary>
    public partial class ShowAll : Window
    {
        clsDataBase db = new clsDataBase();
        List<clsPatientData> SavePatients = new List<clsPatientData>();
        public ShowAll()
        {
            InitializeComponent();
            string currentLanguage = System.Globalization.CultureInfo.CurrentCulture.IetfLanguageTag;

            SearchForAll.Language = System.Windows.Markup.XmlLanguage.GetLanguage("ar-SA");
            SearchForAll.FlowDirection = FlowDirection.RightToLeft;
        }

        private void SearchForAll_Loaded(object sender, RoutedEventArgs e)
        {
            SavePatients = db.GetSavedItems();
            grdResult.ItemsSource = SavePatients;
            grdResult.Items.Refresh();
        }
        string query0 = "";

        string query1 = "";
        string query2 = "";
        string query3 = "";
        string query4 = "";
        bool diffrenceFlag = false;
        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            bool found = false;
            var border = (resultStack.Parent as ScrollViewer).Parent as Border;
            var data = SavePatients;

            string query = (sender as TextBox).Text;


            if (query.Length == 0)
            {
                // Clear
                resultStack.Children.Clear();
                border.Visibility = System.Windows.Visibility.Collapsed;
                Panel.SetZIndex(stpSearchbar, 0);
                DataContext = this;

               
            }
            else
            {
                border.Visibility = System.Windows.Visibility.Visible;
                Panel.SetZIndex(stpSearchbar, 1);
                DataContext = this;
                switch (query[0])
                {
                    case 'ا':
                    case 'أ':
                    case 'إ':
                    case 'آ':
                        {
                            diffrenceFlag = true;
                            query0 = query;     
                            query = query.Substring(1, query.Length - 1);
                            query1 = 'ا' + query;
                            query2 = 'أ' + query;
                            query3 = 'إ' + query;
                            query4 = 'آ' + query;
                        }
                        break;
                    default:
                         diffrenceFlag = false; 
                        break;
                }

            }

            // Clear the list
            resultStack.Children.Clear();
            // Add the result
            foreach (var obj in data)
            {            
                if ((obj.PName.ToLower().Contains(query.ToLower())) && (diffrenceFlag == false))
                {
                    // The word starts with this... Autocomplete must work
                    addItem(obj.PName);
                    found = true;
                }
                else if (diffrenceFlag)
                {
                    switch (query0[0])
                    {
                        case 'ا':                     
                        case 'أ':
                        case 'إ':
                        case 'آ':
                            {
                                if (obj.PName.ToLower().Contains(query1.ToLower()))
                                {
                                    addItem(obj.PName);
                                    found = true;
                                }
                                if (obj.PName.ToLower().Contains(query2.ToLower()))
                                {
                                    addItem(obj.PName);
                                    found = true;
                                }
                                if (obj.PName.ToLower().Contains(query3.ToLower()))
                                {
                                    addItem(obj.PName);
                                    found = true;
                                }
                                if (obj.PName.ToLower().Contains(query4.ToLower()))
                                {
                                    addItem(obj.PName);
                                    found = true;
                                }
                            }
                            break;
                    }
                    
                }
            }

            if (!found)
            {
                resultStack.Children.Add(new TextBlock() { Text = "No results found." });
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox.Text != "")
            {
                //int index = SavePatients.FindIndex(x => x.ItemName == textBox.Text);
                //if (index > -1)
                //{
                //    clsInvoice tempItem = new clsInvoice();
                //    tempItem.Name = SavePatients[index].ItemName;
                //    tempItem.Price = SavePatients[index].ItemPrice;

                //    //InvoiceItems.Add(tempItem);
                //    RefreshGrids();
                //    grvInvoice_CellValueChanged();
                //}
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void addItem(string text)
        {
            TextBlock block = new TextBlock();

            block.Text = text;
            block.Margin = new Thickness(2, 3, 2, 3);
            block.Cursor = Cursors.Hand;
            block.Focusable = true;

            //// Mouse events
            block.MouseLeftButtonUp += (sender, e) =>
            {
                textBox.Text = (sender as TextBlock).Text;
            };
            block.MouseLeftButtonDown += (sender, e) =>
            {
                textBox.Text = (sender as TextBlock).Text;
                Panel.SetZIndex(stpSearchbar, 0);
                DataContext = this;

            };

            block.MouseEnter += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.PeachPuff;

            };

            block.MouseLeave += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.Transparent;

            };

            block.LostFocus += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.White;

            };
            block.GotFocus += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.PeachPuff;
            };

            block.KeyDown += (sender, e) =>
            {
                if (e.Key == Key.Enter)
                {
                    textBox.Text = (sender as TextBlock).Text;
                    Panel.SetZIndex(stpSearchbar, 0);
                    DataContext = this;
                }
            };

            // Add to the panel
            resultStack.Children.Add(block);
        }
    }
}
