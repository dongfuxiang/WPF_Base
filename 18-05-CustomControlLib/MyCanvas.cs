using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace _18_05_CustomControlLib
{
    public class MyCanvas : Panel
    {
        //附加依赖项属性
        public static DependencyProperty TopProPerty = DependencyProperty.RegisterAttached("Top", typeof(double), typeof(MyCanvas));
        public static DependencyProperty LefProPerty = DependencyProperty.RegisterAttached("Left", typeof(double), typeof(MyCanvas));

        public static double GetTop(DependencyObject obj)
        {
            return (double)obj.GetValue(TopProPerty);
        }

        public static void SetTop(DependencyObject obj, double value)
        {
            obj.SetValue(TopProPerty, value);
        }

        public static double GetLeft(DependencyObject obj)
        {
            return (double)obj.GetValue(LefProPerty);
        }

        public static void SetLeft(DependencyObject obj, double value)
        {
            obj.SetValue(LefProPerty, value);
        }


        /// <summary>
        /// 绘制时用来测量实际空间大小
        /// </summary>
        /// <param name="availableSize"></param>
        /// <returns></returns>
        protected override Size MeasureOverride(Size availableSize)
        {
            foreach (UIElement item in InternalChildren)
            {

                Size size = new Size(double.PositiveInfinity, double.PositiveInfinity);
                //子元素自己测量,相当于子元素调用MeasureOverride
                item.Measure(size);

                //测量过后的实际空间大小
                Size s = item.DesiredSize;
            }


            //子元素占多大空间对Canvas来说不重要，
            //return base.MeasureOverride(availableSize);
            return new Size();
        }


        /// <summary>
        /// 布局子元素
        /// </summary>
        /// <param name="finalSize"></param>
        /// <returns></returns>
        protected override Size ArrangeOverride(Size finalSize)
        {
            foreach (UIElement item in InternalChildren)
            {
                //进行子元素布局
                //起始点
                double x = 0, y = 0;
                x = MyCanvas.GetLeft(item);
                y = MyCanvas.GetTop(item);

                item.Arrange(new Rect(new Point(x, y), item.DesiredSize));
            }


            return finalSize;
        }
    }
}
