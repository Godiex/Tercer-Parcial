using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public class BaseLiquidacionDbRepositorio
    {
        private readonly SqlConnection _connection;
        public BaseLiquidacionDbRepositorio(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public void Guardar(BaseLiquidacion baseLiquidacion)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"INSERT INTO base_liquidacion VALUES(@nick_ubicacion,@año,@mes,@estampilla,@valor,@identificacion,@nombre_contratista)";
                command.Parameters.AddWithValue("@nick_ubicacion", baseLiquidacion.Servicio.NickUbicacion);
                command.Parameters.AddWithValue("@mes", baseLiquidacion.Servicio.FechaServicio.Year);
                command.Parameters.AddWithValue("@año", baseLiquidacion.Servicio.FechaServicio.Month);
                command.Parameters.AddWithValue("@estampilla", baseLiquidacion.Servicio.NombreServicio);
                command.Parameters.AddWithValue("@valor", baseLiquidacion.Servicio.ValorRecaudo);
                command.Parameters.AddWithValue("@identificacion", baseLiquidacion.Contratista.Identificacion);
                command.Parameters.AddWithValue("@nombre_contratista", baseLiquidacion.Contratista.NombreAgente);
                var filas = command.ExecuteNonQuery();
            }

        }
            public IList<BaseLiquidacion> Consultar()
            {
                SqlDataReader dataReader;
                List<BaseLiquidacion> reporteBaseLiquidacion = new List<BaseLiquidacion>();
                using (SqlCommand command = _connection.CreateCommand())
                {
                    command.CommandText = "Select * from base_liquidacion";
                    dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            BaseLiquidacion baseLiquidacion = MapearBaseLiquidacion(dataReader);
                            reporteBaseLiquidacion.Add(baseLiquidacion); 
                        }
                    }
                }
                return reporteBaseLiquidacion;
            }
        public IList<BaseLiquidacion> ConsultarPorNickYFecha(string nick, int año,int mes)
        {
            SqlDataReader dataReader;
            List<BaseLiquidacion> reporteBaseLiquidacion = new List<BaseLiquidacion>();
            using (SqlCommand command = _connection.CreateCommand())
            {
                command.CommandText = @"select * from BASE_LIQUIDACION
                                    WHERE nick_recaudo = @nick_ubicacion AND mes = @mes AND año = @año;";
                command.Parameters.AddWithValue("@nick_ubicacion", nick);
                command.Parameters.AddWithValue("@mes", mes);
                command.Parameters.AddWithValue("@año", año);
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        BaseLiquidacion baseLiquidacion = MapearBaseLiquidacion(dataReader);
                        reporteBaseLiquidacion.Add(baseLiquidacion);
                    }
                }
            }
            return reporteBaseLiquidacion;
        }
        public BaseLiquidacion MapearBaseLiquidacion(SqlDataReader dataReader)
            {
                if (!dataReader.HasRows) return null;
                string nickUbicacion = (string)dataReader["nick_recaudo"];
                int mes = (int)dataReader["mes"];
                int año = (int)dataReader["año"];
                DateTime fecha = ObtenerFecha(mes,año);
                string nombreServicio = (string)dataReader["nombre_servicio"];
                decimal valorRecaudo = (decimal)dataReader["valor_servicio"];
                string identificacion = (string)dataReader["id_contratista"];
                string nombre = (string)dataReader["nombre_contratista"];
                Contratista contratista = new Contratista(identificacion, nombre);
                ServicioRecaudo servicioRecaudo = new ServicioRecaudo(nombreServicio,valorRecaudo, fecha, nickUbicacion);
                BaseLiquidacion baseLiquidacion = new BaseLiquidacion(servicioRecaudo,contratista);
                return baseLiquidacion;
            }

            public DateTime ObtenerFecha(int mes, int año)
            {
                string cadenaFecha = $"1/{mes}/{año}";
                DateTime fecha = DateTime.Parse(cadenaFecha);
                return fecha;
            }

    }
        
}

