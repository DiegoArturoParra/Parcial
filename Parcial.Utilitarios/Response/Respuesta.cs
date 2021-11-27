using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Utilitarios.Response
{
    public class Respuesta
    {
        public string Mensaje { get; set; }
        public object Data { get; set; }
        public int StatusCode { get; set; }
    }
}
