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

namespace _11_03_行为
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 是否拖动
        /// </summary>
        public bool isDrawing = false;
        /// <summary>
        /// 控件原始位置
        /// </summary>
        private Point ePoint = new Point();
        /// <summary>
        /// 鼠标原始位置
        /// </summary>
        private Point mPoint = new Point();

        private Canvas canvas;
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 鼠标按下的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Label label = sender as Label;
            //1.获得当前对象，相当于Canvas的位置
            ePoint.X = Canvas.GetLeft(label);
            ePoint.Y = Canvas.GetTop(label);

            //2.获得鼠标按下位置的原始值,GetPosition获得鼠标传入元素的相对位置，此处需要传入Canvas
            // LogicalTreeHelper.GetParent(label)获得label的父对象，此处是获得Canvas
            if (canvas != null)
                canvas = (Canvas)LogicalTreeHelper.GetParent(label);
            mPoint = e.GetPosition(canvas);

            //捕获鼠标
            label.CaptureMouse();

            //鼠标按下时可拖动
            isDrawing = true;
        }
        /// <summary>
        /// 鼠标移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Label label = sender as Label;
                //计算差值
                Point point = e.GetPosition(canvas);

                label.SetValue(Canvas.TopProperty,ePoint.Y+(point.Y-mPoint.Y));
                label.SetValue(Canvas.LeftProperty,ePoint.X+(point.X-mPoint.X));
            }
        }
        /// <summary>
        /// 鼠标抬起
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           
            if(isDrawing)
            {
                Label label = sender as Label;                            
                label.ReleaseMouseCapture();
                isDrawing = false;
            }
        }
    }
}
