using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.Entities
{
    public class Doador
    {
        public int DoadorId { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}