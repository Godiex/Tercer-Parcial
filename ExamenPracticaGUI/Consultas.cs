using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using Entity;
namespace ExamenPracticaGUI
{
    public partial class Consultas : Form
    {
        ServicioBaseLiquidacionBd servicioBaseLiquidacionBd;
        public Consultas()
        {
            servicioBaseLiquidacionBd = new ServicioBaseLiquidacionBd(ExtraccionCadenaDeConexion.CadenaConexion);
            InitializeComponent();
        }
        public void ConsultaPorNickUbicacionYfecha()
        {
            DgvRecaudos.Rows.Clear();
            int año = int.Parse(TbAño.Text);
            int mes = int.Parse(TbMes.Text);
            string nick = TbNick.Text;
            RespuestaConsulta<BaseLiquidacion> respuesta = servicioBaseLiquidacionBd.ConsultarPorNickYFecha(nick,año,mes);
            VentanaEmergente.MostrarInformacion(respuesta.mensaje);
            if (respuesta != null)
            {
                LLenarTabla(respuesta.ElementoConsultado);
            }
        }
        public void LLenarTabla(IList<BaseLiquidacion> baseLiquidaciones)
        {
            foreach (var item in baseLiquidaciones)
            {
                DgvRecaudos.Rows.Add(item.Servicio.NickUbicacion, item.Servicio.FechaServicio.Month, item.Servicio.FechaServicio.Year,
                    item.Servicio.NombreServicio, item.Servicio.ValorRecaudo, item.Contratista.Identificacion, item.Contratista.NombreAgente);
            }
        }

        private void BtnConsultaGeneral_Click(object sender, EventArgs e)
        {
            ConsultaPorNickUbicacionYfecha();
        }
    }
}
