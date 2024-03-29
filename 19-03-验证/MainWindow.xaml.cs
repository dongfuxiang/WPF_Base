using _19_03_验证.Models;
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

namespace _19_03_验证
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User User = new User();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = User;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //传统方式，使用业务逻辑进行验证

        }


        private void Grid_Error(object sender, ValidationErrorEventArgs e)
        {
            //添加错误时才报错
            if (e.Action == ValidationErrorEventAction.Added)
            {
                MessageBox.Show(e.Error.ErrorContent.ToString());
            }

        }
    }
}
