using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Resources;
using System.Windows.Shapes;

namespace _07_03_程序集资源
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 读取WPF的资源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //相对路径
            Uri uri = new Uri("Images/1.jpg",UriKind.Relative);
            //读取资源
            StreamResourceInfo sri = App.GetResourceStream(uri);
            string type = sri.ContentType;
            using (Stream stream = sri.Stream)
            {

            }
        }

        private void btnImage_Click(object sender, RoutedEventArgs e)
        {
            //BitmapImage继承自ImageSource
            //image.Source =new  BitmapImage(new Uri("Images/2.jpg", UriKind.Relative));

            //在WPF中，URI的绝对路径,
            //string u = "pack://application:,,,/Images/3.jpg";

            //调用其他程序集的资源

            //string u = "pack://application:,,,/07-03-TestLib;component/Images/2.jpg";
            //Uri uri = new Uri(u, UriKind.Absolute);
            string u = "/07-03-TestLib;component/Images/1.jpg";
            Uri uri=new Uri(u, UriKind.Relative);
            image.Source = new BitmapImage(uri);

        }

        private void btnReadWebImage_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://huamaobizhi.com/appApi/wallpaper" +
                "/getImages_1_0/?pid=12248&resolution=1000w680h";
            image.Source=new BitmapImage(new Uri(url));
        }
    }
}
