using PapeleriaBellasArtes.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PapeleriaBellasArtes.WebAdmin.Controllers
{
    public class ProductosController : Controller
    {
        ProductosBL _productosBl;

        public ProductosController()
        {
            _productosBl = new ProductosBL();
        }

        // GET: Productos
        public ActionResult Index()
        {
            var listadeProductos = _productosBl.ObtenerProductos();

            return View(listadeProductos);
        }

        [HttpGet]
        public ActionResult Crear()
        {
            var nuevoProducto = new Producto(); 

            return View(nuevoProducto); 
        }

        [HttpPost]
        public ActionResult Crear(Producto producto)
        {
            return RedirectToAction("Index");
        }
    }
}