﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity1 : ContentPage
    {
        public activity1()
        {
            InitializeComponent();
        }

        private async void homePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

    }
}