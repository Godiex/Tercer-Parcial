using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace Dal
{
    public class BaseLiquidacionArcRepositorio
    {

     
        private IList<BaseLiquidacion> basesLiquidacion = new List<BaseLiquidacion>();
        public BaseLiquidacionArcRepositorio()
        { 
        } 

        public IList<BaseLiquidacion> Consultar(String rutaConsulta)
        {
            basesLiquidacion.Clear();
            string linea = string.Empty;
            FileStream fileStream = new FileStream(rutaConsulta, FileMode.Open);
            StreamReader lector = new StreamReader(fileStream);

            while ((linea = lector.ReadLine()) != null)
            {
                BaseLiquidacion baseLiquidacion = MapearServicioRecaudo(linea);
                basesLiquidacion.Add(baseLiquidacion);
            }
            lector.Close();
            fileStream.Close();
            return basesLiquidacion;
        }
        public BaseLiquidacion MapearServicioRecaudo(string linea)
        {
            String[] datos = linea.Split(';');
            BaseLiquidacion baseLiquidacion = new BaseLiquidacion();
            baseLiquidacion.Servicio.NickUbicacion = datos[0];
            baseLiquidacion.Servicio.FechaServicio = ObtenerFecha(linea);
            baseLiquidacion.Servicio.NombreServicio = datos[3];
            baseLiquidacion.Servicio.ValorRecaudo = Convert.ToDecimal(datos[4]);
            baseLiquidacion.Contratista.Identificacion = datos[5];
            baseLiquidacion.Contratista.NombreAgente = datos[6];
            return baseLiquidacion;
        }
        public DateTime ObtenerFecha(string linea)
        {
            String[] datos = linea.Split(';');
            string mes = datos[1];
            string año = datos[2];
            string cadenaFecha = $"1/{mes}/{año}";
            DateTime fecha = DateTime.Parse(cadenaFecha);
            return fecha;
        }
        
        
    }
}
