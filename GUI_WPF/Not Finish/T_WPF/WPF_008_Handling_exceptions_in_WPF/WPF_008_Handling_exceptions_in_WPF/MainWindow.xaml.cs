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

namespace WPF_008_Handling_exceptions_in_WPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = null;
            try
            {
                s.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            s.Trim();
        }
        /*
         Notice that I call the Trim() method an extra time, 
         outside of the try-catch block, so that the first call
         is handled, while the second is not. For the second one,
         we need the App.xaml magic:

         */

        /*
         We handle the exception much like the local one, but with a slightly different text and image in the message box. Also, notice that I set the e.Handled property to true. This tells WPF that we're done dealing with this exception and nothing else should be done about it.

Summary
Exception handling is a very important part of any application and fortunately, WPF and .NET makes it very easy to handle exceptions both locally and globally. You should handle exceptions locally when it makes sense and only use the global handling as a fallback mechanism, since local handling allows you to be more specific and deal with the problem in a more specialized way.
         */
    }
}
