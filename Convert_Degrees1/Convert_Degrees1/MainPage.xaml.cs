using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Convert_Degrees1
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //ConvertButton.Clicked += ConvertButton_Clicked;
            ConvertButtonC.Clicked += ConvertButtonC_Clicked;
        }

        private void ConvertButtonC_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CentigradosEntry.Text))
            {
                DisplayAlert("Error", "You have not entered a value", "Accept");
                return;

            }

            else
            {
                if (!string.IsNullOrEmpty(FahrenheitEntry.Text))
                {

                    double Fahrenheit = 0;
                    double.TryParse(FahrenheitEntry.Text, out Fahrenheit);

                    var Centigrade = ((Fahrenheit - 32) / 1.8);

                    CentigradosEntry.Text = Convert.ToString(Math.Round(Centigrade));
                    return;

                }

                
                double Centigrado = 0;
                double.TryParse(CentigradosEntry.Text, out Centigrado);

                var fahrenheit = ((Centigrado * 1.8) + 32);

                FahrenheitEntry.Text = Convert.ToString(Math.Round(fahrenheit));
                
                return;

                
            }

        }



        //private void ConvertButton_Clicked(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(CentigradosEntry.Text))
        //    {
        //        DisplayAlert("Error", "You have not entered a value", "Accept");


        //        return;
        //    }
        //    else
        //    {
        //        double Centigrado = 0;
        //        double.TryParse(CentigradosEntry.Text, out Centigrado);

        //        var Fahrenheit = ((Centigrado * 1.8) + 32);

        //        FahrenheitEntry.Text = Convert.ToString(Math.Round(Fahrenheit));

        //    }


        //}
    }
}
