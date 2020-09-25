using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDML_Client.daima
{
    /// <summary>
    /// 管理启动时链接列表服务器 用于获取主服务器地址
    /// </summary>
    public class Liebiao_fuwuqi
    {
        /// <summary>
        /// 配置文件版本号
        /// </summary>
        public const int banben = 1;
        /// <summary>
        /// 列表服务器地址
        /// </summary>
        public string liebiao_dizhi = "127.0.0.1:8000";

        /// <summary>
        /// 用于向列表服务器获取主服务器地址的识别码
        /// </summary>
        public string shibiema = "";

        /// <summary>
        /// 主服务器地址，若识别码不为空则每次先向列表服务器请求
        /// </summary>
        public string zhufuwuqi_dizhi = "";

        /// <summary>
        /// 保存配置信息
        /// </summary>
        /// <returns>是否成功</returns>
        public bool baocun()
        {
            try
            {
                //序列化json 将数据保存为json
                string data = new JObject(
                    new JProperty("banben", banben.ToString()),
                    new JProperty("liebiao_dizhi", liebiao_dizhi),
                    new JProperty("shibiema", shibiema),
                    new JProperty("zhufuwuqi_dizhi", zhufuwuqi_dizhi)).ToString();

                //新建文件
                FileStream xiaFile = new FileStream("infor.txt", FileMode.Create);
                //写入
                byte[] buf = Encoding.UTF8.GetBytes(data);
                xiaFile.Write(buf, 0, buf.Length);
                xiaFile.Flush();
                xiaFile.Close();

            }
            catch (Exception exc)
            {
                return false;
            }
            return true;
        }
        public bool duqu()
        {
            try
            {
                //打开文件
                FileInfo fi = new FileInfo("infor.txt");
                long len = fi.Length;

                FileStream fs = new FileStream("infor.txt", FileMode.Open);
                byte[] buffer = new byte[len];
                fs.Read(buffer, 0, (int)len);//读取文件
                fs.Close();//关闭
                string str = Encoding.UTF8.GetString(buffer);//转码
                string[] result = peizhi_jiexi(str);//解析Json
                //根据读取的数据初始化相应变量
                try
                {
                    if (result[0] != "")
                    {
                        liebiao_dizhi = result[0];
                    }
                    if (result[1] != "")
                    {
                        shibiema = result[1];
                    }
                    if (result[2] != "")
                    {
                        zhufuwuqi_dizhi = result[2];
                    }
                }
                catch
                {

                }
                //检查版本号是否一致
                if (banben.ToString() != result[7])
                {
                    //保存
                    baocun();
                }
                return true;

            }
            catch (Exception exc)
            {
                baocun();
                return false;
            }
        }
        /// <summary>
        /// 解析读取的配置文件Json 外部 负责匹配版本号
        /// </summary>
        /// <param name="str">配置文件json字符串</param>
        /// <returns>按照最新的变量列表返回字符串数组</returns>
        public static string[] peizhi_jiexi(string str)
        {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            switch (int.Parse(json["banben"].ToString()))
            {
                case 1:
                    return peizhi_jiexi_1(str);
                default:
                    return null;
            }
        }
        /// <summary>
        /// 解析读取的配置文件 版本1
        /// </summary>
        /// <param name="str">配置文件json字符串</param>
        /// <returns>按照最新的变量列表返回字符串数组</returns>
        private static string[] peizhi_jiexi_1(string str)
        {
            var json = (JObject)JsonConvert.DeserializeObject(str);
            var liebiao_dizhi = json["liebiao_dizhi"];
            var shibiema = json["shibiema"];
            var zhufuwuqi_dizhi = json["zhufuwuqi_dizhi"];
            //保存结果
            string[] re = new string[8];
            re[0] = liebiao_dizhi.ToString();
            re[1] = shibiema.ToString();
            re[2] = zhufuwuqi_dizhi.ToString();

            return re;
        }


    }
}
