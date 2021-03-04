﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SeepageAnalysis.Views;

namespace SeepageAnalysis
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
           // new SceneVtk().Show();
            new MainWindow().Show();
            base.OnStartup(e);
        }
    }
}
