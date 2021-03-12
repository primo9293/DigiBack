using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Digi1Back.Models.ViewModels;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;


namespace Digi1Back.Controllers
{
    [Route("api/[controller]")]
    public class InventarioController : Controller
    {
        private Models.MyDBContext db;

        public InventarioController(Models.MyDBContext context)
        {
            db = context;
        }

        [HttpGet("[action]")]
        public IEnumerable<InventarioViewModel> Inven()
        {
            List<InventarioViewModel> lst = (from d in db.view_inventarios
                                             where d.cantidad < 5
                                             select new InventarioViewModel
                                             {
                                               Id = d.id,
                                               nombre = d.nombre,
                                               cantidad = d.cantidad,
                                           }).ToList();

            return lst;
        }

    }
}
