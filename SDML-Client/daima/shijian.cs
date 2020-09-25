using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDML_Client.daima
{
    public class Shijian
    {
        //显示提示 1 警告 2 事件 3 错误
        public delegate void delegateRun(string a, int xuhao);
        //定义一个事件
        public event delegateRun Xianshitishi;

        //开始提示 
        public void Kaishitishi(string a, int xuhao)
        {
            Xianshitishi?.Invoke(a, xuhao);
        }
    }
}
