namespace ProjetoLP2
{
    partial class criarTorneioControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDt_Inicio = new System.Windows.Forms.Label();
            this.lblDtFim = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.mesCombo = new System.Windows.Forms.ComboBox();
            this.diaCombo = new System.Windows.Forms.ComboBox();
            this.anoCombo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.anoCombo2 = new System.Windows.Forms.ComboBox();
            this.mesCombo2 = new System.Windows.Forms.ComboBox();
            this.diaCombo2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radio32 = new System.Windows.Forms.RadioButton();
            this.radio16 = new System.Windows.Forms.RadioButton();
            this.radio8 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblNome.Location = new System.Drawing.Point(164, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 19);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblDt_Inicio
            // 
            this.lblDt_Inicio.AutoSize = true;
            this.lblDt_Inicio.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblDt_Inicio.Location = new System.Drawing.Point(164, 111);
            this.lblDt_Inicio.Name = "lblDt_Inicio";
            this.lblDt_Inicio.Size = new System.Drawing.Size(85, 19);
            this.lblDt_Inicio.TabIndex = 0;
            this.lblDt_Inicio.Text = "Data Inicio";
            // 
            // lblDtFim
            // 
            this.lblDtFim.AutoSize = true;
            this.lblDtFim.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblDtFim.Location = new System.Drawing.Point(164, 162);
            this.lblDtFim.Name = "lblDtFim";
            this.lblDtFim.Size = new System.Drawing.Size(82, 19);
            this.lblDtFim.TabIndex = 0;
            this.lblDtFim.Text = "Data Final";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(164, 226);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(102, 19);
            this.lblQtd.TabIndex = 0;
            this.lblQtd.Text = "Participantes";
            // 
            // mesCombo
            // 
            this.mesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mesCombo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesCombo.FormattingEnabled = true;
            this.mesCombo.Location = new System.Drawing.Point(417, 104);
            this.mesCombo.Name = "mesCombo";
            this.mesCombo.Size = new System.Drawing.Size(75, 27);
            this.mesCombo.TabIndex = 1;
            this.mesCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // diaCombo
            // 
            this.diaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diaCombo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaCombo.FormattingEnabled = true;
            this.diaCombo.Location = new System.Drawing.Point(537, 104);
            this.diaCombo.Name = "diaCombo";
            this.diaCombo.Size = new System.Drawing.Size(71, 27);
            this.diaCombo.TabIndex = 2;
            this.diaCombo.SelectedIndexChanged += new System.EventHandler(this.diaCombo_SelectedIndexChanged);
            // 
            // anoCombo
            // 
            this.anoCombo.BackColor = System.Drawing.SystemColors.Window;
            this.anoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anoCombo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anoCombo.FormattingEnabled = true;
            this.anoCombo.Location = new System.Drawing.Point(288, 104);
            this.anoCombo.Name = "anoCombo";
            this.anoCombo.Size = new System.Drawing.Size(75, 27);
            this.anoCombo.TabIndex = 3;
            this.anoCombo.SelectedIndexChanged += new System.EventHandler(this.anoCombo_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNome.Location = new System.Drawing.Point(259, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(349, 27);
            this.txtNome.TabIndex = 4;
            this.txtNome.Text = "Nome do Torneio";
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // anoCombo2
            // 
            this.anoCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anoCombo2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anoCombo2.FormattingEnabled = true;
            this.anoCombo2.Location = new System.Drawing.Point(288, 150);
            this.anoCombo2.Name = "anoCombo2";
            this.anoCombo2.Size = new System.Drawing.Size(75, 27);
            this.anoCombo2.TabIndex = 3;
            this.anoCombo2.SelectedIndexChanged += new System.EventHandler(this.anoCombo2_SelectedIndexChanged);
            // 
            // mesCombo2
            // 
            this.mesCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mesCombo2.Font = new System.Drawing.Font("Roboto", 12F);
            this.mesCombo2.FormattingEnabled = true;
            this.mesCombo2.Location = new System.Drawing.Point(417, 150);
            this.mesCombo2.Name = "mesCombo2";
            this.mesCombo2.Size = new System.Drawing.Size(75, 27);
            this.mesCombo2.TabIndex = 1;
            this.mesCombo2.SelectedIndexChanged += new System.EventHandler(this.mesCombo2_SelectedIndexChanged);
            // 
            // diaCombo2
            // 
            this.diaCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diaCombo2.Font = new System.Drawing.Font("Roboto", 12F);
            this.diaCombo2.FormattingEnabled = true;
            this.diaCombo2.Location = new System.Drawing.Point(537, 148);
            this.diaCombo2.Name = "diaCombo2";
            this.diaCombo2.Size = new System.Drawing.Size(71, 27);
            this.diaCombo2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio32);
            this.panel1.Controls.Add(this.radio16);
            this.panel1.Controls.Add(this.radio8);
            this.panel1.Location = new System.Drawing.Point(298, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 38);
            this.panel1.TabIndex = 5;
            // 
            // radio32
            // 
            this.radio32.AutoSize = true;
            this.radio32.Font = new System.Drawing.Font("Roboto", 12F);
            this.radio32.Location = new System.Drawing.Point(188, 10);
            this.radio32.Name = "radio32";
            this.radio32.Size = new System.Drawing.Size(45, 23);
            this.radio32.TabIndex = 0;
            this.radio32.TabStop = true;
            this.radio32.Text = "32";
            this.radio32.UseVisualStyleBackColor = true;
            // 
            // radio16
            // 
            this.radio16.AutoSize = true;
            this.radio16.Font = new System.Drawing.Font("Roboto", 12F);
            this.radio16.Location = new System.Drawing.Point(90, 12);
            this.radio16.Name = "radio16";
            this.radio16.Size = new System.Drawing.Size(45, 23);
            this.radio16.TabIndex = 0;
            this.radio16.TabStop = true;
            this.radio16.Text = "16";
            this.radio16.UseVisualStyleBackColor = true;
            // 
            // radio8
            // 
            this.radio8.AutoSize = true;
            this.radio8.Font = new System.Drawing.Font("Roboto", 12F);
            this.radio8.Location = new System.Drawing.Point(3, 10);
            this.radio8.Name = "radio8";
            this.radio8.Size = new System.Drawing.Size(36, 23);
            this.radio8.TabIndex = 0;
            this.radio8.TabStop = true;
            this.radio8.Text = "8";
            this.radio8.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Dia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Dia";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(395, 290);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(80, 32);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // criarTorneioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.anoCombo2);
            this.Controls.Add(this.anoCombo);
            this.Controls.Add(this.diaCombo2);
            this.Controls.Add(this.diaCombo);
            this.Controls.Add(this.mesCombo2);
            this.Controls.Add(this.mesCombo);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblDtFim);
            this.Controls.Add(this.lblDt_Inicio);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "criarTorneioControl";
            this.Size = new System.Drawing.Size(864, 451);
            this.Load += new System.EventHandler(this.criarTorneioControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDt_Inicio;
        private System.Windows.Forms.Label lblDtFim;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.ComboBox mesCombo;
        private System.Windows.Forms.ComboBox diaCombo;
        private System.Windows.Forms.ComboBox anoCombo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox anoCombo2;
        private System.Windows.Forms.ComboBox mesCombo2;
        private System.Windows.Forms.ComboBox diaCombo2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radio32;
        private System.Windows.Forms.RadioButton radio16;
        private System.Windows.Forms.RadioButton radio8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEnviar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
