using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SessionTrack
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void Handle_RegisterButtonClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}
