using _21_01_View对象.Models;
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

namespace _21_01_View对象
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ListCollectionView view = null!;

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
            //当使用DataContext接收整个List集合时，建立ViewSource关联，集合对象关联
            this.DataContext = products;
            view = (ListCollectionView)CollectionViewSource.GetDefaultView(this.DataContext);
            //切换时调用
            view.CurrentChanged += View_CurrentChanged;

            //CurrentPosition当前第几条数据
            string info = $"Record {view.CurrentPosition} of {view.Count}";
            TbInfo.Text = info;
        }

        private void View_CurrentChanged(object? sender, EventArgs e)
        {
            //CurrentPosition当前第几条数据
            string info = $"Record {view.CurrentPosition} of {view.Count}";
            TbInfo.Text = info;

            //当数据到了最后一条时禁用吓一跳按钮
            BtnNext.IsEnabled = view.CurrentPosition < view.Count - 1;
            BtnPre.IsEnabled = view.CurrentPosition > 0;
        }

        /// <summary>
        /// 切换到上一条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPre_Click(object sender, RoutedEventArgs e)
        {
            view.MoveCurrentToPrevious();
        }
        /// <summary>
        /// 切换到吓一条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            view.MoveCurrentToNext();
        }
    }
}
