
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_03_验证.Models
{

    //INotifyDataErrorInfo：专门用来通知在校验时出现错误的接口
    class User : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        //存储错误
        private Dictionary<string, List<string>> errors = new Dictionary<string, List<string>>();

        private string userName = null!;

        public string UserName
        {
            get { return userName; }
            //方法1：在数据对象中引发错误
            set
            {
                //是否出现过错误信息
                bool flag = false;
                userName = value;
                if (string.IsNullOrEmpty(UserName))
                {
                    //方法一，抛出错误信息；
                    /*throw new Exception("Error ： Name is Null！！");*///这种方式是不友好的

                    //方法二：实现接口
                    string info = "Error ： Name is Null！！";
                    SetErrors(nameof(UserName), new List<string>() { info });
                    flag = true;
                }

                if (UserName.Length < 3)
                {

                    string info = "Error ： Name Length <3 ！";
                    SetErrors(nameof(UserName), new List<string>() { info });
                    flag = true;
                }

                if(!flag)
                {
                    //如果没有错误，则清除
                    ClearErrors(nameof(UserName));
                }
             

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UserName)));
            }
        }


        private string password;



        public string Password
        {
            get { return password; }
            set 
            { 
                password = value; 

            }
        }

        /// <summary>
        /// 判断当前是否还有错误信息
        /// </summary>
        public bool HasErrors => errors.Count > 0;

        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public IEnumerable GetErrors(string? propertyName)
        {
            if (!String.IsNullOrEmpty(propertyName))
            {
                if (errors.Keys.Contains(propertyName))
                    return errors[propertyName];
                else return null;
            }

            return null;
        }

        private void ClearErrors(string propertyName)
        {
            if (errors.ContainsKey(propertyName))
            {
                errors.Remove(propertyName);
            }
        }

        private void SetErrors(string propertyName, List<string> err)
        {
            if (errors.ContainsKey(propertyName))
            {
                errors.Remove(propertyName);
            }

            errors.Add(propertyName, err);

            //通知错误
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(nameof(propertyName)));

        }
    }
}
