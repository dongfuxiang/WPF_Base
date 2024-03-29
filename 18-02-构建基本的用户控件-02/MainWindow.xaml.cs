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

namespace _18_02_构建基本的用户控件_02
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

        public void ColorPicker_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {
            Color color = e.NewValue;
            if (tbColor != null)
                tbColor.Text = $"Color：R{color.R};G{color.G};B{color.B}";
        }
    }
}
