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

namespace _17_03_组织模板资源
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
            //更改APP的资源列表

            //方法1
            //App.Current.Resources.MergedDictionaries[1] = new ResourceDictionary()
            //{
            //    Source = new Uri("ButtonStyles2.xaml",UriKind.Relative)
            //};

            //方法2
            App.Current.Resources.MergedDictionaries[1] = new ButtonStyles2();
        }
    }
}
