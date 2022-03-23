using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CONFIG_EVENTOS.Clases;

namespace CONFIG_EVENTOS
{
   [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
      
        
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lsvEventos.ItemsSource = App.BD.ObtenerEvento();
        }

        private void lsvEventos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Evento evento = e.SelectedItem as Evento;
                Page1 pagina = new Page1();
                pagina.ID = evento.ID;
                Navigation.PushAsync(pagina);
            }
        }

        private void btnNuevo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}
