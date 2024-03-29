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

namespace _06_05_列表控件
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                list.Add($"ListItem{i}");
            }
            //将list加到listBox
            //传统方式
            for (int i = 0; i < list.Count; i++)
            {
                listBox.Items.Add(list[i]);
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox != null)
            {
                object obj = listBox.SelectedItem;
                MessageBox.Show(obj.ToString());
            }

        }

        private void ComboBox_DropDownOpened(object sender, EventArgs e)
        {

        }
    }
}
