using Store.Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Dominio.Entidade;
using Store.Dominio.Contexto;

namespace Store.Dominio.Repositorio
{
    public class ProdutoRepositorio : IProduto
    {
        public EFDbContexto ctx = new EFDbContexto();

        public IQueryable<Produto> Produtos
        {
            get
            {
                return ctx.Produtos;
            }
            
        }
    }
}
