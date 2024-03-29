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

namespace _06_01_控件类
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //前景色
            btnA.Foreground = new SolidColorBrush(Colors.Red);
            //背景色
            btnA.Background = new SolidColorBrush()
            {
                Color = Colors.LightBlue
            };

            //可以指定具体的颜色，ARGB（透明），RGB（非透明）
            //方法1
            //Color myColor = new Color()
            //{
            //    R =93,
            //    G=107,
            //    B=152
            //};
            //方法二
            Color myColor = Color.FromRgb(93, 107, 152);
            btnA.Foreground= new SolidColorBrush(myColor);
            //方法三，从系统中获取颜色
            myColor = SystemColors.ControlColor;
            btnA.Foreground = new SolidColorBrush(myColor);
        }
    }
}
