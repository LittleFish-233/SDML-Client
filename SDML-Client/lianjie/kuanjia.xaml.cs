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
using System.Windows.Shapes;

namespace SDML_Client.lianjie
{
    /// <summary>
    /// kuanjia.xaml 的交互逻辑
    /// </summary>
    public partial class kuanjia : WindowX
    {
        public kuanjia()
        {
            InitializeComponent();
            Loaded += Kuanjia_Loaded;
            App.shijian.Xianshitishi += Shijian_Xianshitishi;
        }

        private void Shijian_Xianshitishi(string a, int xuhao)
        {
            if (a != null)
            {
                if (a == "列表服务器")
                {
                    switch (xuhao)
                    {
                        case 1:
                            zhuye isw1 = new zhuye();
                            isw1.Show();//无模式，弹出！
                            Window window1 = Window.GetWindow(this);//关闭父窗体
                            window1.Close();
                            break;
                        case 2:
                            break;
                    }
                }

            }
        }

        private void Kuanjia_Loaded(object sender, RoutedEventArgs e)
        {
            zhu page = new zhu();
            fram1.Content = page;
        }
    }
}
