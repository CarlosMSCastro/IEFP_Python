using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProductsSQLInjection
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public int CategoriaID { get; set; }
        public string? NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public int Stock { get; set; }
        public bool Ativo { get; set; }
    }
}
