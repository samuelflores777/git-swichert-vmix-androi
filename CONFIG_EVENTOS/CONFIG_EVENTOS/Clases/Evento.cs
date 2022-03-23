using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using SQLite;

namespace CONFIG_EVENTOS.Clases
{
        [Table("Evento")]
        public class Evento
        { 
        [PrimaryKey ]
            public string ID { get; set; }
            public string cmdidweb { get; set; }
            public string tipro { get; set; }
            public string nombtn01 { get; set; }
            public string apibtn01 { get; set; }
            public string nombtn02 { get; set; }
            public string apibtn02 { get; set; }
            public string nombtn03 { get; set; }
            public string apibtn03 { get; set; }
            public string nombtn04 { get; set; }
            public string apibtn04 { get; set; }
            public string nombtn05 { get; set; }
            public string apibtn05 { get; set; }
            public string nombtn06 { get; set; }
            public string apibtn06 { get; set; }
        }
    }

