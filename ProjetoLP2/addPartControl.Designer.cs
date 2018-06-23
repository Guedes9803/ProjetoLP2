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
            this.txtPers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.btnConf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAst = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TTAst = new System.Windows.Forms.ToolTip(this.components);
            this.lblCPF = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(127, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(137, 26);
            this.txtNome.TabIndex = 0;
            // 
            // txtPers
            // 
            this.txtPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPers.Location = new System.Drawing.Point(127, 91);
            this.txtPers.Name = "txtPers";
            this.txtPers.Size = new System.Drawing.Size(137, 26);
            this.txtPers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(4, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSobrenome.Location = new System.Drawing.Point(4, 94);
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
            this.btnConf.Location = new System.Drawing.Point(153, 269);
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
            this.label5.Location = new System.Drawing.Point(187, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "label2";
            this.label5.Visible = false;
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblApelido.Location = new System.Drawing.Point(3, 149);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(62, 20);
            this.lblApelido.TabIndex = 2;
            this.lblApelido.Text = "Apelido";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(127, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 26);
            this.textBox1.TabIndex = 0;
            // 
            // lblAst
            // 
            this.lblAst.AutoSize = true;
            this.lblAst.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAst.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAst.Location = new System.Drawing.Point(60, 149);
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
            this.label2.Location = new System.Drawing.Point(92, 94);
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
            this.lblCPF.Location = new System.Drawing.Point(4, 202);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.maskedTextBox1.Location = new System.Drawing.Point(127, 202);
            this.maskedTextBox1.Mask = "000,000,000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(137, 22);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // addPartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPers);
            this.Controls.Add(this.txtNome);
            this.Name = "addPartControl";
            this.Size = new System.Drawing.Size(410, 336);
            this.Load += new System.EventHandler(this.addPartControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip TTAst;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}
