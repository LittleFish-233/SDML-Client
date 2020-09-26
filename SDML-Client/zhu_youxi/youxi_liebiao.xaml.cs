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

namespace SDML_Client.zhu_youxi
{
    /// <summary>
    /// youxi_liebiao.xaml 的交互逻辑
    /// </summary>
    public partial class youxi_liebiao : Page
    {
        public youxi_liebiao()
        {
            InitializeComponent();
            Loaded += Youxi_liebiao_Loaded;
        }

        private void Youxi_liebiao_Loaded(object sender, RoutedEventArgs e)
        {
            App.shijian.Xianshitishi += Shijian_Xianshitishi;
        }

        private void Shijian_Xianshitishi(string a, int xuhao)
        {
            if (a != null)
            {
                if (a == "游戏列表")
                {
                    NavigationService.Navigate(new youxi_zhu());
                }
            }
        }

        private void WaterfallViewer_LazyLoading(object sender, RoutedEventArgs e)
        {

        }

    }
}
