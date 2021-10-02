using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void AccelerometerPage_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccelerometerPage());
        }
        private async void BarometerPage_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BarometerPage());
        }
        private async void MagnetometerPage_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MagnetometerPage());
        }
        private async void ConnecitivtyPage_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConnectivityPage());
        }
        private async void BatteryPage_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BatteryPage());
        }
        private async void ClipboardPage_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClipboardPage());
        }
        private async void CompassPage_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CompassPage());
        }
    }
}
