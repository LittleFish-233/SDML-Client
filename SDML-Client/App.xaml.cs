﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SDML_Client
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public static daima.Liebiao_fuwuqi liebiao_Fuwuqi = new daima.Liebiao_fuwuqi();
        public static daima.Shijian shijian = new daima.Shijian();
    }
}
