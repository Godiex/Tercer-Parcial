using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class BaseLiquidacion
    {
        public ServicioRecaudo Servicio { get; set; }
        public Contratista Contratista { get; set; }

        public BaseLiquidacion(ServicioRecaudo servicio, Contratista contratista)
        {
            Servicio = servicio;
            Contratista = contratista;
        }

        public BaseLiquidacion()
        {
            Contratista = new Contratista();
            Servicio = new ServicioRecaudo();
        }
    }
}
