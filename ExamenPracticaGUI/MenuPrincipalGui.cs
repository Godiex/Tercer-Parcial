using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenPracticaGUI
{
    public partial class MenuPrincipalGui : Form
    {
        public MenuPrincipalGui()
        {
            InitializeComponent();
        }
        private Form FormActual = null;
        private void AbrirFormHijoEnPanel(Form formHijo)
        {
            if (FormActual != null)
                FormActual.Close();
            FormActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(formHijo);
            PanelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void BtnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            AbrirFormHijoEnPanel(new CargueRecaudoGui());
        }

        private void BtnRegistrarLiquidacionCoutaModeradora_Click(object sender, EventArgs e)
        {
            AbrirFormHijoEnPanel(new Consultas());
        }
    }
}
