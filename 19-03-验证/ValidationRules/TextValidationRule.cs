using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace _19_03_验证.ValidationRules
{

    //方法二：在绑定级别上定义验证,自定义校验
    public class TextValidationRule : ValidationRule
    {
        //好处：可以从外部设置
        public int Max { get; set; }=Int32.MaxValue;
        public int Min { get; set; }=0;


        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            //string txt = value as string;

            //if (txt != null)
            //{
            //}

            //简写
            if (value is string txt)
            {

                if(string.IsNullOrEmpty(txt))
                {
                    return new  ValidationResult(false, "Password Is Null");
                }

                if(txt.Length< Min)
                {
                    return new ValidationResult(false, $"PassWord Length <{Min}");
                }
                if (txt.Length > Max)
                {
                    return new ValidationResult(false, $"PassWord Length >{Max}");
                }

            }
            else
            {
                //校验错误时返回,false代表校验错误
                return new  ValidationResult(false,"Value is not String");
            }

            //True代表校验成功
            return new ValidationResult(true, null);

        }
    }
}
