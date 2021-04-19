using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab4B
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void OnButtonClickedLab4BDataBinding(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lab4BDataBinding());
        }
        async private void OnButtonClickedLab4BEntryEditor(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lab4BEntryEditor());
        }
        async private void OnButtonClickedLab4BLabel(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lab4BLabel());
        }

    }
}
