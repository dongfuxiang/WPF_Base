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

namespace _16_05_使用代码创建故事板
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

        private void image_MouseEnter(object sender, MouseEventArgs e)
        {

            Storyboard storyboard = new Storyboard();

            DoubleAnimation animation1 = new DoubleAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(0.5)),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever,
                From = 1,
                To = 0
            };
            DoubleAnimation animation2 = new DoubleAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(5)),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever,
                From = 10,
                To =300,
                EasingFunction = new ElasticEase()
                {
                    Oscillations = 1,
                    EasingMode = EasingMode.EaseIn,
                }
            };
            DoubleAnimation animation3 = new DoubleAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(5)),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever,
                From = 10,
                To = 300,
                EasingFunction = new ElasticEase() 
                { 
                    Oscillations=1,
                    EasingMode=EasingMode.EaseIn,
                }

            };


            storyboard.Children.Add(animation1);
            storyboard.Children.Add(animation2);
            storyboard.Children.Add(animation3);

            //建立关联，将Property关联到Animation
            Storyboard.SetTargetProperty(animation1, new PropertyPath("RenderTransform.Children[0].ScaleX"));
            Storyboard.SetTargetProperty(animation2, new PropertyPath("(Canvas.Right)"));
            Storyboard.SetTargetProperty(animation3, new PropertyPath("(Canvas.Bottom)"));


            image.BeginStoryboard(storyboard);
        }
    }
}
