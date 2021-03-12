using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digi1Back.Models.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Digi1Back.Controllers
{
    [Route("api/[controller]")]
    public class VentaController : Controller
    {
        private Models.MyDBContext db;
        public VentaController(Models.MyDBContext context)
        {
            db = context;
        }

        [HttpGet("[action]")]
        public IEnumerable<VentaViewModel> Vent()
        {
            List<VentaViewModel> lst = (from d in db.view_vendido
                                         orderby d.cantidad
                                        select new VentaViewModel
                                          {
                                              pro_nombre = d.pro_nombre,
                                              cantidad = d.cantidad,
                                              total = d.total,
                                          }).ToList();

            return lst;
        }
    }
}
