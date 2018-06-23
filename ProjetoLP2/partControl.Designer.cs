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
            this.dtTeste = new System.Windows.Forms.DataGridView();
            this.addPartControl1 = new ProjetoLP2.addPartControl();
            this.btnVerInfo = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtTeste)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriarPart
            // 
            this.btnCriarPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCriarPart.FlatAppearance.BorderSize = 0;
            this.btnCriarPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPart.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnCriarPart.ForeColor = System.Drawing.Color.White;
            this.btnCriarPart.Location = new System.Drawing.Point(421, 429);
            this.btnCriarPart.Name = "btnCriarPart";
            this.btnCriarPart.Size = new System.Drawing.Size(132, 46);
            this.btnCriarPart.TabIndex = 0;
            this.btnCriarPart.Text = "Adicionar Participante";
            this.btnCriarPart.UseVisualStyleBackColor = false;
            this.btnCriarPart.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtTeste
            // 
            this.dtTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTeste.Location = new System.Drawing.Point(40, 56);
            this.dtTeste.Name = "dtTeste";
            this.dtTeste.Size = new System.Drawing.Size(892, 317);
            this.dtTeste.TabIndex = 2;
            // 
            // addPartControl1
            // 
            this.addPartControl1.Location = new System.Drawing.Point(343, 102);
            this.addPartControl1.Name = "addPartControl1";
            this.addPartControl1.Size = new System.Drawing.Size(297, 223);
            this.addPartControl1.TabIndex = 1;
            this.addPartControl1.Load += new System.EventHandler(this.addPartControl1_Load);
            this.addPartControl1.VisibleChanged += new System.EventHandler(this.addPartControl1_VisibleChanged);
            // 
            // btnVerInfo
            // 
            this.btnVerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnVerInfo.FlatAppearance.BorderSize = 0;
            this.btnVerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerInfo.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnVerInfo.ForeColor = System.Drawing.Color.White;
            this.btnVerInfo.Location = new System.Drawing.Point(137, 429);
            this.btnVerInfo.Name = "btnVerInfo";
            this.btnVerInfo.Size = new System.Drawing.Size(132, 46);
            this.btnVerInfo.TabIndex = 0;
            this.btnVerInfo.Text = "Ver Informações";
            this.btnVerInfo.UseVisualStyleBackColor = false;
            this.btnVerInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Roboto", 12F);
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(691, 429);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(132, 46);
            this.btnDeletar.TabIndex = 0;
            this.btnDeletar.Text = "Deletar Participante";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.button1_Click);
            // 
            // partControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addPartControl1);
            this.Controls.Add(this.btnVerInfo);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCriarPart);
            this.Controls.Add(this.dtTeste);
            this.Name = "partControl";
            this.Size = new System.Drawing.Size(984, 513);
            this.Load += new System.EventHandler(this.partControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTeste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarPart;
        private addPartControl addPartControl1;
        private System.Windows.Forms.DataGridView dtTeste;
        private System.Windows.Forms.Button btnVerInfo;
        private System.Windows.Forms.Button btnDeletar;
    }
}
