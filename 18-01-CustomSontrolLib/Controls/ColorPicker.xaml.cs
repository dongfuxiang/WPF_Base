using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

//依赖项属性是WPF样式、动画、数据绑定等的基础，可以说如果没有依赖项属性就没有
//WPF的样式、动画、数据绑定等的灵活应用
namespace _18_01_CustomSontrolLib.Controls
{
    /// <summary>
    /// ColorPicker.xaml 的交互逻辑
    /// </summary>
    public partial class ColorPicker : UserControl
    {
        #region 01属性和依赖项属性
        //3.包装依赖项属性
        //依赖项属性也是一种属性，所以要包装一下，暴露出一般属性的特性方便使用
        public Color MyColor
        {
            get => (Color)GetValue(ColorProperty);
            set { SetValue(ColorProperty, value); }
        }
        public byte Red
        {
            get => (byte)GetValue(RedProperty);
            set { SetValue(RedProperty, value); }
        }
        public byte Green
        {
            get => (byte)GetValue(GreenProperty);
            set { SetValue(GreenProperty, value); }
        }
        public byte Blue
        {
            get => (byte)GetValue(BlueProperty);
            set { SetValue(BlueProperty, value); }
        }

        //1.声明依赖项属性
        public static readonly DependencyProperty ColorProperty;
        public static readonly DependencyProperty RedProperty;
        public static readonly DependencyProperty GreenProperty;
        public static readonly DependencyProperty BlueProperty;
        #endregion


        /// <summary>
        /// 包装路由事件
        /// </summary>
        public event RoutedPropertyChangedEventHandler<Color> ColorChanged
        {
            add { AddHandler(ColorChangedEvent, value); }
            remove
            {
                RemoveHandler(ColorChangedEvent, value);
            }
        }

        /// <summary>
        /// 定义路由事件
        /// </summary>
        public static readonly RoutedEvent ColorChangedEvent;
        public ColorPicker()
        {
            InitializeComponent();
        }


        #region 02注册依赖项属性
        //2.注册依赖项属性
        //注意：必须再使用依赖项属性之前注册依赖项属性，所以依赖项属性总是再所在类静态构造函数或则静态字段中注册
        static ColorPicker()
        {
            //PropertyMetadata 希望依赖项属性使用什么服务
            //PropertyChangedCallback 当属性变换时调用此回调函数

            //PropertyMetadata pm = new PropertyMetadata(OnColorChanged)
            //{
            //    DefaultValue = Colors.Blue
            //}
            //参数分别为：依赖项属性名、依赖项属性数据类型、依赖项属性所在类类型、依赖项属性元数据和依赖项属性数据有效性验证回调函数
            ColorProperty = DependencyProperty.Register("MyColor",
                typeof(Color),
                typeof(ColorPicker),
                new(OnColorChanged)
                {
                    DefaultValue = Colors.White
                });//Color需要一个初始值

            RedProperty = DependencyProperty.Register("Red",
                typeof(byte),
                typeof(ColorPicker),
                new(OnRGBChanged));
            GreenProperty = DependencyProperty.Register("Green",
                typeof(byte),
                typeof(ColorPicker),
                new(OnRGBChanged));
            BlueProperty = DependencyProperty.Register("Blue",
                typeof(byte),
                typeof(ColorPicker),
                new(OnRGBChanged));


            //注册路由事件
            ColorChangedEvent = EventManager.RegisterRoutedEvent(
                "ColorChanged",//事件名
                RoutingStrategy.Bubble,//路由类型，冒泡
                typeof(RoutedPropertyChangedEventHandler<Color>),//事件类型
                typeof(ColorPicker)//属于哪个对象
                );

        }

        #endregion

        #region 03回调函数

        private static void OnColorChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            ColorPicker picker = sender as ColorPicker;

            //MyColor属性改变后会触发OnColorChanged()回调函数，获得新值
            Color newcolor = (Color)e.NewValue;
            Color oldcolor = (Color)e.OldValue;

            //解析Color解析到RGB
            picker.Red = newcolor.R;
            picker.Green = newcolor.G;
            picker.Blue = newcolor.B;

            //要在颜色改变后调用事件
            RoutedPropertyChangedEventArgs<Color> args =
                new RoutedPropertyChangedEventArgs<Color>(oldcolor, newcolor, ColorChangedEvent);
            //发送args，根据RoutedEvent类型判断发给谁（ColorChangedEvent），触发事件注册的事件处理器
            picker.RaiseEvent(args);
        }
        private static void OnRGBChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            ColorPicker picker = sender as ColorPicker;
            Color color = picker.MyColor;
            if (e.Property == RedProperty)
            {
                color.R = (byte)e.NewValue;
            }
            else if (e.Property == GreenProperty)
            {
                color.G = (byte)e.NewValue;
            }
            else if (e.Property == BlueProperty)
            {
                color.B = (byte)e.NewValue;
            }

            picker.MyColor = color;
        }
        #endregion


    }
}
