using System;
using System.Collections.Generic;
using SessionTrack.Models;
using Xamarin.Forms;

namespace SessionTrack
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        void Handle_RegisterButtonClicked(object sender, System.EventArgs e)
        {
            var user = new User {UserId = 1, UserEmail = email.Text, UserPassword = password.Text, UserFirstName = firstName.Text, UserLastName = lastName.Text };
            DisplayAlert("Account Created", "Welcome aboard " + user.UserFirstName + " " + user.UserLastName + ".", "Get Started");

            Application.Current.Properties["FirstName"] = user.UserFirstName;
            Application.Current.Properties["LastName"] = user.UserLastName;
            Application.Current.Properties["Email"] = user.UserEmail;
        }
    }
}
