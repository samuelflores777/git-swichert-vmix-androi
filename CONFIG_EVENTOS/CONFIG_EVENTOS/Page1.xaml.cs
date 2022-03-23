using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using CONFIG_EVENTOS.Clases;


namespace CONFIG_EVENTOS
{
    
    public partial class Page1 : ContentPage
    {
        
        public string ID = "";

        public Page1()
        {
            InitializeComponent();

            btn02.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Page2());
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (ID != "")
            {
                Evento evento = App.BD.ObtenerEvento(ID);
                txtcmdidweb.Text = evento.cmdidweb;
                txttipro.Text = evento.tipro;
                txtnombtn01.Text = evento.nombtn01;
                txtapibtn01.Text = evento.apibtn01;
                txtnombtn02.Text = evento.nombtn02;
                txtapibtn02.Text = evento.apibtn02;
                txtnombtn03.Text = evento.nombtn03;
                txtapibtn03.Text = evento.apibtn03;
                txtnombtn04.Text = evento.nombtn04;
                txtapibtn04.Text = evento.apibtn04;
                txtnombtn05.Text = evento.nombtn05;
                txtapibtn05.Text = evento.apibtn05;
                txtnombtn06.Text = evento.nombtn06;
                txtapibtn06.Text = evento.apibtn06;
            }
        }

        private void btn01_Clicked(object sender, EventArgs e)
        {
            Global.IDWEB = txtcmdidweb.Text;
            Global.tipro = txttipro.Text;

            Global.ti1 = txtnombtn01.Text;
            Global.api1 = txtapibtn01.Text;

            Global.ti2 = txtnombtn02.Text;
            Global.api2 = txtapibtn02.Text;

            Global.ti3 = txtnombtn03.Text;
            Global.api3 = txtapibtn03.Text;

            Global.ti4 = txtnombtn04.Text;
            Global.api4 = txtapibtn04.Text;

            Global.ti5 = txtnombtn05.Text;
            Global.api5 = txtapibtn05.Text;

            Global.ti6 = txtnombtn06.Text;
            Global.api6 = txtapibtn06.Text;
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string cmdidweb = txtcmdidweb.Text;
            string tipro = txttipro.Text;
            string nombtn01 = txtnombtn01.Text;
            string apibtn01 = txtapibtn01.Text;
            string nombtn02 = txtnombtn02.Text;
            string apibtn02 = txtapibtn02.Text;
            string nombtn03 = txtnombtn03.Text;
            string apibtn03 = txtapibtn03.Text;
            string nombtn04 = txtnombtn04.Text;
            string apibtn04 = txtapibtn04.Text;
            string nombtn05 = txtnombtn05.Text;
            string apibtn05 = txtapibtn05.Text;
            string nombtn06 = txtnombtn06.Text;
            string apibtn06 = txtapibtn06.Text;
            App.BD.GuardarEvento(ID, cmdidweb, tipro,nombtn01,apibtn01,nombtn02,apibtn02,nombtn03,apibtn03,nombtn04,apibtn04, nombtn05,apibtn05, nombtn06,apibtn06);
            Navigation.PopAsync();
        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            if (ID != "")
            {
                App.BD.EliminarEvento(ID);
                Navigation.PopAsync();
            }
        }
    }
}