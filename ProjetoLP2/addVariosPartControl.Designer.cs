namespace ProjetoLP2
{
    partial class addVariosPartControl
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
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.btnSim = new System.Windows.Forms.Button();
            this.btnNao = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPers = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPersonagem = new System.Windows.Forms.Label();
            this.btnConf = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.lblAtual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTexto1
            // 
            this.lblTexto1.AutoSize = true;
            this.lblTexto1.Location = new System.Drawing.Point(346, 180);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(143, 13);
            this.lblTexto1.TabIndex = 0;
            this.lblTexto1.Text = "Torneio criado com sucesso!";
            this.lblTexto1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTexto2
            // 
            this.lblTexto2.AutoSize = true;
            this.lblTexto2.Location = new System.Drawing.Point(333, 213);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(175, 13);
            this.lblTexto2.TabIndex = 1;
            this.lblTexto2.Text = " Deseja registrar os usuarios agora?";
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(333, 266);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(75, 23);
            this.btnSim.TabIndex = 2;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnNao
            // 
            this.btnNao.Location = new System.Drawing.Point(433, 266);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(75, 23);
            this.btnNao.TabIndex = 3;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = true;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(370, 157);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtPers
            // 
            this.txtPers.Location = new System.Drawing.Point(370, 213);
            this.txtPers.Name = "txtPers";
            this.txtPers.Size = new System.Drawing.Size(100, 20);
            this.txtPers.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(284, 164);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // lblPersonagem
            // 
            this.lblPersonagem.AutoSize = true;
            this.lblPersonagem.Location = new System.Drawing.Point(273, 213);
            this.lblPersonagem.Name = "lblPersonagem";
            this.lblPersonagem.Size = new System.Drawing.Size(66, 13);
            this.lblPersonagem.TabIndex = 6;
            this.lblPersonagem.Text = "Personagem";
            // 
            // btnConf
            // 
            this.btnConf.Location = new System.Drawing.Point(333, 266);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(75, 23);
            this.btnConf.TabIndex = 7;
            this.btnConf.Text = "Confirmar";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(433, 266);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 8;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // lblAtual
            // 
            this.lblAtual.AutoSize = true;
            this.lblAtual.Location = new System.Drawing.Point(508, 107);
            this.lblAtual.Name = "lblAtual";
            this.lblAtual.Size = new System.Drawing.Size(0, 13);
            this.lblAtual.TabIndex = 9;
            // 
            // addVariosPartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAtual);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.lblPersonagem);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtPers);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.lblTexto2);
            this.Controls.Add(this.lblTexto1);
            this.Name = "addVariosPartControl";
            this.Size = new System.Drawing.Size(864, 451);
            this.Load += new System.EventHandler(this.addVariosPartControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.Label lblTexto2;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPers;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPersonagem;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Label lblAtual;
    }
}
