using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace _18_04_CustomControlLib
{
    public class FlipPanel : Control
    {
        #region 属性和依赖项属性
        //定义依赖项属性
        public static readonly DependencyProperty FrontContentProperty = DependencyProperty.Register("FrontContent", typeof(object), typeof(FlipPanel), null);
        public static readonly DependencyProperty BackContentProperty = DependencyProperty.Register("BackContent", typeof(object), typeof(FlipPanel), null);
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(FlipPanel), null);
        public static readonly DependencyProperty IsFlippedProperty = DependencyProperty.Register("IsFlipped", typeof(bool), typeof(FlipPanel), null);


        public object FrontContent
        {
            get => GetValue(FrontContentProperty);
            set { SetValue(FrontContentProperty, value); }
        }
        public object BackContent
        {
            get { return GetValue(BackContentProperty); }
            set { SetValue(BackContentProperty, value); }
        }

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public bool IsFlipped
        {
            get { return (bool)GetValue(IsFlippedProperty); }
            set
            {
                SetValue(IsFlippedProperty, value);
                this.ChangeVisualState(true);
            }
        }



        #endregion

        static FlipPanel()
        {

            DefaultStyleKeyProperty.OverrideMetadata(typeof(FlipPanel), new FrameworkPropertyMetadata(typeof(FlipPanel)));

        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            //ToggleButton toggleButton = GetTemplateChild("TbFlipButton") as ToggleButton;
            //if (toggleButton != null)
            //{
            //    //添加ToggleButton的点击事件
            //    toggleButton.Click += ToggleButton_Click;
            //}

            //如果toggleButton不是空值则
            if (GetTemplateChild("TbFlipButton") is ToggleButton toggleButton)
            {
                //添加ToggleButton的点击事件
                toggleButton.Click += ToggleButton_Click;
            }


            //最开始的初始状态
            this.ChangeVisualState(false);
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            IsFlipped = !IsFlipped;
        }

        /// <summary>
        /// 负责切换可视化状态
        /// </summary>
        /// <param name="v"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void ChangeVisualState(bool v)
        {
            if (IsFlipped)
            {
                VisualStateManager.GoToState(this, "Flipped", v);
            }
            else
            {
                VisualStateManager.GoToState(this, "Normal", v);
            }
        }

    }
}
