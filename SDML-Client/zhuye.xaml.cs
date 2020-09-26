using Panuon.UI.Silver;
using SDML_Client.zhu_youxi;
using SDML_Client.zhu_zhaxiang;
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
            zhu_zhaxiang.kuanjia page = new zhu_zhaxiang.kuanjia();
            zhu_frame.Content = page;
        }

        private void TreeView_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (caidan.SelectedItem != null)
            {
                TreeViewItem selectedTnh = caidan.SelectedItem as TreeViewItem;
                int a = int.Parse(selectedTnh.Tag as string);
                switch (a)
                {
                    case 1:
                        zhu_zhaxiang.kuanjia page = new zhu_zhaxiang.kuanjia();
                        zhu_frame.Content = page;
                        break;
                    case 2:
                        break;
                    case 3:
                        zhu_youxi.youxi_liebiao page1 = new zhu_youxi.youxi_liebiao();
                        zhu_frame.Content = page1;
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }
            }
        }
    }
}
