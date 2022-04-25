using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity2 : ContentPage
    {
        public activity2()
        {
            InitializeComponent();
        }

        void changedSliderValue(object sender, ValueChangedEventArgs args)
        {
            labelValue.Text = args.NewValue.ToString("F3");
        }

        async void clickedButton(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            await DisplayAlert("Submitted",
                "Activity 2 has been submitted", "OK");
        }

    }
}