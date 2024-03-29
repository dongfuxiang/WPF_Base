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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _15_02_基本动画
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
            Button button = (Button)sender;
            //Width是double类型
            DoubleAnimation widthdoubleAnimation = new DoubleAnimation
            {
                //From = button.ActualWidth,
                //To = 200,
                By = 50,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                //反向重播
                AutoReverse = true,
                //是否保留运动后的值
                FillBehavior=FillBehavior.Stop,
                //反复运动几次
                RepeatBehavior=new RepeatBehavior(2)
            };

            widthdoubleAnimation.Completed += WidthdoubleAnimation_Completed;

            button.BeginAnimation(Button.WidthProperty, widthdoubleAnimation);
        }

        private void WidthdoubleAnimation_Completed(object? sender, EventArgs e)
        {
            //动画运行完成后清除属性上的动画，不然没法更改其属性
            btn.BeginAnimation(Button.WidthProperty, null);
        }
    }
}
