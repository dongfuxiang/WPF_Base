using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_01_绑定到数据对象.Model
{

    //要实现消息更改通知，必须实现INotifyCollectionChanged接口，且字段使用属性访问器
    internal class User : INotifyPropertyChanged
    {
        private int userName;

        public int UserName
        {
            get { return userName; }
            set 
            { 
                userName = value;
                //发送者对象，发送的属性
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UserName)));
            }
        }

        private int userPwd;

        public int UserPwd
        {
            get { return userPwd; }
            set { userPwd = value; }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        public string Password { get; set; } = null!;

    
    }
}
