using Panuon.UI.Silver;
using SDML_Client.zhu_youxi;
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

namespace SDML_Client
{
    /// <summary>
    /// zhuye.xaml 的交互逻辑
    /// </summary>
    public partial class zhuye : WindowX
    {
        public zhuye()
        {
            InitializeComponent();
            Loaded += Zhuye_Loaded;
        }

        private void Zhuye_Loaded(object sender, RoutedEventArgs e)
        {
            youxi_liebiao page = new youxi_liebiao();
            zhu_frame.Content = page;
        }

        private void TreeView_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
