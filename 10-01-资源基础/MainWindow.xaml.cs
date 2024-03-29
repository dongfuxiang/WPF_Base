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

namespace _10_01_资源基础
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //获取资源,修改资源内容，动态资源和静态资源都更改
            SolidColorBrush solidColorBrush1 = (SolidColorBrush)this.TryFindResource("MyBrush1");
            solidColorBrush1.Color = Colors.LightSeaGreen;
            SolidColorBrush solidColorBrush2 = (SolidColorBrush)this.FindResource("MyBrush2");
            solidColorBrush2.Color = Colors.LightSlateGray;
            //获取资源,重新new对象，静态资源不改，动态资源更改
            this.Resources["MyBrush1"] = new SolidColorBrush(Colors.LightSkyBlue);
            this.Resources["MyBrush2"] = new SolidColorBrush(Colors.LightSkyBlue);




        }
    }
}
