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
    public partial class ClipboardPage : ContentPage
    {
        public ClipboardPage()
        {
            InitializeComponent();

            var hasText = Clipboard.HasText;
        }
        public class ClipboardTest
        {
            public ClipboardTest()
            {
                // Register for clipboard changes, be sure to unsubscribe when needed
                Clipboard.ClipboardContentChanged += OnClipboardContentChanged;
            }

            void OnClipboardContentChanged(object sender, EventArgs e)
            {
                Console.WriteLine($"Last clipboard change at {DateTime.UtcNow:T}");
            }
        }

    }
}