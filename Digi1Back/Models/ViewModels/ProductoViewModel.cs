using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digi1Back.Models.ViewModels
{
    public class ProductoViewModel
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public string medida { get; set; }
    }
}
