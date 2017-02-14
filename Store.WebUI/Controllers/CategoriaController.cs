using Store.Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.WebUI.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoria _repositorio;

        public CategoriaController(ICategoria repositorio)
        {

            _repositorio = repositorio;
        }

        // GET: Categoria
        public ActionResult Index()
        {           
            return View(_repositorio.Categoria);
        }
        
        public ActionResult List()
        {

            ViewBag.Categorias = new SelectList(_repositorio.Categoria, "CategoryID", "CategoryName");

            
            return View();
        }

     [HttpPost]
     public ActionResult Selecao(int[] categoryId)
     {

        return View();
     }

   }
}