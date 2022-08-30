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

namespace TheWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// - window class is root of application
    /// - WPF app is combination of XAML file with <Window></Window> root and .cs (CodeBehind window file)
    /// - class is partial because its combined with XAML to get full window (initialzecomponent)
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
