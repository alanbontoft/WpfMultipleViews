using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMultipleViews.ViewModels
{
    public class BaseViewModel : ObservableObject
    {
        private int _value;
        public int Value
        {
            get
            { 
                return _value;
            }

            set
            {
                if (value != _value)
                {
                    _value = value;
                    OnPropertyChanged();
                }
            }
        }

        public BaseViewModel(int i)
        {
            Value = i;
        }

        public BaseViewModel()
        {
            Value = 0;
        }

        public void IncValue(int i)
        {
            Value += i;
        }

        public void DecValue(int i)
        {
            Value -= i;
        }
    }
}
