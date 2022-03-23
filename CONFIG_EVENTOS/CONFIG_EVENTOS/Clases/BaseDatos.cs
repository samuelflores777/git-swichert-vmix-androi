using System;
using System.Linq;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace CONFIG_EVENTOS.Clases
{
    public class BaseDatos : SQLiteConnection
    {
        public BaseDatos(string path) : base(path)
        {
            CrearTablas();
        }
        void CrearTablas()
        {
            CreateTable<Evento>();
        }

        public ObservableCollection<Evento> ObtenerEvento()
        {
            return new ObservableCollection<Evento>(this.Table<Evento>().ToList());
        }

        public Evento ObtenerEvento(String id)
        {
            return (id == "") ? new Evento() : Table<Evento>().Where(t => t.ID == id).First();
        }

        public void GuardarEvento(string id, string cmdidweb, string tipro, string nombtn01, string apibtn01, string nombtn02, string apibtn02,
            string nombtn03, string apibtn03, string nombtn04, string apibtn04, string nombtn05, string apibtn05, string nombtn06, string apibtn06)
        {
            Evento evento = ObtenerEvento(id);
            evento.cmdidweb = cmdidweb;
            evento.tipro = tipro;
            evento.nombtn01 = nombtn01;
            evento.apibtn01 = apibtn01;
            evento.nombtn02 = nombtn02;
            evento.apibtn02 = apibtn02;
            evento.nombtn03 = nombtn03;
            evento.apibtn03 = apibtn03;
            evento.nombtn04 = nombtn04;
            evento.apibtn04 = apibtn04;
            evento.nombtn05 = nombtn05;
            evento.apibtn05 = apibtn05;
            evento.nombtn06 = nombtn06;
            evento.apibtn06 = apibtn06;

            if (id == "")
                AgregarEvento(evento);
            else
                ActualizarEvento(evento);
        }

        private void AgregarEvento(Evento evento)
        {
            evento.ID = Guid.NewGuid().ToString();
            this.Insert(evento);
        
        }

        private void ActualizarEvento(Evento evento)
        {
            this.Update(evento);
        }

        public void EliminarEvento(String id)
        {
            Evento evento = Table<Evento>().Where(t => t.ID == id).First();
            this.Delete(evento);
        }
    }
}
