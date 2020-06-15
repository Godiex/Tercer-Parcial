namespace ExamenPracticaGUI
{
    partial class CargueRecaudoGui
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CargarBtn = new System.Windows.Forms.Button();
            this.DgvRecaudos = new System.Windows.Forms.DataGridView();
            this.BtnConsultarArchivo = new System.Windows.Forms.Button();
            this.Nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreestampilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcontratista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecaudos)).BeginInit();
            this.SuspendLayout();
            // 
            // CargarBtn
            // 
            this.CargarBtn.Location = new System.Drawing.Point(620, 457);
            this.CargarBtn.Name = "CargarBtn";
            this.CargarBtn.Size = new System.Drawing.Size(197, 39);
            this.CargarBtn.TabIndex = 6;
            this.CargarBtn.Text = "Cargar a base de datos ";
            this.CargarBtn.UseVisualStyleBackColor = true;
            this.CargarBtn.Click += new System.EventHandler(this.CargarBtn_Click);
            // 
            // DgvRecaudos
            // 
            this.DgvRecaudos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRecaudos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nick,
            this.Mes,
            this.año,
            this.nombreestampilla,
            this.valor,
            this.idcontratista,
            this.nombre});
            this.DgvRecaudos.Location = new System.Drawing.Point(30, 125);
            this.DgvRecaudos.Name = "DgvRecaudos";
            this.DgvRecaudos.Size = new System.Drawing.Size(787, 171);
            this.DgvRecaudos.TabIndex = 7;
            // 
            // BtnConsultarArchivo
            // 
            this.BtnConsultarArchivo.Location = new System.Drawing.Point(30, 65);
            this.BtnConsultarArchivo.Name = "BtnConsultarArchivo";
            this.BtnConsultarArchivo.Size = new System.Drawing.Size(197, 39);
            this.BtnConsultarArchivo.TabIndex = 8;
            this.BtnConsultarArchivo.Text = "Consultar Archivo Recaudo";
            this.BtnConsultarArchivo.UseVisualStyleBackColor = true;
            this.BtnConsultarArchivo.Click += new System.EventHandler(this.BtnConsultarArchivo_Click);
            // 
            // Nick
            // 
            this.Nick.HeaderText = "Nick Ubicacion";
            this.Nick.Name = "Nick";
            // 
            // Mes
            // 
            this.Mes.HeaderText = "mes";
            this.Mes.Name = "Mes";
            // 
            // año
            // 
            this.año.HeaderText = "año";
            this.año.Name = "año";
            // 
            // nombreestampilla
            // 
            this.nombreestampilla.HeaderText = "nombre estampilla";
            this.nombreestampilla.Name = "nombreestampilla";
            // 
            // valor
            // 
            this.valor.HeaderText = "valor";
            this.valor.Name = "valor";
            // 
            // idcontratista
            // 
            this.idcontratista.HeaderText = "id contratista";
            this.idcontratista.Name = "idcontratista";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre Contratista";
            this.nombre.Name = "nombre";
            // 
            // CargueRecaudoGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 521);
            this.Controls.Add(this.BtnConsultarArchivo);
            this.Controls.Add(this.DgvRecaudos);
            this.Controls.Add(this.CargarBtn);
            this.Name = "CargueRecaudoGui";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecaudos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CargarBtn;
        private System.Windows.Forms.DataGridView DgvRecaudos;
        private System.Windows.Forms.Button BtnConsultarArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nick;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn año;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreestampilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontratista;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}

