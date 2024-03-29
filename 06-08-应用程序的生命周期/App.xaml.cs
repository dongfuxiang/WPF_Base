using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace _06_08_应用程序的生命周期
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        

        /// <summary>
        /// 应用程序一创建就会触发，早于任何窗口的初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Startup(object sender, StartupEventArgs e)
        {

        }
        /// <summary>
        /// 整个应用程序生命周期第一个回调的函数
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }
        /// <summary>
        /// 退出Main函数结束应用程序之前，可在这释放大型资源、保存文档
        /// </summary>
        /// <param name="e"></param>
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }
        /// <summary>
        /// 电脑关机或进入休眠状态时
        /// </summary>
        /// <param name="e"></param>
        protected override void OnSessionEnding(SessionEndingCancelEventArgs e)
        {
            base.OnSessionEnding(e);
        }
        /// <summary>
        /// 当别的程序窗口切换到此程序时
        /// </summary>
        /// <param name="e"></param>
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
        }
        /// <summary>
        /// 当此程序窗口切换到别的程序窗口时
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDeactivated(EventArgs e)
        {
            base.OnDeactivated(e);
        }
        //[STAThread]
        //static void Main()
        //{
        //    App app=new App();
        //    app.MyInit();
        //    //Application调用Run以后，程序就运行了
        //    app.Run();
        //}
        ///// <summary>
        ///// 初始化函数
        ///// </summary>
        //void MyInit()
        //{
        //    //设置启动窗口
        //    this.StartupUri = new Uri("MainWindow.xaml");
        //}
    }
}
