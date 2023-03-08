using P4E218010004.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P4E218010004
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var Ubica = new Ubicacion
            {


                latitud = double.Parse(txtLatitud.Text),
                longitud = double.Parse(txtLongitud.Text),
                descripcion = txtDescripcion.Text,
                descripcionCorta = txtDescripcionCorta.Text,
            };

            if (await App.Database.Saveubica(Ubica) > 0)
            {
                await DisplayAlert("Ingresada", "Ubicacion Ingresada", "OK");
            }


            var secondpage = new UbicacionesSalvadas();
            secondpage.BindingContext = Ubica;
            Navigation.PushAsync(secondpage);
        }

        private void btnUbicacionSalvada_Clicked(object sender, EventArgs e)
        {

        }

        private void txtLatitud_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}