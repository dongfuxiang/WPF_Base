using _09_02_WPF命令模型和应用.Model;
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

namespace _09_02_WPF命令模型和应用
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //StackPanel 的DataContext绑定User类,
            //此时StackPanel容器内的子元素可以绑定到User类中的属性
            //spForm.DataContext = new User();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //spForm.DataContext其实就是User对象
            User user = spForm.DataContext as User;
        }
    }
}
