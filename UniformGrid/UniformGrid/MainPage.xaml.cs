using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformGridSample.Models;
using Xamarin.Forms;

namespace UniformGridSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public UniformModel UniformModel { get; set; }
        public MainPage()
        {
            this.UniformModel = new UniformModel();
            InitializeComponent();
            this.BindingContext = this.UniformModel;
        }

        private void AddItem(object sender, EventArgs e)
        {
            this.UniformModel.AddNew();
        }

        private void RemoveItem(object sender, EventArgs e)
        {
            this.UniformModel.RemoveLast();
        }
    }
}
