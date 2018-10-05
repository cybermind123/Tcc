using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes.Servico
{
    class ServicoDTO
    {
        public int id { get; set; }

        public int fkCliente { get; set; }

        public int fkEvento { get; set; }

        public int fkFuncionário { get; set; }

        public int fkFornecedor { get; set; }
    }
}
