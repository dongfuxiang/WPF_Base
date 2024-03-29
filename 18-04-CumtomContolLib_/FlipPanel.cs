using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace _18_04_CumtomContolLib_
{
    public class FlipPanel:Control
    {
        #region 属性和依赖项属性
        //定义依赖项属性
        public static readonly DependencyProperty FrontContetnProperty =
                        DependencyProperty.Register("FrontContent", typeof(object), typeof(FlipPanel));
        public static readonly DependencyProperty BcakContetnProperty =
                        DependencyProperty.Register("BackContent", typeof(object), typeof(FlipPanel));


        public object FrontContent
        {
            get => GetValue(FrontContetnProperty);
            set { SetValue(FrontContetnProperty, value); }
        }
        public object BackContent
        {
            get { return GetValue(BcakContetnProperty); }
            set { SetValue(BcakContetnProperty, value); }
        }
        #endregion

        static FlipPanel()
        {

            DefaultStyleKeyProperty.OverrideMetadata(typeof(FlipPanel), new PropertyMetadata(typeof(FlipPanel)));

        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }
    }
}
