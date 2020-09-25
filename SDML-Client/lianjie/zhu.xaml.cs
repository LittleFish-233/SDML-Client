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

namespace SDML_Client.lianjie
{
    /// <summary>
    /// zhu.xaml 的交互逻辑
    /// </summary>
    public partial class zhu : Page
    {
        public zhu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new shehzi());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.shijian.Kaishitishi("列表服务器", 1);
        }
    }
}
