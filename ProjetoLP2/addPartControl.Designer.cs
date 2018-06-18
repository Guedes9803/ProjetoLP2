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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPersonagem = new System.Windows.Forms.Label();
            this.btnConf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtNome.Location = new System.Drawing.Point(127, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(137, 27);
            this.txtNome.TabIndex = 0;
            // 
            // txtPers
            // 
            this.txtPers.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPers.Location = new System.Drawing.Point(127, 91);
            this.txtPers.Name = "txtPers";
            this.txtPers.Size = new System.Drawing.Size(137, 27);
            this.txtPers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F);
            this.label1.Location = new System.Drawing.Point(4, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // lblPersonagem
            // 
            this.lblPersonagem.AutoSize = true;
            this.lblPersonagem.Font = new System.Drawing.Font("Roboto", 12F);
            this.lblPersonagem.Location = new System.Drawing.Point(4, 94);
            this.lblPersonagem.Name = "lblPersonagem";
            this.lblPersonagem.Size = new System.Drawing.Size(98, 19);
            this.lblPersonagem.TabIndex = 2;
            this.lblPersonagem.Text = "Personagem";
            // 
            // btnConf
            // 
            this.btnConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnConf.FlatAppearance.BorderSize = 0;
            this.btnConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConf.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnConf.ForeColor = System.Drawing.Color.White;
            this.btnConf.Location = new System.Drawing.Point(101, 184);
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
            this.label5.Location = new System.Drawing.Point(136, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label2";
            // 
            // addPartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.lblPersonagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPers);
            this.Controls.Add(this.txtNome);
            this.Name = "addPartControl";
            this.Size = new System.Drawing.Size(301, 273);
            this.Load += new System.EventHandler(this.addPartControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPersonagem;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Label label5;
    }
}
