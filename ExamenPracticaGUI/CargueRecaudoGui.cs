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
    public partial class CargueRecaudoGui : Form
    {
        ServicioBaseLiquidacionArchivo servicio;
        ServicioBaseLiquidacionBd servicioBaseLiquidacionBd;
        public CargueRecaudoGui()
        {
            servicio = new ServicioBaseLiquidacionArchivo();
            servicioBaseLiquidacionBd = new ServicioBaseLiquidacionBd(ExtraccionCadenaDeConexion.CadenaConexion);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CargarBtn_Click(object sender, EventArgs e)
        {
            MontarABaseDeDatos();

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BtnConsultarArchivo_Click(object sender, EventArgs e)
        {
            DgvRecaudos.Rows.Clear();
            LLenarTabla(ConsultarArchivo());
        }
        public IList<BaseLiquidacion> ConsultarArchivo()
        {
            RespuestaConsulta<BaseLiquidacion> respuesta = new RespuestaConsulta<BaseLiquidacion>();
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            string ruta = fileDialog.FileName;
            respuesta = servicio.Consultar(ruta);
            return respuesta.ElementoConsultado;
        }
        public void MontarABaseDeDatos() 
        {
            IList<BaseLiquidacion> baseLiquidaciones = ConsultarArchivo();
            foreach (var item in baseLiquidaciones)
            {
                string mensaje  = servicioBaseLiquidacionBd.Guardar(item);
                if (mensaje.Length > 2)
                {
                    VentanaEmergente.MostrarError(mensaje);
                }
            }
            VentanaEmergente.MostrarInformacion("archivo plano mintado a la base de datos con exito");
        }
        public void LLenarTabla(IList<BaseLiquidacion> baseLiquidaciones)
        {
            foreach (var item in baseLiquidaciones)
            {
                DgvRecaudos.Rows.Add(item.Servicio.NickUbicacion,item.Servicio.FechaServicio.Month, item.Servicio.FechaServicio.Year,
                    item.Servicio.NombreServicio,item.Servicio.ValorRecaudo,item.Contratista.Identificacion,item.Contratista.NombreAgente);
            }
        }

    }
}
