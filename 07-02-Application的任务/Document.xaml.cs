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
using System.Windows.Shapes;

namespace _07_02_Application的任务
{
    /// <summary>
    /// Document.xaml 的交互逻辑
    /// </summary>
    public partial class Document : Window
    {
        public Document()
        {
            InitializeComponent();
        }
        public void SetCotent(object obj)
        {
            this.Content = obj;
        }
    }
}
