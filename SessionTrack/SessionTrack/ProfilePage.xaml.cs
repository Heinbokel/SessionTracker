using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SessionTrack
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();

            nameLabel.Text = Application.Current.Properties["FirstName"] + " " + Application.Current.Properties["LastName"];
            emailLabel.Text = (string)Application.Current.Properties["Email"];
        }
    }
}
