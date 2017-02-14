using Store.Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.WebUI.Controllers
{
    public class ProdutoController : Controller
    {
        
        private readonly IProduto _repositorio;

        public ProdutoController(IProduto respositorio)
        {
            _repositorio = respositorio;
        }

        // GET: Produto
        public ActionResult Index()
        {

            var model = _repositorio.Produtos;
            
            return View(model);
        }
    }
}