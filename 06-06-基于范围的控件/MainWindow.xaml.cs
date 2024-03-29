using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace _06_06_基于范围的控件
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
            //由于ProgressBar是UI线程，需要开一个新线程
            new Thread(() =>
            {
                

                for (int i = 0; i < 101; i++)
                {
                    Dispatcher.Invoke(new Action(() =>
                    {
                        progressbar.IsIndeterminate = false;
                        progressbar.Value = i;
                    }));

                    Thread.Sleep(100);
                }
            }).Start();
           
        }
    }
}
