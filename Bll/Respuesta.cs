using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class Respuesta
    {
        public string  mensaje { get; set; }
    }
    public class RespuestaBusqueda <G> : Respuesta
    {
        public G ElementoBuscado { get; set; }
    }
    public class RespuestaConsulta <G> : Respuesta
    {
        public IList<G> ElementoConsultado { get; set; }
    }
}
