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

namespace _08_01_将元素绑定在一起
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Binding binding = new Binding()
            {
                //源对象
                Source = tbInfo,
                //Path
                Path = new PropertyPath("Text"),
                //绑定模式，双向绑定、单向绑定等
                Mode = BindingMode.Default,
                //什么时候更改数据，源或目标属性改变时、失去焦点时等
                UpdateSourceTrigger = UpdateSourceTrigger.LostFocus
            };
            //C#代码创建绑定 (依赖项属性（即要绑定的属性），binding对象)
            textInfo.SetBinding(TextBlock.FontSizeProperty, binding);
        }
    }
}
