using Panuon.UI.Silver;
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
    /// shehzi.xaml 的交互逻辑
    /// </summary>
    public partial class shehzi : Page
    {
        public shehzi()
        {
            InitializeComponent();
            Loaded += Shehzi_Loaded;
        }

        private void Shehzi_Loaded(object sender, RoutedEventArgs e)
        {
            textbox1.Text = App.liebiao_Fuwuqi.liebiao_dizhi;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.liebiao_Fuwuqi.liebiao_dizhi = textbox1.Text;
            if(App.liebiao_Fuwuqi.baocun()==false)
            {
                Notice.Show("保存列表服务器配置失败", "保存失败", 7, MessageBoxIcon.Error);
            }
            else
            {
                Notice.Show("保存列表服务器配置成功", "保存成功", 5, MessageBoxIcon.Success);
                if (NavigationService.CanGoBack)
                {
                    NavigationService.GoBack();
                }
            }
        }
    }
}
