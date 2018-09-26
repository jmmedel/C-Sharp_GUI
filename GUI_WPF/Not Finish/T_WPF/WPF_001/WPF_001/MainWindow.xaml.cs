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
using System.Windows;
namespace WPF_001
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
        // you can add some fuctionality to this button
        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The Description is : {DiscriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            WeldCheckbox.IsChecked = AssemblyCheckbox.IsChecked = PlasmaCheckbox.IsChecked = LaserCheckbox.IsChecked =
            PurchaseCheckbox.IsChecked = LatheCheckbox.IsChecked = DriliCheckbox.IsChecked = FoldCheckbox.IsChecked = RollCheckbox.IsChecked = SawCheckbox.IsChecked = false;

        }

        private void Checkbox_Cheked(object sender, RoutedEventArgs e)
        {   // cast the checkedbox pass to the textbox 
            LengthText.Text += ((CheckBox)sender).Content + ",";
        }

        private void FinishDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {   // cast the combobox pass to the textbox
            // this is hard to solve 
            if (NoteText == null)
                return;
            // put if checkked if its null and return 
            // make it simple and easy to see
            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;
            //NoteText.Text += (string)((ComboBoxItem)((ComboBox)sender).SelectedValue).Content;
            NoteText.Text = (string)value.Content;
        }
        // loaded when windows is load 
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {   // the name the finish dropdown box  =  finish dropdown 
            FinishDropdown_SelectionChanged(Finish_Dropdown, null);
        }

        private void SupplierNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            MassText.Text = Supplier_Name_TextBox.Text;
        }
    }
}
