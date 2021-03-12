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
        public IEnumerable<ClienteViewModel> Inven()
        {
            List<ClienteViewModel> lst = (from d in db.view_compras
                                             where d.cantidad < 5
                                             select new ClienteViewModel
                                             {
                                                 Id = d.id,
                                                 nombre = d.nombre,
                                                 cantidad = d.cantidad,
                                             }).ToList();

            return lst;
        }

    }
}
