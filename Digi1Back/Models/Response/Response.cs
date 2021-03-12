using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digi1Back.Models.Response
{
    public class Response
    {
        public int Success { get; set; }
        public string ErrorMessage { get; set; }
        public object Data { get; set; }
    }
}
