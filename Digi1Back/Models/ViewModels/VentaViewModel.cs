using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digi1Back.Models.ViewModels
{
    public class VentaViewModel
    {
        public int fac_pro_id { get; set; }
        public string pro_nombre { get; set; }
        public int cantidad { get; set; }
        public int total { get; set; }
    }
}
