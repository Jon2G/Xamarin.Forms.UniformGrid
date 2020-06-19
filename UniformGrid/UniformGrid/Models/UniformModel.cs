using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace UniformGridSample.Models
{
    public class UniformModel:ViewModelBase
    {
        private ObservableCollection<UniformItem> _Items;
        public ObservableCollection<UniformItem> Items 
        { 
            get=>_Items;
           private set
            {
                _Items = value;
                OnPropertyChanged();
            }
        }

      public UniformModel()
        {
            this.Items = new ObservableCollection<UniformItem>();
        }
        internal void AddNew()
        {
            this.Items.Add(new UniformItem(this.Items.Count+1));
        }

        internal void RemoveLast()
        {
            if (this.Items.Any())
            {
                this.Items.RemoveAt(this.Items.Count - 1);
            }
        }
    }
}
