using Digi1Back.Models.Response;
using Digi1Back.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digi1Back.Controllers
{
    [Route("api/[controller]")]
    public class ProductoController : Controller
    {
        private Models.MyDBContext db;

        public ProductoController(Models.MyDBContext context)
        {
            db = context;
        }

        /*
        [HttpGet("[action]")]
        public IActionResult Produc()
        {
            List<Models.Producto> lst = null;

            lst = db.Producto.ToList();

            return Json(lst);
        }*/

        [HttpGet("[action]")]
        public IEnumerable<ProductoViewModel> Produc()
        {
            List<ProductoViewModel> lst = (from d in db.Producto
                                           select new ProductoViewModel
                                           {
                                               Id = d.pro_Id,
                                               nombre = d.pro_nombre,
                                               precio = d.pro_precio,
                                               medida = d.pro_medida
                                           }).ToList();

            return lst;
        }

        [HttpPost("[action]")]
        public Response Add([FromBody]ProductoViewModel model)
        {
            Response oR = new Response();

            try
            {
                Models.Producto oProducto = new Models.Producto();
                oProducto.pro_nombre = model.nombre;
                oProducto.pro_precio = model.precio;
                oProducto.pro_medida = model.medida;
                db.Producto.Add(oProducto);
                db.SaveChanges();
                oR.Success = 1;
                
            }
            catch(Exception ex)
            {
                oR.Success = 0;
                oR.ErrorMessage = ex.Message;
            }
            return oR;
        }
    }
}
