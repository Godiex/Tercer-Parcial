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
            this.GbConsulta1 = new System.Windows.Forms.GroupBox();
            this.CmbTipoConsulta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbProCultura = new System.Windows.Forms.TextBox();
            this.TbProFronterizo = new System.Windows.Forms.TextBox();
            this.TbProUpc = new System.Windows.Forms.TextBox();
            this.TbAdulto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.qwq = new System.Windows.Forms.GroupBox();
            this.GbConsulta2 = new System.Windows.Forms.GroupBox();
            this.TbMes2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TBAño2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecaudos)).BeginInit();
            this.GbConsulta1.SuspendLayout();
            this.qwq.SuspendLayout();
            this.GbConsulta2.SuspendLayout();
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
            this.DgvRecaudos.Location = new System.Drawing.Point(31, 300);
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
            this.BtnConsultaGeneral.Location = new System.Drawing.Point(816, 94);
            this.BtnConsultaGeneral.Name = "BtnConsultaGeneral";
            this.BtnConsultaGeneral.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultaGeneral.TabIndex = 9;
            this.BtnConsultaGeneral.Text = "Consultar";
            this.BtnConsultaGeneral.UseVisualStyleBackColor = true;
            this.BtnConsultaGeneral.Click += new System.EventHandler(this.BtnConsultaGeneral_Click);
            // 
            // TbMes
            // 
            this.TbMes.Location = new System.Drawing.Point(41, 19);
            this.TbMes.Name = "TbMes";
            this.TbMes.Size = new System.Drawing.Size(100, 20);
            this.TbMes.TabIndex = 10;
            // 
            // TbNick
            // 
            this.TbNick.Location = new System.Drawing.Point(385, 19);
            this.TbNick.Name = "TbNick";
            this.TbNick.Size = new System.Drawing.Size(100, 20);
            this.TbNick.TabIndex = 11;
            // 
            // TbAño
            // 
            this.TbAño.Location = new System.Drawing.Point(178, 19);
            this.TbAño.Name = "TbAño";
            this.TbAño.Size = new System.Drawing.Size(100, 20);
            this.TbAño.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nick Ubicacion";
            // 
            // GbConsulta1
            // 
            this.GbConsulta1.Controls.Add(this.TbNick);
            this.GbConsulta1.Controls.Add(this.label3);
            this.GbConsulta1.Controls.Add(this.TbMes);
            this.GbConsulta1.Controls.Add(this.label2);
            this.GbConsulta1.Controls.Add(this.TbAño);
            this.GbConsulta1.Controls.Add(this.label1);
            this.GbConsulta1.Location = new System.Drawing.Point(31, 19);
            this.GbConsulta1.Name = "GbConsulta1";
            this.GbConsulta1.Size = new System.Drawing.Size(532, 50);
            this.GbConsulta1.TabIndex = 16;
            this.GbConsulta1.TabStop = false;
            this.GbConsulta1.Text = "GbConsultaProNickUbicacion";
            // 
            // CmbTipoConsulta
            // 
            this.CmbTipoConsulta.FormattingEnabled = true;
            this.CmbTipoConsulta.Items.AddRange(new object[] {
            "Consulta Por Nick",
            "Consulta Por Fecha Y totalizacoin de estampillas"});
            this.CmbTipoConsulta.Location = new System.Drawing.Point(686, 48);
            this.CmbTipoConsulta.Name = "CmbTipoConsulta";
            this.CmbTipoConsulta.Size = new System.Drawing.Size(205, 21);
            this.CmbTipoConsulta.TabIndex = 17;
            this.CmbTipoConsulta.SelectedIndexChanged += new System.EventHandler(this.CmbTipoConsulta_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tipo Consulta :";
            // 
            // TbProCultura
            // 
            this.TbProCultura.Location = new System.Drawing.Point(128, 30);
            this.TbProCultura.Name = "TbProCultura";
            this.TbProCultura.Size = new System.Drawing.Size(100, 20);
            this.TbProCultura.TabIndex = 16;
            // 
            // TbProFronterizo
            // 
            this.TbProFronterizo.Location = new System.Drawing.Point(128, 106);
            this.TbProFronterizo.Name = "TbProFronterizo";
            this.TbProFronterizo.Size = new System.Drawing.Size(100, 20);
            this.TbProFronterizo.TabIndex = 20;
            // 
            // TbProUpc
            // 
            this.TbProUpc.Location = new System.Drawing.Point(128, 80);
            this.TbProUpc.Name = "TbProUpc";
            this.TbProUpc.Size = new System.Drawing.Size(100, 20);
            this.TbProUpc.TabIndex = 21;
            // 
            // TbAdulto
            // 
            this.TbAdulto.Location = new System.Drawing.Point(128, 56);
            this.TbAdulto.Name = "TbAdulto";
            this.TbAdulto.Size = new System.Drawing.Size(100, 20);
            this.TbAdulto.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total Pro Cultura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Total Adulto Mayor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Total Pro-Upc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Total ProFronterizo";
            // 
            // qwq
            // 
            this.qwq.Controls.Add(this.label7);
            this.qwq.Controls.Add(this.label9);
            this.qwq.Controls.Add(this.TbProCultura);
            this.qwq.Controls.Add(this.label8);
            this.qwq.Controls.Add(this.TbProFronterizo);
            this.qwq.Controls.Add(this.TbProUpc);
            this.qwq.Controls.Add(this.label6);
            this.qwq.Controls.Add(this.TbAdulto);
            this.qwq.Location = new System.Drawing.Point(31, 130);
            this.qwq.Name = "qwq";
            this.qwq.Size = new System.Drawing.Size(266, 135);
            this.qwq.TabIndex = 27;
            this.qwq.TabStop = false;
            this.qwq.Text = "groupBox2";
            // 
            // GbConsulta2
            // 
            this.GbConsulta2.Controls.Add(this.TbMes2);
            this.GbConsulta2.Controls.Add(this.label10);
            this.GbConsulta2.Controls.Add(this.TBAño2);
            this.GbConsulta2.Controls.Add(this.label11);
            this.GbConsulta2.Location = new System.Drawing.Point(31, 75);
            this.GbConsulta2.Name = "GbConsulta2";
            this.GbConsulta2.Size = new System.Drawing.Size(343, 49);
            this.GbConsulta2.TabIndex = 17;
            this.GbConsulta2.TabStop = false;
            this.GbConsulta2.Text = "GbConsultaPorFechaYTotalizacion de estampillas";
            // 
            // TbMes2
            // 
            this.TbMes2.Location = new System.Drawing.Point(41, 19);
            this.TbMes2.Name = "TbMes2";
            this.TbMes2.Size = new System.Drawing.Size(100, 20);
            this.TbMes2.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "año";
            // 
            // TBAño2
            // 
            this.TBAño2.Location = new System.Drawing.Point(178, 19);
            this.TBAño2.Name = "TBAño2";
            this.TBAño2.Size = new System.Drawing.Size(100, 20);
            this.TBAño2.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Mes";
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 519);
            this.Controls.Add(this.GbConsulta2);
            this.Controls.Add(this.qwq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbTipoConsulta);
            this.Controls.Add(this.GbConsulta1);
            this.Controls.Add(this.BtnConsultaGeneral);
            this.Controls.Add(this.DgvRecaudos);
            this.Name = "Consultas";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecaudos)).EndInit();
            this.GbConsulta1.ResumeLayout(false);
            this.GbConsulta1.PerformLayout();
            this.qwq.ResumeLayout(false);
            this.qwq.PerformLayout();
            this.GbConsulta2.ResumeLayout(false);
            this.GbConsulta2.PerformLayout();
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
        private System.Windows.Forms.GroupBox GbConsulta1;
        private System.Windows.Forms.ComboBox CmbTipoConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbProCultura;
        private System.Windows.Forms.TextBox TbProFronterizo;
        private System.Windows.Forms.TextBox TbProUpc;
        private System.Windows.Forms.TextBox TbAdulto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox qwq;
        private System.Windows.Forms.GroupBox GbConsulta2;
        private System.Windows.Forms.TextBox TbMes2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBAño2;
        private System.Windows.Forms.Label label11;
    }
}