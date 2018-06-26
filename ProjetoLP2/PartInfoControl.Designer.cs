namespace ProjetoLP2
{
    partial class PartInfoControl
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
            this.dgTorn = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobre = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnDesf = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.cbPers = new System.Windows.Forms.ComboBox();
            this.lblPers = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCamp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTorn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTorn
            // 
            this.dgTorn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTorn.Location = new System.Drawing.Point(456, 55);
            this.dgTorn.Name = "dgTorn";
            this.dgTorn.Size = new System.Drawing.Size(272, 204);
            this.dgTorn.TabIndex = 0;
            this.dgTorn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTorn_CellClick);
            this.dgTorn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTorn_CellContentClick);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(456, 280);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(84, 45);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar Personagem";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(644, 280);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(84, 45);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover Inscrição";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnVoltar.Location = new System.Drawing.Point(33, 36);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNome.Location = new System.Drawing.Point(33, 101);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 14);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(33, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sobrenome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(33, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apelido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(33, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.Location = new System.Drawing.Point(165, 101);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(149, 22);
            this.txtNome.TabIndex = 4;
            // 
            // txtSobre
            // 
            this.txtSobre.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSobre.Location = new System.Drawing.Point(165, 139);
            this.txtSobre.Name = "txtSobre";
            this.txtSobre.ReadOnly = true;
            this.txtSobre.Size = new System.Drawing.Size(149, 22);
            this.txtSobre.TabIndex = 4;
            // 
            // txtApe
            // 
            this.txtApe.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApe.Location = new System.Drawing.Point(165, 181);
            this.txtApe.Name = "txtApe";
            this.txtApe.ReadOnly = true;
            this.txtApe.Size = new System.Drawing.Size(149, 22);
            this.txtApe.TabIndex = 4;
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(33, 271);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(90, 45);
            this.btnAlt.TabIndex = 5;
            this.btnAlt.Text = "Alterar Informações";
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnDesf
            // 
            this.btnDesf.Location = new System.Drawing.Point(165, 271);
            this.btnDesf.Name = "btnDesf";
            this.btnDesf.Size = new System.Drawing.Size(90, 45);
            this.btnDesf.TabIndex = 5;
            this.btnDesf.Text = "Desfazer Alterações";
            this.btnDesf.UseVisualStyleBackColor = true;
            this.btnDesf.Click += new System.EventHandler(this.btnDesf_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(33, 271);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(90, 45);
            this.btnSalva.TabIndex = 5;
            this.btnSalva.Text = "Salvar Alterações";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPF.Location = new System.Drawing.Point(165, 223);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.ReadOnly = true;
            this.txtCPF.Size = new System.Drawing.Size(149, 22);
            this.txtCPF.TabIndex = 6;
            // 
            // cbPers
            // 
            this.cbPers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPers.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbPers.FormattingEnabled = true;
            this.cbPers.Location = new System.Drawing.Point(591, 142);
            this.cbPers.Name = "cbPers";
            this.cbPers.Size = new System.Drawing.Size(121, 22);
            this.cbPers.TabIndex = 7;
            // 
            // lblPers
            // 
            this.lblPers.AutoSize = true;
            this.lblPers.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPers.Location = new System.Drawing.Point(488, 150);
            this.lblPers.Name = "lblPers";
            this.lblPers.Size = new System.Drawing.Size(76, 14);
            this.lblPers.TabIndex = 8;
            this.lblPers.Text = "Personagem";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(456, 280);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 45);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(644, 282);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 43);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCamp
            // 
            this.lblCamp.AutoSize = true;
            this.lblCamp.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCamp.Location = new System.Drawing.Point(461, 30);
            this.lblCamp.Name = "lblCamp";
            this.lblCamp.Size = new System.Drawing.Size(256, 22);
            this.lblCamp.TabIndex = 11;
            this.lblCamp.Text = "Participações em Campeonato";
            // 
            // PartInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCamp);
            this.Controls.Add(this.lblPers);
            this.Controls.Add(this.cbPers);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnDesf);
            this.Controls.Add(this.btnAlt);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.txtSobre);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgTorn);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "PartInfoControl";
            this.Size = new System.Drawing.Size(839, 405);
            this.Load += new System.EventHandler(this.PartInfoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTorn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTorn;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobre;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnDesf;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.ComboBox cbPers;
        private System.Windows.Forms.Label lblPers;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCamp;
    }
}
