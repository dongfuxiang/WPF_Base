using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_02_绑定到对象集合.Model
{
    class Product : INotifyPropertyChanged
    {
        private string number = null!;

        public string Number
        {
            get { return number; }
            set 
            { 
                number = value;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(number)));
            }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double cost;

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }


        private string description;

        

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
