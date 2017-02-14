using Store.Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Dominio.Repositorio
{
    public class CategoriaRepositorio : ICategoria
    {
        public IQueryable<Categoria> Categoria
        {
            get
            {
                return ObterLista();
            }
        }

        private IQueryable<Categoria> ObterLista()
        {

            var query = new List<Categoria>();

            for(int i = 1; i < 10; i++)
            {
                var cat = new Categoria
                {
                    CategoryID = i,
                    CategoryName = "Texto " + i.ToString()
                    
                };

                query.Add(cat);
            }

            return query.AsQueryable();
        }
    }
}
