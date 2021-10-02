using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace App8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarometerPage : ContentPage
    {
        public BarometerPage()
        {
            InitializeComponent();
            try
            {
                Barometer.ReadingChanged += ReadingChanged;
                Barometer.Start(SensorSpeed.UI);
            }
            catch(FeatureNotSupportedException fnsEx)
            {
                lblMeasure.Text = fnsEx.Message;
            }
            catch (Exception ex)
            {
                lblMeasure.Text = ex.Message;
            }
        }
        void ReadingChanged(object sender, BarometerChangedEventArgs e)
        {
            var data = e.Reading;
            lblMeasure.Text = $"Preassure In Hectopascals: X: {data.PressureInHectopascals}";
        }
    }
}