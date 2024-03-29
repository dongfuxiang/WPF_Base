using _21_02_过滤排序和分组.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace _21_02_过滤排序和分组
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ListCollectionView view = null!;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Person> persons = new ObservableCollection<Person>()
            {
                new Person { Id=0,Name="张三",Gerder="F",Age=18} ,
                new Person { Id=1,Name="李四",Gerder="F",Age=19},
                new Person { Id=2,Name="王五",Gerder="F",Age=17} ,
                new Person { Id=3,Name="赵六",Gerder="M",Age=20},
                new Person { Id=4,Name="张亮",Gerder="M",Age=16},
                new Person { Id=5,Name="王二麻子",Gerder="F",Age=40}
            };

            LbPeople.ItemsSource = persons;

            view = (ListCollectionView)CollectionViewSource.GetDefaultView(LbPeople.ItemsSource);
            //1.过滤
            //使用传统过滤方式 Link
            //IEnumerable<Person> persons2 = persons.Where(person => person.Id == 1);

            //创建一个委托,过滤Gerder为F的一条
            //view.Filter = m => ((Person)m).Gerder == "F";

            //2.排序
            //view.SortDescriptions.Add(new System.ComponentModel.SortDescription("Name", ListSortDirection.Ascending));
            //自定义排序
            //view.CustomSort = new NameSortByLength();

            //3.分组
            view.GroupDescriptions.Add(new PropertyGroupDescription("Gerder"));

        }
    }

    /// <summary>
    /// 如果希望自定义排序，则继承IComparer
    /// </summary>
    public class NameSortByLength : IComparer
    {
        public int Compare(object? x, object? y)
        {
            string name1 = ((Person)x).Name;
            string name2 = ((Person)y).Name;
            return name1.Length.CompareTo(name2.Length);
        }
    }

}
