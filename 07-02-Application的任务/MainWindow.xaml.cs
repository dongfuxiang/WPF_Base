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

namespace _07_02_Application的任务
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
            //拿到整个应用程序的对象
            string? filePath = ((App)Application.Current).FilePath;
            MessageBox.Show($"MainWindow->{filePath}");
        }

        private void btnCreateWindow_Click(object sender, RoutedEventArgs e)
        {
            Document document = new Document();
            document.Show();//非模态方式打开窗口，模态：打开窗口时锁UI不能操控其他窗口
            ((App)Application.Current).Documents.Add(document);//添加到APP中
        }

        /// <summary>
        /// 更新数据到所有打开的窗口中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateWindow_Click(object sender, RoutedEventArgs e)
        {
            foreach(var document in ((App)Application.Current).Documents)
            {
                document.SetCotent(DateTime.Now.ToString());
            }
        }
    }
}
