using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Santiago_Quishpe_Examen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnReg_Clicked(object sender, EventArgs e)
        {

            string user = txtUser.Text;
            string pass = txtPas.Text;


            string user_val = "estudiante2020";
            string pass_val = "uisrael2020";

            if (user == user_val && pass == pass_val)
            {
                await Navigation.PushAsync(new Registro(user, pass));
            }

            else
            {
                string mensaje = "Ingrese Usuario y Contraseña Correctos";
                DisplayAlert("Advertencia", mensaje, "Aceptar");
            }

        }
    }
}
