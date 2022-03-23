using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CONFIG_EVENTOS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        private WebClient cliente;
        private string direccion;
        public Page2()
        {
            InitializeComponent();
            cliente = new WebClient();

            btn01.Text = Global.ti1;
            btn02.Text = Global.ti2;
            btn03.Text = Global.ti3;
            btn04.Text = Global.ti4;
            btn05.Text = Global.ti5;
            btn06.Text = Global.ti6;
            tipro1.Text = Global.tipro;
        }

        private void btn01_Clicked(object sender, EventArgs e)
        {
            if (btn01.BackgroundColor.Equals(Color.Default))
            {
                direccion = (Global.IDWEB + Global.api1);
                cliente.DownloadString(direccion);
//                btn01.BackgroundColor = Color.Red;
 //               btn01.TextColor = Color.White;
            }
            else
            {
                direccion = (Global.IDWEB + Global.api1);
                cliente.DownloadString(direccion);
  //              btn01.BackgroundColor = Color.Default;
   //             btn01.TextColor = Color.Black;
            }
        }

        private void btn02_Clicked(object sender, EventArgs e)
        {
            if (btn02.BackgroundColor.Equals(Color.Default))
            {
                direccion = (Global.IDWEB + Global.api2);
                cliente.DownloadString(direccion);
    //            btn02.BackgroundColor = Color.Red;
     //           btn02.TextColor = Color.White;
            }
            else
            {
                direccion = (Global.IDWEB + Global.api2);
                cliente.DownloadString(direccion);
       //         btn02.BackgroundColor = Color.Default;
        //        btn02.TextColor = Color.Black;
            }
        }

        private void btn03_Clicked(object sender, EventArgs e)
        {
            if (btn03.BackgroundColor.Equals(Color.Default))
            {
                direccion = (Global.IDWEB + Global.api3);
                cliente.DownloadString(direccion);
       //         btn03.BackgroundColor = Color.Red;
        //        btn03.TextColor = Color.White;
            }
            else
            {
                direccion = (Global.IDWEB + Global.api3);
                cliente.DownloadString(direccion);
       //         btn03.BackgroundColor = Color.Default;
        //        btn03.TextColor = Color.Black;
            }
        }

        private void btn04_Clicked(object sender, EventArgs e)
        {
            if (btn04.BackgroundColor.Equals(Color.Default))
            {
                direccion = (Global.IDWEB + Global.api4);
                cliente.DownloadString(direccion);
      //          btn04.BackgroundColor = Color.Red;
       //         btn04.TextColor = Color.White;
            }
            else
            {
                direccion = (Global.IDWEB + Global.api4);
                cliente.DownloadString(direccion);
      //          btn04.BackgroundColor = Color.Default;
       //         btn04.TextColor = Color.Black;
            }
        }

        private void btn05_Clicked(object sender, EventArgs e)
        {
            if (btn05.BackgroundColor.Equals(Color.Default))
            {
                direccion = (Global.IDWEB + Global.api5);
                cliente.DownloadString(direccion);
      //          btn05.BackgroundColor = Color.Red;
      //          btn05.TextColor = Color.White;
            }
            else
            {
                direccion = (Global.IDWEB + Global.api5);
                cliente.DownloadString(direccion);
      //          btn05.BackgroundColor = Color.Default;
      //          btn05.TextColor = Color.Black;
            }
        }

        private void btn06_Clicked(object sender, EventArgs e)
        {
            if (btn06.BackgroundColor.Equals(Color.Default))
            {
                direccion = (Global.IDWEB + Global.api6);
                cliente.DownloadString(direccion);
      //          btn06.BackgroundColor = Color.Red;
      //          btn06.TextColor = Color.White;
            }
            else
            {
                direccion = (Global.IDWEB + Global.api6);
                cliente.DownloadString(direccion);
     //           btn06.BackgroundColor = Color.Default;
      //          btn06.TextColor = Color.Black;
            }
        }
    }
}