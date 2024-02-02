using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.Commands
{
    public class DoadorCommand
    {
        public int DoadorId { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
