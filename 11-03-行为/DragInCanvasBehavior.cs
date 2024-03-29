using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace _11_03_行为
{
    /// <summary>
    /// 把控件的行为抽象成一个类
    /// </summary>
    class DragInCanvasBehavior : Behavior<UIElement>
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


        //AssociatedObject是当前绑定的UIElement对象
        protected override void OnAttached()
        {
            base.OnAttached();

            this.AssociatedObject.MouseLeftButtonDown += AssociatedObject_MouseLeftButtonDown;
            this.AssociatedObject.MouseLeftButtonUp += AssociatedObject_MouseLeftButtonUp;
            this.AssociatedObject.MouseMove += AssociatedObject_MouseMove;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.MouseLeftButtonDown -= AssociatedObject_MouseLeftButtonDown;
            this.AssociatedObject.MouseLeftButtonUp -= AssociatedObject_MouseLeftButtonUp;
            this.AssociatedObject.MouseMove -= AssociatedObject_MouseMove;

        }
        private void AssociatedObject_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Label label = sender as Label;
            //1.获得当前对象，相当于Canvas的位置
            ePoint.X = Canvas.GetLeft(AssociatedObject);
            ePoint.Y = Canvas.GetTop(AssociatedObject);

            //2.获得鼠标按下位置的原始值,GetPosition获得鼠标传入元素的相对位置，此处需要传入Canvas
            // LogicalTreeHelper.GetParent(label)获得label的父对象，此处是获得Canvas
            if (canvas != null)
                canvas = (Canvas)LogicalTreeHelper.GetParent(AssociatedObject);
            mPoint = e.GetPosition(canvas);

            //捕获鼠标
            AssociatedObject.CaptureMouse();

            //鼠标按下时可拖动
            isDrawing = true;
        }

        private void AssociatedObject_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (isDrawing)
            {
                //Label label = sender as Label;
                //计算差值
                Point point = e.GetPosition(canvas);

                AssociatedObject.SetValue(Canvas.TopProperty, ePoint.Y + (point.Y - mPoint.Y));
                AssociatedObject.SetValue(Canvas.LeftProperty, ePoint.X + (point.X - mPoint.X));
            }
        }

        private void AssociatedObject_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            if (isDrawing)
            {
                //Label label = sender as Label;
                AssociatedObject.ReleaseMouseCapture();
                isDrawing = false;
            }
        }

    }
}
