using _19_02_绑定到对象集合.Model;
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

namespace _19_02_绑定到对象集合
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //list没有实现数据变更通知（和自建的类无法实现消息通知一个道理，没有继承INotifyPropertyChanged），必须使用ObservableCollection
        List<Product> list = new List<Product>();

        //ObservableCollection实现了，在集合类型中十分常用
        ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                list.Add(
                    new Product() 
                    {
                    Number=$"Number_{i}",
                    Name=$"Name_{i}",
                    Cost=i,
                    Description=$"Description_{i}"
                    }
                    );
            }

            products = new ObservableCollection<Product>(list);
            ListBox.ItemsSource = products;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (true)
            {

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            products.Add(
                  new Product()
                  {
                      Number = $"Number_30",
                      Name = $"Name_30",
                      Cost = 30,
                      Description = $"Description_30"
                  }
                  );
        }
    }
}
