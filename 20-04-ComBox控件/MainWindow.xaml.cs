using _20_04_ComBox控件.MOdels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _20_04_ComBox控件
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //可以通知消息更改的数据集合
            ObservableCollection<Product> products = new ObservableCollection<Product>();
            for (int i = 0; i < 10; i++)
            {
                products.Add(new Product()
                {
                    Id = i,
                    Name = $"Product{i}",
                    Price = 1 + i,
                    Description = $"Description{i}"
                });
            }
            CbProducts.ItemsSource = products;
        }
    }
}
