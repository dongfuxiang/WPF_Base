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

namespace _06_04_文本控件
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

        private void tbInfo_SelectionChanged(object sender, RoutedEventArgs e)
        {
            string str = tbInfo.SelectedText;
            if (!string.IsNullOrEmpty(str))
                txbShow.Text = str;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(pdPassWord.Password))
            {
                MessageBox.Show($"PassWord：{pdPassWord.Password}");
            }
        }
    }
}
