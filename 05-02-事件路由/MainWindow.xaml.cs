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

namespace _05_02_事件路由
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static int Count { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        //MouseUp为冒泡事件，会往上触发传递
        private void Something_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Count++;
            string str = $"Count：#{Count}\n\r sender：{sender}; Source：{e.Source}; OriginalSource：{e.OriginalSource}";
            lbMessage.Items.Add(str);
            // e.Handled= true;不继续传递
            //e.Handled= false;继续传递
            e.Handled = (bool)cbHandled.IsChecked!;//.Net6非空检查机制，必须要强调，使用!,表示此参数为非空的
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lbMessage.Items.Clear();
        }
    }
}
