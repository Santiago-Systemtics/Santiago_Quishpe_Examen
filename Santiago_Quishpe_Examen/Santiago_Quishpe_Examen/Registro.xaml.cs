using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Santiago_Quishpe_Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(String user, string pass)
        {
            InitializeComponent();
            lblUser.Text = user;
            
        }

        private void btnGenerar_Clicked(object sender, EventArgs e)
        {
            
            double abono = Convert.ToDouble(txtPago.Text);
                 


            if (abono <= 1800)
            {
               
            }

            else
            {
                string mensaje = "datos errneos";
                DisplayAlert("Advertencia", mensaje, "Aceptar");
            }

            double calculo = (1800- abono);
            double cuota = (calculo / 3 * 1.05);
            lblcuota.Text = cuota.ToString();

           

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            
            
            string user = lblUser.Text;
            string nombre = txtNom.Text;
            string mensualidad = lblcuota.Text;


            string mensaje = "Guardado con exito";
            DisplayAlert("GUARDADO", mensaje, "Aceptar");

            await Navigation.PushAsync(new Resumen(user, nombre, mensualidad));

        }
    }
}