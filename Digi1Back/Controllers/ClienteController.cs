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
    public class ClienteController : Controller
    {
        private Models.MyDBContext db;
        public ClienteController(Models.MyDBContext context)
        {
            db = context;
        }

        [HttpGet("[action]")]
        public IEnumerable<ClienteViewModel> Clien()
        {
            List<ClienteViewModel> lst = (from d in db.view_compras
                                            where d.edad < 35
                                             select new ClienteViewModel
                                             {
                                                 nombre = d.nombre,
                                                 edad = d.edad,
                                                 fecha_compra = d.fecha_compra
                                             }).ToList();

            return lst;
        }

    }
}
