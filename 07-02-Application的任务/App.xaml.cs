using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace _07_02_Application的任务
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //?允许为空,此处的FilePath变量为整个应用程序的公共变量
        public string? FilePath { get; set; }
        private void Application_Startup(object sender, StartupEventArgs e)
        {

            //使用win32接口的方式创建单例程序
            //互斥锁
            Mutex mutex = new Mutex(true, "单例程序", out bool isNewInt);
            if(!isNewInt)
            {
                //根据单例程序，找到应用程序的指针
                IntPtr intPtr = FindWindows(null, "单例程序");
                //如果没找到
                if(intPtr != IntPtr.Zero)
                {
                    //如果单例程序不存在，则继续启动
                    SetForefroundWindow(intPtr);
                }
                
                Shutdown();
            }




            //可以接收参数的方式，读取文件，或其他操作
            string[] cmds = e.Args;

            if (cmds != null && cmds.Length > 0)
            {
                foreach (string cmd in cmds)
                {
                    FilePath = cmd;
                    MessageBox.Show(cmd);
                }
            }
        }

        public List<Document> Documents { get; set; } = new List<Document>();
      
        
        //extern外部的，不是写好的，调用外部dll，此处引用Win32中的接口
        [DllImport("User32", CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindows(string lpClassNam, string lpWindowName);
        [DllImport("User32", CharSet = CharSet.Unicode)]
        static extern Boolean SetForefroundWindow(IntPtr hwnd);
    }
}
