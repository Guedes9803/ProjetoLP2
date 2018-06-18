namespace ProjetoLP2
{
    partial class partControl
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
            this.btnCriarPart = new System.Windows.Forms.Button();
            this.addPartControl1 = new ProjetoLP2.addPartControl();
            this.SuspendLayout();
            // 
            // btnCriarPart
            // 
            this.btnCriarPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCriarPart.FlatAppearance.BorderSize = 0;
            this.btnCriarPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPart.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnCriarPart.ForeColor = System.Drawing.Color.White;
            this.btnCriarPart.Location = new System.Drawing.Point(414, 429);
            this.btnCriarPart.Name = "btnCriarPart";
            this.btnCriarPart.Size = new System.Drawing.Size(132, 46);
            this.btnCriarPart.TabIndex = 0;
            this.btnCriarPart.Text = "Adicionar Participante";
            this.btnCriarPart.UseVisualStyleBackColor = false;
            this.btnCriarPart.Click += new System.EventHandler(this.button1_Click);
            // 
            // addPartControl1
            // 
            this.addPartControl1.Location = new System.Drawing.Point(361, 108);
            this.addPartControl1.Name = "addPartControl1";
            this.addPartControl1.Size = new System.Drawing.Size(297, 223);
            this.addPartControl1.TabIndex = 1;
            this.addPartControl1.Load += new System.EventHandler(this.addPartControl1_Load);
            // 
            // partControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addPartControl1);
            this.Controls.Add(this.btnCriarPart);
            this.Name = "partControl";
            this.Size = new System.Drawing.Size(984, 513);
            this.Load += new System.EventHandler(this.partControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarPart;
        private addPartControl addPartControl1;
    }
}
