using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Contratista
    {
        public string Identificacion { get; set; }
        public string NombreAgente { get; set; }
        public Contratista()
        {
                
        }
        public Contratista(string identificacion, string nombreAgente)
        {
            Identificacion = identificacion;
            NombreAgente = nombreAgente;
        }
    }
}
