using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes.Evento
{
    class EventoDTO
    {
        public int id { get; set; }

        public string Nome { get; set; }

        public string Local { get; set; }

        public DateTime Data { get; set; }

        public DateTime Horario { get; set; }

        public Decimal Valor { get; set; }

        public string Descricao { get; set; }
    }
}
