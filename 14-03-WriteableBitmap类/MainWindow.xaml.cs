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

namespace _14_03_WriteableBitmap类
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            InitializeComponent();
            //图片宽、高(单位：像素)、DPI_X、DPI_Y（DPI分辨率）、图像格式
            //最开始是一个黑色的矩形
            WriteableBitmap writeableBitmap = new WriteableBitmap(500, 500, 96, 96, PixelFormats.Bgra32, null);


            //画一条直线
            for (int i = 0; i < 30; i++)
            {
                //写像素
                //更新区域(整个图片)左上角的X和Y坐标，以及更新区域的宽度和高度
                Int32Rect rect = new Int32Rect(i, i, 1, 1);

                //一个像素
                //byte b = 0xFF;
                //byte g = 0x00;
                //byte r = 0x00;
                //byte a = 0xFF;
                byte b = Convert.ToByte(new Random().Next(255));
                byte g = Convert.ToByte(new Random().Next(255));
                byte r = Convert.ToByte(new Random().Next(255));
                byte a = 0xFF;
                //顺序必须是蓝、绿、红、透明
                byte[] buffer = { b, g, r, a };
                //把bytes写入rect
                writeableBitmap.WritePixels(rect, buffer, 5000, 0);
            }

            image.Source = writeableBitmap;
        }
    }
}
