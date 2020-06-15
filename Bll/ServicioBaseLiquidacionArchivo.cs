using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;

namespace Bll
{
    public class ServicioBaseLiquidacionArchivo
    {
        BaseLiquidacionArcRepositorio arcRepositorio;

        public ServicioBaseLiquidacionArchivo()
        {
            arcRepositorio = new BaseLiquidacionArcRepositorio();
        }
        public RespuestaConsulta<BaseLiquidacion> Consultar(string ruta)
        {

            RespuestaConsulta<BaseLiquidacion> respuestaConsulta = new RespuestaConsulta<BaseLiquidacion>();
            try
            {
                respuestaConsulta.ElementoConsultado = arcRepositorio.Consultar(ruta);
                respuestaConsulta.mensaje = "archivo encontrado con exito";
                return respuestaConsulta;
            }
            catch (Exception)
            {
                respuestaConsulta.mensaje = "No hay datos error ";
                return respuestaConsulta;
            }
        }


    }
}
