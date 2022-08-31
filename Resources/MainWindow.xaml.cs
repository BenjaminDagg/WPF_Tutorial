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

namespace Resources
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// test
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        /*
         * Find Resources defined in Application (1st),window (2nd), and local (Panel, 3rd)
         * If resource isn't found in local level, it looks in window, if not found in window it looks in application
         * The same isn't true for the opposite, if resource isn't found in application it doesn't look down
         */
        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            lbResult.Items.Add(Application.Current.FindResource("ApplicationLevelResource").ToString());
            lbResult.Items.Add(this.FindResource("strWindow").ToString());
            lbResult.Items.Add(pnlMain.FindResource("panelResource").ToString());
        }
    }
}
