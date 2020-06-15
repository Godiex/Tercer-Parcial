using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;
namespace Bll
{
    public class ServicioBaseLiquidacionBd
    {
        private readonly BaseLiquidacionDbRepositorio baseLiquidacionDbRepositorio;
        private ConnectionManager connectionManager;

        public ServicioBaseLiquidacionBd(string cadenaDeConexion)
        {
            connectionManager = new ConnectionManager(cadenaDeConexion);
            baseLiquidacionDbRepositorio = new BaseLiquidacionDbRepositorio(connectionManager);
        }

        public String Guardar(BaseLiquidacion baseLiquidacion)
        {
            try
            {
                connectionManager.Open();
                baseLiquidacionDbRepositorio.Guardar(baseLiquidacion);
                connectionManager.Close();
                return "";
            }
            catch (Exception e)
            {
                return $"error al guardar en la base de datos : {e.Message}";
            }
            finally
            {
                connectionManager.Close();
            }

        }
        public RespuestaConsulta<BaseLiquidacion> Consultar()
        {
            RespuestaConsulta<BaseLiquidacion> respuesta = new RespuestaConsulta<BaseLiquidacion>();
            try
            {
                connectionManager.Open();
                IList<BaseLiquidacion> baseLiquidaciones = baseLiquidacionDbRepositorio.Consultar();
                connectionManager.Close();
                if (baseLiquidaciones.Count > 0)
                {
                    respuesta.mensaje = "consulta realizada";
                    respuesta.ElementoConsultado = baseLiquidaciones;
                }
                else
                {
                    respuesta.ElementoConsultado = baseLiquidaciones;
                    respuesta.mensaje = "no hay datos en la lista ";
                }
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.mensaje = $"error :  {e.Message}";
                return respuesta;
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public RespuestaConsulta<BaseLiquidacion> ConsultarPorNickYFecha(string nick, int año, int mes)
        {
            RespuestaConsulta<BaseLiquidacion> respuesta = new RespuestaConsulta<BaseLiquidacion>();
            try
            {
                connectionManager.Open();
                IList<BaseLiquidacion> baseLiquidaciones = baseLiquidacionDbRepositorio.ConsultarPorNickYFecha(nick, año, mes);
                connectionManager.Close();
                if (baseLiquidaciones.Count > 0)
                {
                    respuesta.mensaje = "consulta realizada";
                    respuesta.ElementoConsultado = baseLiquidaciones;
                }
                else
                {
                    respuesta.ElementoConsultado = baseLiquidaciones;
                    respuesta.mensaje = "no hay datos en la lista ";
                }
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.mensaje = $"error :  {e.Message}";
                return respuesta;
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public RespuestaConsulta<BaseLiquidacion> ConsultarFecha(int año, int mes)
        {
            RespuestaConsulta<BaseLiquidacion> respuesta = new RespuestaConsulta<BaseLiquidacion>();
            try
            {
                connectionManager.Open();
                IList<BaseLiquidacion> baseLiquidaciones = baseLiquidacionDbRepositorio.ConsultarPorFecha(año, mes);
                connectionManager.Close();
                if (baseLiquidaciones.Count > 0)
                {
                    respuesta.mensaje = "consulta realizada";
                    respuesta.ElementoConsultado = baseLiquidaciones;
                }
                else
                {
                    respuesta.ElementoConsultado = baseLiquidaciones;
                    respuesta.mensaje = "no hay datos en la lista ";
                }
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.mensaje = $"error :  {e.Message}";
                return respuesta;
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public decimal TotalizarPorEstapilla(IList<BaseLiquidacion> baseLiquidaciones, string estampilla)
        {
            return baseLiquidacionDbRepositorio.TotalizarPorEstapilla(baseLiquidaciones, estampilla);
        }
    }
}
