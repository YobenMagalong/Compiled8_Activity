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
    public partial class CompassPage : ContentPage
    {
        public CompassPage()
        {
            InitializeComponent();
        }
        public class CompassTest
        {
            // Set speed delay for monitoring changes.
            SensorSpeed speed = SensorSpeed.UI;

            public CompassTest()
            {
                // Register for reading changes, be sure to unsubscribe when finished
                Compass.ReadingChanged += Compass_ReadingChanged;
            }

            void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
            {
                var data = e.Reading;
                Console.WriteLine($"Reading: {data.HeadingMagneticNorth} degrees");
                // Process Heading Magnetic North
            }

            public void ToggleCompass()
            {
                try
                {
                    if (Compass.IsMonitoring)
                        Compass.Stop();
                    else
                        Compass.Start(speed);
                }
                catch (FeatureNotSupportedException fnsEx)
                {
                    // Feature not supported on device
                }
                catch (Exception ex)
                {
                    // Some other exception has occurred
                }
            }
        }
    }
}