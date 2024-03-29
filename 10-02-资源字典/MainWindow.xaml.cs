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

namespace _10_02_资源字典
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Uri uri = new Uri("pack://application:,,,/10-02-TestLib;component/MyDic.xaml");
            ResourceDictionary myDic = new ResourceDictionary();
            //myDic.Source = uri;

            //SolidColorBrush solidColorBrush = (SolidColorBrush)myDic["Red"];
        }
    }
}
