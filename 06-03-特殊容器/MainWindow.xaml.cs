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

namespace _06_03_特殊容器
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
            switch (button.Content)
            {
                case "LineUP":
                    scorllViewer.LineUp();
                    break;
                case "LineDown":
                    scorllViewer.LineDown();
                    break;
                case "PageUp":
                        scorllViewer.PageUp();
                    break;
                case "PageDown":
                    scorllViewer.PageDown();
                    break;
                case "ScrollToHome": 
                    scorllViewer.ScrollToHome();
                    break;
                case "ScrollToEnd": 
                    scorllViewer.ScrollToEnd();
                    break;
            }

        }
    }
}
