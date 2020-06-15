namespace ExamenPracticaGUI
{
    partial class MenuPrincipalGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalGui));
            this.PanelBarraSuperior = new System.Windows.Forms.Panel();
            this.PbMaximizar = new System.Windows.Forms.PictureBox();
            this.PbRestaurar = new System.Windows.Forms.PictureBox();
            this.PbMinimizar = new System.Windows.Forms.PictureBox();
            this.PbSalir = new System.Windows.Forms.PictureBox();
            this.PanelBarraLateral = new System.Windows.Forms.Panel();
            this.LbFecha = new System.Windows.Forms.Label();
            this.LbHora = new System.Windows.Forms.Label();
            this.BtnRegistrarLiquidacionCoutaModeradora = new System.Windows.Forms.Button();
            this.BtnRegistrarPaciente = new System.Windows.Forms.Button();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSalir)).BeginInit();
            this.PanelBarraLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBarraSuperior
            // 
            this.PanelBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(191)))));
            this.PanelBarraSuperior.Controls.Add(this.PbMaximizar);
            this.PanelBarraSuperior.Controls.Add(this.PbRestaurar);
            this.PanelBarraSuperior.Controls.Add(this.PbMinimizar);
            this.PanelBarraSuperior.Controls.Add(this.PbSalir);
            this.PanelBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraSuperior.Name = "PanelBarraSuperior";
            this.PanelBarraSuperior.Size = new System.Drawing.Size(1300, 36);
            this.PanelBarraSuperior.TabIndex = 2;
            // 
            // PbMaximizar
            // 
            this.PbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("PbMaximizar.Image")));
            this.PbMaximizar.Location = new System.Drawing.Point(1210, 1);
            this.PbMaximizar.Name = "PbMaximizar";
            this.PbMaximizar.Size = new System.Drawing.Size(35, 35);
            this.PbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMaximizar.TabIndex = 3;
            this.PbMaximizar.TabStop = false;
            // 
            // PbRestaurar
            // 
            this.PbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("PbRestaurar.Image")));
            this.PbRestaurar.Location = new System.Drawing.Point(1210, 1);
            this.PbRestaurar.Name = "PbRestaurar";
            this.PbRestaurar.Size = new System.Drawing.Size(35, 35);
            this.PbRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbRestaurar.TabIndex = 2;
            this.PbRestaurar.TabStop = false;
            // 
            // PbMinimizar
            // 
            this.PbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("PbMinimizar.Image")));
            this.PbMinimizar.Location = new System.Drawing.Point(1169, 1);
            this.PbMinimizar.Name = "PbMinimizar";
            this.PbMinimizar.Size = new System.Drawing.Size(35, 35);
            this.PbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbMinimizar.TabIndex = 1;
            this.PbMinimizar.TabStop = false;
            // 
            // PbSalir
            // 
            this.PbSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbSalir.Image = ((System.Drawing.Image)(resources.GetObject("PbSalir.Image")));
            this.PbSalir.Location = new System.Drawing.Point(1251, 0);
            this.PbSalir.Name = "PbSalir";
            this.PbSalir.Size = new System.Drawing.Size(35, 35);
            this.PbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbSalir.TabIndex = 0;
            this.PbSalir.TabStop = false;
            // 
            // PanelBarraLateral
            // 
            this.PanelBarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(51)))));
            this.PanelBarraLateral.Controls.Add(this.LbFecha);
            this.PanelBarraLateral.Controls.Add(this.LbHora);
            this.PanelBarraLateral.Controls.Add(this.BtnRegistrarLiquidacionCoutaModeradora);
            this.PanelBarraLateral.Controls.Add(this.BtnRegistrarPaciente);
            this.PanelBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelBarraLateral.Location = new System.Drawing.Point(0, 36);
            this.PanelBarraLateral.Name = "PanelBarraLateral";
            this.PanelBarraLateral.Size = new System.Drawing.Size(368, 679);
            this.PanelBarraLateral.TabIndex = 3;
            // 
            // LbFecha
            // 
            this.LbFecha.AutoSize = true;
            this.LbFecha.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFecha.ForeColor = System.Drawing.Color.White;
            this.LbFecha.Location = new System.Drawing.Point(87, 615);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.Size = new System.Drawing.Size(191, 38);
            this.LbFecha.TabIndex = 11;
            this.LbFecha.Text = "11/04/2020";
            // 
            // LbHora
            // 
            this.LbHora.AutoSize = true;
            this.LbHora.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHora.ForeColor = System.Drawing.Color.White;
            this.LbHora.Location = new System.Drawing.Point(45, 559);
            this.LbHora.Name = "LbHora";
            this.LbHora.Size = new System.Drawing.Size(274, 56);
            this.LbHora.TabIndex = 10;
            this.LbHora.Text = "12:52 p. m.";
            // 
            // BtnRegistrarLiquidacionCoutaModeradora
            // 
            this.BtnRegistrarLiquidacionCoutaModeradora.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarLiquidacionCoutaModeradora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarLiquidacionCoutaModeradora.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarLiquidacionCoutaModeradora.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrarLiquidacionCoutaModeradora.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarLiquidacionCoutaModeradora.Image")));
            this.BtnRegistrarLiquidacionCoutaModeradora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrarLiquidacionCoutaModeradora.Location = new System.Drawing.Point(-3, 409);
            this.BtnRegistrarLiquidacionCoutaModeradora.Name = "BtnRegistrarLiquidacionCoutaModeradora";
            this.BtnRegistrarLiquidacionCoutaModeradora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnRegistrarLiquidacionCoutaModeradora.Size = new System.Drawing.Size(368, 44);
            this.BtnRegistrarLiquidacionCoutaModeradora.TabIndex = 2;
            this.BtnRegistrarLiquidacionCoutaModeradora.Text = "Consultas";
            this.BtnRegistrarLiquidacionCoutaModeradora.UseVisualStyleBackColor = true;
            this.BtnRegistrarLiquidacionCoutaModeradora.Click += new System.EventHandler(this.BtnRegistrarLiquidacionCoutaModeradora_Click);
            // 
            // BtnRegistrarPaciente
            // 
            this.BtnRegistrarPaciente.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarPaciente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarPaciente.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarPaciente.Image")));
            this.BtnRegistrarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrarPaciente.Location = new System.Drawing.Point(-3, 359);
            this.BtnRegistrarPaciente.Name = "BtnRegistrarPaciente";
            this.BtnRegistrarPaciente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnRegistrarPaciente.Size = new System.Drawing.Size(368, 44);
            this.BtnRegistrarPaciente.TabIndex = 1;
            this.BtnRegistrarPaciente.Text = "Subir Archivo A Base de Datos";
            this.BtnRegistrarPaciente.UseVisualStyleBackColor = true;
            this.BtnRegistrarPaciente.Click += new System.EventHandler(this.BtnRegistrarPaciente_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(368, 36);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(932, 679);
            this.PanelContenedor.TabIndex = 4;
            // 
            // MenuPrincipalGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 715);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelBarraLateral);
            this.Controls.Add(this.PanelBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipalGui";
            this.Text = "MenuPrincipalGui";
            this.PanelBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSalir)).EndInit();
            this.PanelBarraLateral.ResumeLayout(false);
            this.PanelBarraLateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBarraSuperior;
        private System.Windows.Forms.PictureBox PbMaximizar;
        private System.Windows.Forms.PictureBox PbRestaurar;
        private System.Windows.Forms.PictureBox PbMinimizar;
        private System.Windows.Forms.PictureBox PbSalir;
        private System.Windows.Forms.Panel PanelBarraLateral;
        private System.Windows.Forms.Label LbFecha;
        private System.Windows.Forms.Label LbHora;
        private System.Windows.Forms.Button BtnRegistrarLiquidacionCoutaModeradora;
        private System.Windows.Forms.Button BtnRegistrarPaciente;
        private System.Windows.Forms.Panel PanelContenedor;
    }
}