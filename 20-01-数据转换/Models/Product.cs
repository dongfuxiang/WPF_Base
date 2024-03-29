using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_01_数据转换.Models
{
    class Product:INotifyPropertyChanged
    {
        private decimal unitCost { get; set; }
        public decimal UnitCost
        {
            get { return unitCost; }
            set 
            {
                unitCost = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UnitCost)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
