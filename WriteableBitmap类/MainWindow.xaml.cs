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
            InitializeComponent();
            //图片宽、高(单位：像素)、DPI_X、DPI_Y（DPI分辨率）、图像格式
            //最开始是一个黑色的矩形
            WriteableBitmap writeableBitmap = new WriteableBitmap((int)image.ActualHeight, (int)image.Height, 96, 96, PixelFormats.Bgr32, null);

            //写像素
            //更新区域左上角的X和Y坐标，以及更新区域的宽度和高度
            Int32Rect rect = new Int32Rect(0,0,1,1);

            //一个像素
            byte b = 0xFF;
            byte g = 0x00;
            byte r = 0x00;
            byte a = 0xFF;
            //顺序必须是蓝、绿、红、透明
            byte[] bytes= { b,g,r,a};
            //把bytes写入rect
            writeableBitmap.WritePixels(rect, bytes, 4, 0);


            image.Source = writeableBitmap;
        }
    }
}
