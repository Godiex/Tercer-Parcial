using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ServicioRecaudo
    {
        public string NombreServicio { get; set; }
        public decimal ValorRecaudo { get; set; }
        public DateTime FechaServicio { get; set; }
        public string NickUbicacion { get; set; }
        public ServicioRecaudo()
        {

        }
        public ServicioRecaudo(string nombreServicio, decimal valorRecaudo, DateTime fechaServicio, string nickUbicacion)
        {
            NombreServicio = nombreServicio;
            ValorRecaudo = valorRecaudo;
            FechaServicio = fechaServicio;
            NickUbicacion = nickUbicacion;
        }
    }
}
