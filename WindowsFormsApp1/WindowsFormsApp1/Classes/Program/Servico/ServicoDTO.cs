using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes.Servico
{
    class ServicoDTO
    {
        public int idServico { get; set; }

        public int idClienteFK { get; set; }

        public int idEventoFK { get; set; }

        public int idFuncionarioFK { get; set; }

        public int idFornecedorFK { get; set; }
    }
}
