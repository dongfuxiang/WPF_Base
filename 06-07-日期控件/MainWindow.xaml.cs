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

namespace _06_07_日期控件
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
            DateTime? dateTime1 = myCal.SelectedDate;
            DateTime? dateTime2 = myDate.SelectedDate;
            if (dateTime1 != null && dateTime2 != null)
            {
                string str = $"dateTime1：{dateTime1}\r\ndateTime2：{dateTime2}";
                MessageBox.Show(str);
            }
        }
    }
}
