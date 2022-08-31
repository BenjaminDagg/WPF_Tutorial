using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;
using System.Globalization;

namespace UICulture
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //Sets culture info for current thread
            //CultureInfo = date/number formatting, UI CUlture = language
            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            //if mulithreaded app then set culture for all future threads
            //DefaultCurrentCulture also applies to CurrentCulture
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("de-DE");

            MainWindow wnd = new MainWindow();
            wnd.Show();
        }
    }
}
