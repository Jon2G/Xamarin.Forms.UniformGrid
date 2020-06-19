using System;
using System.Collections.Generic;
using System.Text;

namespace UniformGridSample.Models
{
    public class UniformItem : ViewModelBase
    {
        private int _Numero;
        public int Numero
        {
            get => _Numero;
            private set
            {
                _Numero = value;
                OnPropertyChanged();
            }
        }

        public UniformItem(int Numero)
        {
            this.Numero = Numero;
        }
    }
}
