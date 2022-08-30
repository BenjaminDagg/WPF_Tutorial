using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace App_XAML
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// 
    /// -starting point of app
    /// - .NET goes to thispage for start instructions then starts desired window
    /// - This is where you subscribe to application events like start, unhandled exceptions
    /// </summary>
    public partial class App : Application
    {

        //Override StartupUri property of Application to manually set startup
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Title = "Something else";

            wnd.Show();
        }
    }
}
