using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CONFIG_EVENTOS.Clases;


namespace CONFIG_EVENTOS
{
    public partial class App : Application
    {
        public static BaseDatos BD;

        public App()
        {
            string db = "evento.db3";
                string ruta = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), db);
            BD = new BaseDatos(ruta);


            InitializeComponent();

            MainPage =new NavigationPage( new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
