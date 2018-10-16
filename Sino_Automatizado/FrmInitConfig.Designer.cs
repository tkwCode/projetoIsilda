namespace Sino_Automatizado
{
    partial class FrmInitConfig
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chckManha = new System.Windows.Forms.CheckBox();
            this.chckTarde = new System.Windows.Forms.CheckBox();
            this.chckNoite = new System.Windows.Forms.CheckBox();
            this.mskTempoAula = new System.Windows.Forms.MaskedTextBox();
            this.mskIntPequeno = new System.Windows.Forms.MaskedTextBox();
            this.mskIntMaior = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 229);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 152);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 77);
            this.panel3.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(117)))), ((int)(((byte)(74)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(49, 24);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(234, 36);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardadr";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mskTempoAula);
            this.groupBox1.Controls.Add(this.mskIntPequeno);
            this.groupBox1.Controls.Add(this.mskIntMaior);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações de Tempos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chckNoite);
            this.groupBox2.Controls.Add(this.chckTarde);
            this.groupBox2.Controls.Add(this.chckManha);
            this.groupBox2.Location = new System.Drawing.Point(225, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(85, 90);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Periodos: ";
            // 
            // chckManha
            // 
            this.chckManha.AutoSize = true;
            this.chckManha.Location = new System.Drawing.Point(3, 18);
            this.chckManha.Name = "chckManha";
            this.chckManha.Size = new System.Drawing.Size(59, 17);
            this.chckManha.TabIndex = 0;
            this.chckManha.Text = "Manhã";
            this.chckManha.UseVisualStyleBackColor = true;
            // 
            // chckTarde
            // 
            this.chckTarde.AutoSize = true;
            this.chckTarde.Location = new System.Drawing.Point(3, 39);
            this.chckTarde.Name = "chckTarde";
            this.chckTarde.Size = new System.Drawing.Size(54, 17);
            this.chckTarde.TabIndex = 1;
            this.chckTarde.Text = "Tarde";
            this.chckTarde.UseVisualStyleBackColor = true;
            // 
            // chckNoite
            // 
            this.chckNoite.AutoSize = true;
            this.chckNoite.Location = new System.Drawing.Point(3, 62);
            this.chckNoite.Name = "chckNoite";
            this.chckNoite.Size = new System.Drawing.Size(51, 17);
            this.chckNoite.TabIndex = 2;
            this.chckNoite.Text = "Noite";
            this.chckNoite.UseVisualStyleBackColor = true;
            // 
            // mskTempoAula
            // 
            this.mskTempoAula.Location = new System.Drawing.Point(143, 38);
            this.mskTempoAula.Mask = "00:00";
            this.mskTempoAula.Name = "mskTempoAula";
            this.mskTempoAula.Size = new System.Drawing.Size(76, 20);
            this.mskTempoAula.TabIndex = 3;
            this.mskTempoAula.ValidatingType = typeof(System.DateTime);
            // 
            // mskIntPequeno
            // 
            this.mskIntPequeno.Location = new System.Drawing.Point(143, 64);
            this.mskIntPequeno.Mask = "00:00";
            this.mskIntPequeno.Name = "mskIntPequeno";
            this.mskIntPequeno.Size = new System.Drawing.Size(76, 20);
            this.mskIntPequeno.TabIndex = 4;
            this.mskIntPequeno.ValidatingType = typeof(System.DateTime);
            // 
            // mskIntMaior
            // 
            this.mskIntMaior.Location = new System.Drawing.Point(143, 90);
            this.mskIntMaior.Mask = "00:00";
            this.mskIntMaior.Name = "mskIntMaior";
            this.mskIntMaior.Size = new System.Drawing.Size(76, 20);
            this.mskIntMaior.TabIndex = 5;
            this.mskIntMaior.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Duração de Aula(Min) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Intervalo Peq.(Min) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Intervalo Maior(Min) :";
            // 
            // FrmInitConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 229);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmInitConfig";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações Iniciais";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskTempoAula;
        private System.Windows.Forms.MaskedTextBox mskIntPequeno;
        private System.Windows.Forms.MaskedTextBox mskIntMaior;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chckNoite;
        private System.Windows.Forms.CheckBox chckTarde;
        private System.Windows.Forms.CheckBox chckManha;
    }
}

