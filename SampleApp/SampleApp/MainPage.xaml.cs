using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Task.Run(AnimateBackground);
        }

        private async void About_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }

        private async void Doctor_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new DocPage());
        }

        private async void Patient_Clicked(object sender, EventArgs e)
        {
          await Navigation.PushAsync(new PatientPage());
        }
        private async void AnimateBackground() // for animated 
        {
            Action<double> forward = input => bdGradient.AnchorY = input;
            Action<double> backward = input => bdGradient.AnchorY = input;

            while (true)
            {
                bdGradient.Animate(name: "forward", callback: forward, start: 0, end: 1, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
                bdGradient.Animate(name: "backward", callback: backward, start: 1, end: 0, length: 5000, easing: Easing.SinIn);
                await Task.Delay(5000);
            }
        }
    }
}
