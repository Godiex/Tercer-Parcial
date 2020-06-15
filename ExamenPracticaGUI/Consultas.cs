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
        public void Consultar()
        {
            string tipo = CmbTipoConsulta.Text;
            if (tipo.Equals("Consulta Por Nick"))
            {
                ConsultaPorNickUbicacionYfecha();
                GbConsulta1.Enabled = true;
                GbConsulta2.Enabled = false;
            }
            else
            {
                if (tipo.Equals("Consulta Por Fecha Y totalizacoin de estampillas"))
                {
                    ConsultaPorfecha();
                    GbConsulta1.Enabled = false;
                    GbConsulta2.Enabled = true;
                }
            }
        }
        public void ConsultaPorfecha()
        {
            DgvRecaudos.Rows.Clear();
            int año = int.Parse(TBAño2.Text);
            int mes = int.Parse(TbMes2.Text);
            RespuestaConsulta<BaseLiquidacion> respuesta = servicioBaseLiquidacionBd.ConsultarFecha(año, mes);
            VentanaEmergente.MostrarInformacion(respuesta.mensaje);
            if (respuesta != null)
            {
                LLenarTabla(respuesta.ElementoConsultado);
               
            }
            TotalizarPorEstampilla(respuesta.ElementoConsultado);

        }
        public void TotalizarPorEstampilla(IList<BaseLiquidacion> basesLiquidacion)
        {
            TbAdulto.Text = servicioBaseLiquidacionBd.TotalizarPorEstapilla(basesLiquidacion, "Adulto Mayor").ToString();
            TbProCultura.Text = servicioBaseLiquidacionBd.TotalizarPorEstapilla(basesLiquidacion, "Pro Cultura").ToString();
            TbProUpc.Text = servicioBaseLiquidacionBd.TotalizarPorEstapilla(basesLiquidacion, "Pro-UPC").ToString();
            TbProFronterizo.Text = servicioBaseLiquidacionBd.TotalizarPorEstapilla(basesLiquidacion, "ProFronterizo").ToString();
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
            Consultar();
        }

        private void CmbTipoConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = CmbTipoConsulta.Text;
            if (tipo.Equals("Consulta Por Nick"))
            {
                GbConsulta1.Enabled = true;
                GbConsulta2.Enabled = false;
            }
            else
            {
                if (tipo.Equals("Consulta Por Fecha Y totalizacoin de estampillas"))
                {
                    GbConsulta1.Enabled = false;
                    GbConsulta2.Enabled = true;
                }
            }
        }
    }
}
