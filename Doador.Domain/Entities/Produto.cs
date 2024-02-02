using Doador.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.Entities
{
    internal class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public ECategoria Categoria { get; set; }
        public bool Disponibilidade { get; set; }
        public int DoadorId { get; set; }
    }
}