using Store.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dominio.Contexto
{
    public class EFDbContexto : DbContext
    {
        public DbSet<Produto> Produtos { get;set;}
    }
}
