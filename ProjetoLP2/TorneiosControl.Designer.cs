namespace ProjetoLP2
{
    partial class TorneiosControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TorneiosControl));
            this.button1 = new System.Windows.Forms.Button();
            this.dtTeste = new System.Windows.Forms.DataGridView();
            this.lblTeste = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnTab = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.criarTorneioControl1 = new ProjetoLP2.criarTorneioControl();
            this.addVariosPartControl1 = new ProjetoLP2.addVariosPartControl();
            this.altTorneioControl1 = new ProjetoLP2.altTorneioControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtTeste)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 85);
            this.button1.TabIndex = 1;
            this.button1.Text = "Criar Torneio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtTeste
            // 
            this.dtTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTeste.Location = new System.Drawing.Point(71, 36);
            this.dtTeste.Name = "dtTeste";
            this.dtTeste.Size = new System.Drawing.Size(858, 361);
            this.dtTeste.TabIndex = 2;
            this.dtTeste.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTeste_CellClick);
            this.dtTeste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dtTeste.DoubleClick += new System.EventHandler(this.dtTeste_DoubleClick);
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Location = new System.Drawing.Point(71, 452);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(35, 13);
            this.lblTeste.TabIndex = 4;
            this.lblTeste.Text = "label1";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(396, 403);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(192, 85);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Alterar Informações";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnTab
            // 
            this.btnTab.Location = new System.Drawing.Point(616, 403);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(192, 85);
            this.btnTab.TabIndex = 5;
            this.btnTab.Text = "Gerar Tabela";
            this.btnTab.UseVisualStyleBackColor = true;
            this.btnTab.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(886, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 44);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // criarTorneioControl1
            // 
            this.criarTorneioControl1.Location = new System.Drawing.Point(74, 36);
            this.criarTorneioControl1.Name = "criarTorneioControl1";
            this.criarTorneioControl1.Size = new System.Drawing.Size(858, 361);
            this.criarTorneioControl1.TabIndex = 7;
            this.criarTorneioControl1.Load += new System.EventHandler(this.criarTorneioControl1_Load);
            // 
            // addVariosPartControl1
            // 
            this.addVariosPartControl1.Location = new System.Drawing.Point(71, 36);
            this.addVariosPartControl1.Name = "addVariosPartControl1";
            this.addVariosPartControl1.Size = new System.Drawing.Size(858, 361);
            this.addVariosPartControl1.TabIndex = 8;
            // 
            // altTorneioControl1
            // 
            this.altTorneioControl1.Location = new System.Drawing.Point(71, 36);
            this.altTorneioControl1.Name = "altTorneioControl1";
            this.altTorneioControl1.Size = new System.Drawing.Size(858, 361);
            this.altTorneioControl1.TabIndex = 6;
            this.altTorneioControl1.Load += new System.EventHandler(this.altTorneioControl1_Load);
            // 
            // TorneiosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.criarTorneioControl1);
            this.Controls.Add(this.btnTab);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblTeste);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addVariosPartControl1);
            this.Controls.Add(this.altTorneioControl1);
            this.Controls.Add(this.dtTeste);
            this.Name = "TorneiosControl";
            this.Size = new System.Drawing.Size(984, 513);
            this.Load += new System.EventHandler(this.TorneiosControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTeste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtTeste;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTeste;
        private System.Windows.Forms.Button btnAtualizar;
        private altTorneioControl altTorneioControl1;
        private criarTorneioControl criarTorneioControl1;
        private addVariosPartControl addVariosPartControl1;
        private System.Windows.Forms.Button btnTab;
    }
}
