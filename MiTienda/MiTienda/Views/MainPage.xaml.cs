using MiTienda.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MiTienda
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CargarApi();
        }

        private async Task CargarApi()
        {
            HttpClient publicaciones = new HttpClient();

            publicaciones.BaseAddress = new Uri("http://192.168.1.51");
            var request = await publicaciones.GetAsync("MiTiendaApi/api/Publicaciones");
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<List<publicacion>>(responseJson);
                listPublicacion.ItemsSource = response;
            }
        }

        private async void listPublicaciones(object sender, SelectedItemChangedEventArgs e)
        {

            var publica = e.SelectedItem as publicacion;
            string mensaje = string.Format("Usuario : {0} - FechaPublicacion : {1}, Descripcion : {2}", publica.Usuario,publica.FechaPublicacion,publica.Descripcion);
            await DisplayAlert("Publicacion", mensaje, "Ok");
        }
    }
}
