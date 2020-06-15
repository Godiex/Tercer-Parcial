namespace ExamenPracticaGUI
{
    partial class Consultas
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
            this.DgvRecaudos = new System.Windows.Forms.DataGridView();
            this.Nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreestampilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcontratista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnConsultaGeneral = new System.Windows.Forms.Button();
            this.TbMes = new System.Windows.Forms.TextBox();
            this.TbNick = new System.Windows.Forms.TextBox();
            this.TbAño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbTipoConsulta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbTipoEstampilla = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecaudos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.DgvRecaudos.Location = new System.Drawing.Point(46, 264);
            this.DgvRecaudos.Name = "DgvRecaudos";
            this.DgvRecaudos.Size = new System.Drawing.Size(787, 171);
            this.DgvRecaudos.TabIndex = 8;
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
            // BtnConsultaGeneral
            // 
            this.BtnConsultaGeneral.Location = new System.Drawing.Point(797, 114);
            this.BtnConsultaGeneral.Name = "BtnConsultaGeneral";
            this.BtnConsultaGeneral.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultaGeneral.TabIndex = 9;
            this.BtnConsultaGeneral.Text = "Consultar";
            this.BtnConsultaGeneral.UseVisualStyleBackColor = true;
            this.BtnConsultaGeneral.Click += new System.EventHandler(this.BtnConsultaGeneral_Click);
            // 
            // TbMes
            // 
            this.TbMes.Location = new System.Drawing.Point(41, 34);
            this.TbMes.Name = "TbMes";
            this.TbMes.Size = new System.Drawing.Size(100, 20);
            this.TbMes.TabIndex = 10;
            // 
            // TbNick
            // 
            this.TbNick.Location = new System.Drawing.Point(385, 34);
            this.TbNick.Name = "TbNick";
            this.TbNick.Size = new System.Drawing.Size(100, 20);
            this.TbNick.TabIndex = 11;
            // 
            // TbAño
            // 
            this.TbAño.Location = new System.Drawing.Point(178, 34);
            this.TbAño.Name = "TbAño";
            this.TbAño.Size = new System.Drawing.Size(100, 20);
            this.TbAño.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nick Ubicacion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbNick);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TbMes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbAño);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 74);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GbConsultaProNickUbicacion";
            // 
            // CmbTipoConsulta
            // 
            this.CmbTipoConsulta.FormattingEnabled = true;
            this.CmbTipoConsulta.Location = new System.Drawing.Point(760, 75);
            this.CmbTipoConsulta.Name = "CmbTipoConsulta";
            this.CmbTipoConsulta.Size = new System.Drawing.Size(121, 21);
            this.CmbTipoConsulta.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tipo Consulta :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tipo Estampilla:";
            // 
            // CmbTipoEstampilla
            // 
            this.CmbTipoEstampilla.FormattingEnabled = true;
            this.CmbTipoEstampilla.Items.AddRange(new object[] {
            "Adulto Mayor",
            "Pro Cultura",
            "Pro-UPC",
            "ProFronterizo"});
            this.CmbTipoEstampilla.Location = new System.Drawing.Point(135, 116);
            this.CmbTipoEstampilla.Name = "CmbTipoEstampilla";
            this.CmbTipoEstampilla.Size = new System.Drawing.Size(121, 21);
            this.CmbTipoEstampilla.TabIndex = 19;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 519);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbTipoEstampilla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbTipoConsulta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnConsultaGeneral);
            this.Controls.Add(this.DgvRecaudos);
            this.Name = "Consultas";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecaudos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRecaudos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nick;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn año;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreestampilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontratista;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Button BtnConsultaGeneral;
        private System.Windows.Forms.TextBox TbMes;
        private System.Windows.Forms.TextBox TbNick;
        private System.Windows.Forms.TextBox TbAño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbTipoConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbTipoEstampilla;
    }
}