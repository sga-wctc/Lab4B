using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab4B
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lab4BEntryEditor : ContentPage
    {
        public Lab4BEntryEditor()
        {
            InitializeComponent();
        }
        void EditorTextChanged(object sender, TextChangedEventArgs e)
        {
            displayText.Text = e.NewTextValue;
        }
    }
}