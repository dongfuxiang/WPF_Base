using _09_02_WPF命令模型和应用.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _09_02_WPF命令模型和应用.ViewModel
{
    public class UserViewModel
    {
        public User User { get; set; }=new User();

        public LoginCommand Login { get; set; }=new LoginCommand();


            
    }


    public class LoginCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            User user = (User)parameter;
        }
    }

}
