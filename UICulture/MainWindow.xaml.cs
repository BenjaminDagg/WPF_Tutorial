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
using System.Globalization;

namespace UICulture
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// - Numbers/Dates may be formatted differently depending on your country
    /// - .NET defaults data/numbers to system settings of the computer when the app is run
    /// - CultureInfo class helps you format numbers/dates
    /// 
    /// 2 properties of Thread class
    /// - CurrentCulture : controls numbers dates and gets values from OS. Can be changed independant of language
    /// - CurrentUICulture : language of interface
    /// 
    /// -these let you use one culture for numbrs/dates while keeping the language different
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Ad-hoc formatting for specific labels

            double largeNumber = 123456789.42;

            CultureInfo usCulture = new CultureInfo("en-US");
            CultureInfo deCulture = new CultureInfo("de-DE");
            CultureInfo seCulture = new CultureInfo("sv-SE");

            lblNumbersUS.Content = largeNumber.ToString("N2",usCulture);
            lblNumbersDE.Content = largeNumber.ToString("N2", deCulture);
            lblNumbersSE.Content = largeNumber.ToString("N2", seCulture);
            lblDefault.Content = largeNumber.ToString();
        }

        private void Button_SwitchCulture(object sender, RoutedEventArgs e)
        {
            
            double largeNumber = 123456789.42;

            CultureInfo culture = new CultureInfo(((Button)sender).Tag.ToString());

            lblNumber.Content = largeNumber.ToString("N2",culture);
            lblDate.Content = DateTime.Now.ToString(culture);
        }
    }
}
