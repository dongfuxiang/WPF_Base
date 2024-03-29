using _19_01_绑定到数据对象.Model;
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

namespace _19_01_绑定到数据对象
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User User= new User() { UserName = "ADMIN", Password = "123" };
        public MainWindow()
        {
            InitializeComponent();
            DataContext = User;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"UserName：{User.UserName}\n\rPwd：{User.Password}");
        }
    }
}
