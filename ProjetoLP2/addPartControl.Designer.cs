namespace ProjetoLP2
{
    partial class addPartControl
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
            this.components = new System.ComponentModel.Container();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.btnConf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.lblAst = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TTAst = new System.Windows.Forms.ToolTip(this.components);
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkM = new System.Windows.Forms.RadioButton();
            this.checkF = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(180, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(137, 26);
            this.txtNome.TabIndex = 0;
            // 
            // txtSobre
            // 
            this.txtSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobre.Location = new System.Drawing.Point(180, 93);
            this.txtSobre.Name = "txtSobre";
            this.txtSobre.Size = new System.Drawing.Size(137, 26);
            this.txtSobre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(57, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSobrenome.Location = new System.Drawing.Point(57, 96);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(92, 20);
            this.lblSobrenome.TabIndex = 2;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // btnConf
            // 
            this.btnConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnConf.FlatAppearance.BorderSize = 0;
            this.btnConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConf.ForeColor = System.Drawing.Color.White;
            this.btnConf.Location = new System.Drawing.Point(357, 210);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(105, 33);
            this.btnConf.TabIndex = 3;
            this.btnConf.Text = "Confirmar";
            this.btnConf.UseVisualStyleBackColor = false;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(536, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 4;
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblApelido.Location = new System.Drawing.Point(381, 43);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(62, 20);
            this.lblApelido.TabIndex = 2;
            this.lblApelido.Text = "Apelido";
            // 
            // txtApe
            // 
            this.txtApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApe.Location = new System.Drawing.Point(505, 40);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(137, 26);
            this.txtApe.TabIndex = 0;
            // 
            // lblAst
            // 
            this.lblAst.AutoSize = true;
            this.lblAst.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAst.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAst.Location = new System.Drawing.Point(438, 43);
            this.lblAst.Name = "lblAst";
            this.lblAst.Size = new System.Drawing.Size(12, 14);
            this.lblAst.TabIndex = 6;
            this.lblAst.Text = "*";
            this.TTAst.SetToolTip(this.lblAst, "Campo não obrigatorio");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(145, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "*";
            this.TTAst.SetToolTip(this.label2, "Campo não obrigatorio");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TTAst
            // 
            this.TTAst.Popup += new System.Windows.Forms.PopupEventHandler(this.TTAst_Popup);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCPF.Location = new System.Drawing.Point(382, 96);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPF.Location = new System.Drawing.Point(505, 96);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(137, 22);
            this.txtCPF.TabIndex = 7;
            this.txtCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCPF_MaskInputRejected);
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            this.txtCPF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtCPF_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(197, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkF);
            this.panel1.Controls.Add(this.checkM);
            this.panel1.Location = new System.Drawing.Point(320, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 23);
            this.panel1.TabIndex = 8;
            // 
            // checkM
            // 
            this.checkM.AutoSize = true;
            this.checkM.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.checkM.Location = new System.Drawing.Point(4, 5);
            this.checkM.Name = "checkM";
            this.checkM.Size = new System.Drawing.Size(81, 18);
            this.checkM.TabIndex = 0;
            this.checkM.TabStop = true;
            this.checkM.Text = "Masculino";
            this.checkM.UseVisualStyleBackColor = true;
            // 
            // checkF
            // 
            this.checkF.AutoSize = true;
            this.checkF.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.checkF.Location = new System.Drawing.Point(102, 5);
            this.checkF.Name = "checkF";
            this.checkF.Size = new System.Drawing.Size(76, 18);
            this.checkF.TabIndex = 1;
            this.checkF.TabStop = true;
            this.checkF.Text = "Feminino";
            this.checkF.UseVisualStyleBackColor = true;
            // 
            // addPartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.txtSobre);
            this.Controls.Add(this.txtNome);
            this.Name = "addPartControl";
            this.Size = new System.Drawing.Size(892, 317);
            this.Load += new System.EventHandler(this.addPartControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.Label lblAst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip TTAst;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton checkF;
        private System.Windows.Forms.RadioButton checkM;
    }
}
