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
    public partial class Resumen : ContentPage
    {
        public Resumen(string user, string nombre, string mensualida)
        {
            InitializeComponent();

            lblUser.Text = user;
            lblNom.Text = nombre;
            lblcuota.Text = mensualida;
                 }
    }
}