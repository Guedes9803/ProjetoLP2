namespace ProjetoLP2
{
    partial class TorneioInfoControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnRemPart = new System.Windows.Forms.Button();
            this.btnTabela = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.cbAno2 = new System.Windows.Forms.ComboBox();
            this.cbMes2 = new System.Windows.Forms.ComboBox();
            this.cbDia2 = new System.Windows.Forms.ComboBox();
            this.dgPart = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radio32 = new System.Windows.Forms.RadioButton();
            this.radio16 = new System.Windows.Forms.RadioButton();
            this.radio8 = new System.Windows.Forms.RadioButton();
            this.lblRest = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addVariosPartControl1 = new ProjetoLP2.addVariosPartControl();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPremio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNome.Location = new System.Drawing.Point(39, 86);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 14);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(39, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data de Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(39, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data de Termino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(39, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantida de Participantes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(39, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vagas Restantes";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAlterar.Location = new System.Drawing.Point(94, 330);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 45);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Salvar Alterações";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAddPart.Location = new System.Drawing.Point(553, 330);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(93, 45);
            this.btnAddPart.TabIndex = 2;
            this.btnAddPart.Text = "Adicionar Participante";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnRemPart
            // 
            this.btnRemPart.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnRemPart.Location = new System.Drawing.Point(700, 330);
            this.btnRemPart.Name = "btnRemPart";
            this.btnRemPart.Size = new System.Drawing.Size(93, 45);
            this.btnRemPart.TabIndex = 2;
            this.btnRemPart.Text = "Remover Participante";
            this.btnRemPart.UseVisualStyleBackColor = true;
            this.btnRemPart.Click += new System.EventHandler(this.btnRemPart_Click);
            // 
            // btnTabela
            // 
            this.btnTabela.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnTabela.Location = new System.Drawing.Point(218, 330);
            this.btnTabela.Name = "btnTabela";
            this.btnTabela.Size = new System.Drawing.Size(93, 45);
            this.btnTabela.TabIndex = 2;
            this.btnTabela.Text = "Ver Tabela Campeonato";
            this.btnTabela.UseVisualStyleBackColor = true;
            this.btnTabela.Click += new System.EventHandler(this.btnTabela_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.Location = new System.Drawing.Point(42, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.Location = new System.Drawing.Point(211, 83);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(205, 22);
            this.txtNome.TabIndex = 3;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // cbAno
            // 
            this.cbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAno.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Location = new System.Drawing.Point(211, 128);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(54, 22);
            this.cbAno.TabIndex = 4;
            this.cbAno.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(288, 128);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(54, 22);
            this.cbMes.TabIndex = 4;
            // 
            // cbDia
            // 
            this.cbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDia.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Location = new System.Drawing.Point(362, 128);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(54, 22);
            this.cbDia.TabIndex = 4;
            // 
            // cbAno2
            // 
            this.cbAno2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAno2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbAno2.FormattingEnabled = true;
            this.cbAno2.Location = new System.Drawing.Point(211, 170);
            this.cbAno2.Name = "cbAno2";
            this.cbAno2.Size = new System.Drawing.Size(54, 22);
            this.cbAno2.TabIndex = 4;
            // 
            // cbMes2
            // 
            this.cbMes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbMes2.FormattingEnabled = true;
            this.cbMes2.Location = new System.Drawing.Point(288, 170);
            this.cbMes2.Name = "cbMes2";
            this.cbMes2.Size = new System.Drawing.Size(54, 22);
            this.cbMes2.TabIndex = 4;
            // 
            // cbDia2
            // 
            this.cbDia2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDia2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbDia2.FormattingEnabled = true;
            this.cbDia2.Location = new System.Drawing.Point(362, 170);
            this.cbDia2.Name = "cbDia2";
            this.cbDia2.Size = new System.Drawing.Size(54, 22);
            this.cbDia2.TabIndex = 4;
            // 
            // dgPart
            // 
            this.dgPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPart.Location = new System.Drawing.Point(553, 83);
            this.dgPart.Name = "dgPart";
            this.dgPart.Size = new System.Drawing.Size(240, 220);
            this.dgPart.TabIndex = 5;
            this.dgPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPart_CellClick);
            this.dgPart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPart_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio32);
            this.panel1.Controls.Add(this.radio16);
            this.panel1.Controls.Add(this.radio8);
            this.panel1.Location = new System.Drawing.Point(211, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 34);
            this.panel1.TabIndex = 6;
            // 
            // radio32
            // 
            this.radio32.AutoSize = true;
            this.radio32.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.radio32.Location = new System.Drawing.Point(151, 9);
            this.radio32.Name = "radio32";
            this.radio32.Size = new System.Drawing.Size(39, 18);
            this.radio32.TabIndex = 0;
            this.radio32.TabStop = true;
            this.radio32.Text = "32";
            this.radio32.UseVisualStyleBackColor = true;
            // 
            // radio16
            // 
            this.radio16.AutoSize = true;
            this.radio16.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.radio16.Location = new System.Drawing.Point(77, 9);
            this.radio16.Name = "radio16";
            this.radio16.Size = new System.Drawing.Size(39, 18);
            this.radio16.TabIndex = 0;
            this.radio16.TabStop = true;
            this.radio16.Text = "16";
            this.radio16.UseVisualStyleBackColor = true;
            this.radio16.Click += new System.EventHandler(this.radio16_Click);
            // 
            // radio8
            // 
            this.radio8.AutoSize = true;
            this.radio8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.radio8.Location = new System.Drawing.Point(7, 9);
            this.radio8.Name = "radio8";
            this.radio8.Size = new System.Drawing.Size(32, 18);
            this.radio8.TabIndex = 0;
            this.radio8.TabStop = true;
            this.radio8.Text = "8";
            this.radio8.UseVisualStyleBackColor = true;
            this.radio8.CheckedChanged += new System.EventHandler(this.radio8_CheckedChanged);
            this.radio8.Click += new System.EventHandler(this.radio8_Click);
            // 
            // lblRest
            // 
            this.lblRest.AutoSize = true;
            this.lblRest.Location = new System.Drawing.Point(211, 270);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(35, 13);
            this.lblRest.TabIndex = 7;
            this.lblRest.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // addVariosPartControl1
            // 
            this.addVariosPartControl1.Location = new System.Drawing.Point(0, 0);
            this.addVariosPartControl1.Name = "addVariosPartControl1";
            this.addVariosPartControl1.Size = new System.Drawing.Size(864, 447);
            this.addVariosPartControl1.TabIndex = 8;
            this.addVariosPartControl1.Load += new System.EventHandler(this.addVariosPartControl1_Load);
            this.addVariosPartControl1.VisibleChanged += new System.EventHandler(this.addVariosPartControl1_VisibleChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(42, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prêmio";
            // 
            // txtPremio
            // 
            this.txtPremio.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPremio.Location = new System.Drawing.Point(211, 296);
            this.txtPremio.Name = "txtPremio";
            this.txtPremio.Size = new System.Drawing.Size(220, 22);
            this.txtPremio.TabIndex = 11;
            // 
            // TorneioInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPremio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRest);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgPart);
            this.Controls.Add(this.cbDia2);
            this.Controls.Add(this.cbDia);
            this.Controls.Add(this.cbMes2);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.cbAno2);
            this.Controls.Add(this.cbAno);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnTabela);
            this.Controls.Add(this.btnRemPart);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.addVariosPartControl1);
            this.Name = "TorneioInfoControl";
            this.Size = new System.Drawing.Size(863, 447);
            this.Load += new System.EventHandler(this.TorneioInfoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnRemPart;
        private System.Windows.Forms.Button btnTabela;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.ComboBox cbAno2;
        private System.Windows.Forms.ComboBox cbMes2;
        private System.Windows.Forms.ComboBox cbDia2;
        private System.Windows.Forms.DataGridView dgPart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radio32;
        private System.Windows.Forms.RadioButton radio16;
        private System.Windows.Forms.RadioButton radio8;
        private System.Windows.Forms.Label lblRest;
        private addVariosPartControl addVariosPartControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPremio;
    }
}
