using _22_01_ListView控件.Models;
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

namespace _22_01_ListView控件
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
            ObservableCollection<Person> persons = new ObservableCollection<Person>();

            for (int i = 0; i < 10; i++)
            {
                persons.Add(new Person
                {
                    Name = i.ToString(),
                    Id = i,
                    Age = i * i,
                    Garder = i % 2 == 0 ? "F" : "M"
                });
            }
            LvPersons.ItemsSource = persons;
        }
    }
}
