using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P4E218010004.vistas
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListUbicacion : ContentPage
    {
        public PageListUbicacion()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            List<Models.Ubicacion> ubicacions = new List<Models.Ubicacion>();
            ubicacions = await App.Database.GetListubica();


            listemple.ItemsSource = ubicacions;
        }

        private void listemple_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
