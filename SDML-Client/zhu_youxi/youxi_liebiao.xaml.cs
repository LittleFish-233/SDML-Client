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
        }

        private void WaterfallViewer_LazyLoading(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pubu.Children.Add(new xinxi_dan());
        }
    }
}
