using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digi1Back.Models.ViewModels
{
    public class ClienteViewModel
    {
        public string nombre { get; set; }
        public DateTime fecha_naci { get; set; }
        public int edad { get; set; }
        public int fac_id { get; set; }
        public DateTime fecha_compra { get; set; }
    }
}
