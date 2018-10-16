namespace Sino_Automatizado
{
    partial class FrmGerirPeriodo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAutomatizar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listVPeriodos = new System.Windows.Forms.ListView();
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTempIntMaior = new System.Windows.Forms.ComboBox();
            this.txtIntMaior = new System.Windows.Forms.TextBox();
            this.txtIntRegular = new System.Windows.Forms.TextBox();
            this.HoraFinalAula = new System.Windows.Forms.DateTimePicker();
            this.HoraInicialAula = new System.Windows.Forms.DateTimePicker();
            this.txtDuracaoAula = new System.Windows.Forms.TextBox();
            this.chckIntMaior = new System.Windows.Forms.CheckBox();
            this.chckIntRegula = new System.Windows.Forms.CheckBox();
            this.cbxPeriodos = new System.Windows.Forms.ComboBox();
            this.panTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 396);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAutomatizar);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 354);
            this.panel2.TabIndex = 1;
            // 
            // btnAutomatizar
            // 
            this.btnAutomatizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(117)))), ((int)(((byte)(74)))));
            this.btnAutomatizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomatizar.ForeColor = System.Drawing.Color.White;
            this.btnAutomatizar.Location = new System.Drawing.Point(195, 303);
            this.btnAutomatizar.Name = "btnAutomatizar";
            this.btnAutomatizar.Size = new System.Drawing.Size(284, 36);
            this.btnAutomatizar.TabIndex = 15;
            this.btnAutomatizar.Text = "Automatizar os tempos";
            this.btnAutomatizar.UseVisualStyleBackColor = false;
            this.btnAutomatizar.Click += new System.EventHandler(this.btnAutomatizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listVPeriodos);
            this.groupBox2.Location = new System.Drawing.Point(337, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Periodos Gerados ";
            // 
            // listVPeriodos
            // 
            this.listVPeriodos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4});
            this.listVPeriodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVPeriodos.Location = new System.Drawing.Point(3, 16);
            this.listVPeriodos.Name = "listVPeriodos";
            this.listVPeriodos.Size = new System.Drawing.Size(400, 239);
            this.listVPeriodos.TabIndex = 0;
            this.listVPeriodos.UseCompatibleStateImageBehavior = false;
            // 
            // col1
            // 
            this.col1.Text = "Tempo";
            // 
            // col2
            // 
            this.col2.Text = "Hora Inicial";
            // 
            // col3
            // 
            this.col3.Text = "Hora Final";
            // 
            // col4
            // 
            this.col4.Text = "Intervalo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGerar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxTempIntMaior);
            this.groupBox1.Controls.Add(this.txtIntMaior);
            this.groupBox1.Controls.Add(this.txtIntRegular);
            this.groupBox1.Controls.Add(this.HoraFinalAula);
            this.groupBox1.Controls.Add(this.HoraInicialAula);
            this.groupBox1.Controls.Add(this.txtDuracaoAula);
            this.groupBox1.Controls.Add(this.chckIntMaior);
            this.groupBox1.Controls.Add(this.chckIntRegula);
            this.groupBox1.Controls.Add(this.cbxPeriodos);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criar Periodos ";
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(117)))), ((int)(((byte)(74)))));
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.White;
            this.btnGerar.Location = new System.Drawing.Point(18, 204);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(284, 36);
            this.btnGerar.TabIndex = 14;
            this.btnGerar.Text = "Gerar Periodo";
            this.btnGerar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fim de aulas :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tempo (Min) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Inicio de aulas :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Periodo : ";
            // 
            // cbxTempIntMaior
            // 
            this.cbxTempIntMaior.FormattingEnabled = true;
            this.cbxTempIntMaior.Items.AddRange(new object[] {
            "Tempo...",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbxTempIntMaior.Location = new System.Drawing.Point(248, 177);
            this.cbxTempIntMaior.Name = "cbxTempIntMaior";
            this.cbxTempIntMaior.Size = new System.Drawing.Size(54, 21);
            this.cbxTempIntMaior.TabIndex = 9;
            // 
            // txtIntMaior
            // 
            this.txtIntMaior.Location = new System.Drawing.Point(173, 178);
            this.txtIntMaior.Name = "txtIntMaior";
            this.txtIntMaior.Size = new System.Drawing.Size(65, 20);
            this.txtIntMaior.TabIndex = 8;
            // 
            // txtIntRegular
            // 
            this.txtIntRegular.Location = new System.Drawing.Point(18, 178);
            this.txtIntRegular.Name = "txtIntRegular";
            this.txtIntRegular.Size = new System.Drawing.Size(68, 20);
            this.txtIntRegular.TabIndex = 7;
            // 
            // HoraFinalAula
            // 
            this.HoraFinalAula.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraFinalAula.Location = new System.Drawing.Point(173, 113);
            this.HoraFinalAula.Name = "HoraFinalAula";
            this.HoraFinalAula.Size = new System.Drawing.Size(69, 20);
            this.HoraFinalAula.TabIndex = 6;
            // 
            // HoraInicialAula
            // 
            this.HoraInicialAula.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraInicialAula.Location = new System.Drawing.Point(18, 113);
            this.HoraInicialAula.Name = "HoraInicialAula";
            this.HoraInicialAula.Size = new System.Drawing.Size(78, 20);
            this.HoraInicialAula.TabIndex = 5;
            // 
            // txtDuracaoAula
            // 
            this.txtDuracaoAula.Enabled = false;
            this.txtDuracaoAula.Location = new System.Drawing.Point(173, 64);
            this.txtDuracaoAula.Name = "txtDuracaoAula";
            this.txtDuracaoAula.ReadOnly = true;
            this.txtDuracaoAula.Size = new System.Drawing.Size(69, 20);
            this.txtDuracaoAula.TabIndex = 4;
            // 
            // chckIntMaior
            // 
            this.chckIntMaior.AutoSize = true;
            this.chckIntMaior.Location = new System.Drawing.Point(173, 154);
            this.chckIntMaior.Name = "chckIntMaior";
            this.chckIntMaior.Size = new System.Drawing.Size(96, 17);
            this.chckIntMaior.TabIndex = 2;
            this.chckIntMaior.Text = "Intervalo Maior";
            this.chckIntMaior.UseVisualStyleBackColor = true;
            // 
            // chckIntRegula
            // 
            this.chckIntRegula.AutoSize = true;
            this.chckIntRegula.Location = new System.Drawing.Point(18, 155);
            this.chckIntRegula.Name = "chckIntRegula";
            this.chckIntRegula.Size = new System.Drawing.Size(107, 17);
            this.chckIntRegula.TabIndex = 1;
            this.chckIntRegula.Text = "Intervalo Regular";
            this.chckIntRegula.UseVisualStyleBackColor = true;
            // 
            // cbxPeriodos
            // 
            this.cbxPeriodos.FormattingEnabled = true;
            this.cbxPeriodos.Location = new System.Drawing.Point(18, 64);
            this.cbxPeriodos.Name = "cbxPeriodos";
            this.cbxPeriodos.Size = new System.Drawing.Size(121, 21);
            this.cbxPeriodos.TabIndex = 0;
            // 
            // panTitulo
            // 
            this.panTitulo.Controls.Add(this.label1);
            this.panTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitulo.Location = new System.Drawing.Point(0, 0);
            this.panTitulo.Name = "panTitulo";
            this.panTitulo.Size = new System.Drawing.Size(754, 42);
            this.panTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTÃO AUTOMATIZADA DE PERIODO";
            // 
            // FrmGerirPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 396);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGerirPeriodo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Periodos";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panTitulo.ResumeLayout(false);
            this.panTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTempIntMaior;
        private System.Windows.Forms.TextBox txtIntMaior;
        private System.Windows.Forms.TextBox txtIntRegular;
        private System.Windows.Forms.DateTimePicker HoraFinalAula;
        private System.Windows.Forms.DateTimePicker HoraInicialAula;
        private System.Windows.Forms.TextBox txtDuracaoAula;
        private System.Windows.Forms.CheckBox chckIntMaior;
        private System.Windows.Forms.CheckBox chckIntRegula;
        private System.Windows.Forms.ComboBox cbxPeriodos;
        private System.Windows.Forms.Panel panTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAutomatizar;
        private System.Windows.Forms.ListView listVPeriodos;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col3;
        private System.Windows.Forms.ColumnHeader col4;
    }
}