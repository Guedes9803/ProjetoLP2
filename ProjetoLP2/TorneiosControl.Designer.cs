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
            this.btnCriar = new System.Windows.Forms.Button();
            this.dtTeste = new System.Windows.Forms.DataGridView();
            this.btnVerInfo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.criarTorneioControl1 = new ProjetoLP2.criarTorneioControl();
            this.torneioInfoControl1 = new ProjetoLP2.TorneioInfoControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtTeste)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCriar.FlatAppearance.BorderSize = 0;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCriar.Location = new System.Drawing.Point(160, 403);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(192, 85);
            this.btnCriar.TabIndex = 1;
            this.btnCriar.Text = "Criar Torneio";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtTeste
            // 
            this.dtTeste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTeste.Location = new System.Drawing.Point(65, 24);
            this.dtTeste.Name = "dtTeste";
            this.dtTeste.Size = new System.Drawing.Size(864, 373);
            this.dtTeste.TabIndex = 2;
            this.dtTeste.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTeste_CellClick);
            this.dtTeste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dtTeste.DoubleClick += new System.EventHandler(this.dtTeste_DoubleClick);
            // 
            // btnVerInfo
            // 
            this.btnVerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnVerInfo.FlatAppearance.BorderSize = 0;
            this.btnVerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerInfo.ForeColor = System.Drawing.Color.White;
            this.btnVerInfo.Location = new System.Drawing.Point(396, 403);
            this.btnVerInfo.Name = "btnVerInfo";
            this.btnVerInfo.Size = new System.Drawing.Size(192, 85);
            this.btnVerInfo.TabIndex = 5;
            this.btnVerInfo.Text = "Ver Informações";
            this.btnVerInfo.UseVisualStyleBackColor = false;
            this.btnVerInfo.Click += new System.EventHandler(this.btnAtualizar_Click);
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
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(644, 403);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(192, 85);
            this.btnDeletar.TabIndex = 5;
            this.btnDeletar.Text = "Deletar Torneio";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // criarTorneioControl1
            // 
            this.criarTorneioControl1.Location = new System.Drawing.Point(65, 24);
            this.criarTorneioControl1.Name = "criarTorneioControl1";
            this.criarTorneioControl1.Size = new System.Drawing.Size(864, 464);
            this.criarTorneioControl1.TabIndex = 9;
            this.criarTorneioControl1.Visible = false;
            this.criarTorneioControl1.Load += new System.EventHandler(this.criarTorneioControl1_Load_1);
            this.criarTorneioControl1.VisibleChanged += new System.EventHandler(this.criarTorneioControl1_VisibleChanged);
            // 
            // torneioInfoControl1
            // 
            this.torneioInfoControl1.Location = new System.Drawing.Point(65, 10);
            this.torneioInfoControl1.Name = "torneioInfoControl1";
            this.torneioInfoControl1.Size = new System.Drawing.Size(864, 478);
            this.torneioInfoControl1.TabIndex = 11;
            // 
            // TorneiosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnVerInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.dtTeste);
            this.Controls.Add(this.criarTorneioControl1);
            this.Controls.Add(this.torneioInfoControl1);
            this.Name = "TorneiosControl";
            this.Size = new System.Drawing.Size(984, 513);
            this.Load += new System.EventHandler(this.TorneiosControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTeste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.DataGridView dtTeste;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVerInfo;
        private criarTorneioControl criarTorneioControl1;
        private TorneioInfoControl torneioInfoControl1;
        private System.Windows.Forms.Button btnDeletar;
    }
}
