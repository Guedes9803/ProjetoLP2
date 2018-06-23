namespace ProjetoLP2
{
    partial class frmPrincipal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SideBar = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.participanteBtn = new System.Windows.Forms.Button();
            this.torneioBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fecharBtn = new System.Windows.Forms.Button();
            this.partControl1 = new ProjetoLP2.partControl();
            this.torneiosControl1 = new ProjetoLP2.TorneiosControl();
            this.homeControl1 = new ProjetoLP2.HomeControl();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.SideBar);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.participanteBtn);
            this.panel1.Controls.Add(this.torneioBtn);
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 643);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 118);
            this.panel3.TabIndex = 5;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(159)))));
            this.SideBar.Location = new System.Drawing.Point(0, 120);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(11, 46);
            this.SideBar.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(12, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "     Calendário";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // participanteBtn
            // 
            this.participanteBtn.FlatAppearance.BorderSize = 0;
            this.participanteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.participanteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.participanteBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.participanteBtn.Image = ((System.Drawing.Image)(resources.GetObject("participanteBtn.Image")));
            this.participanteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.participanteBtn.Location = new System.Drawing.Point(12, 308);
            this.participanteBtn.Name = "participanteBtn";
            this.participanteBtn.Size = new System.Drawing.Size(190, 46);
            this.participanteBtn.TabIndex = 3;
            this.participanteBtn.Text = "     Participantes";
            this.participanteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.participanteBtn.UseVisualStyleBackColor = true;
            this.participanteBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // torneioBtn
            // 
            this.torneioBtn.FlatAppearance.BorderSize = 0;
            this.torneioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.torneioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torneioBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.torneioBtn.Image = ((System.Drawing.Image)(resources.GetObject("torneioBtn.Image")));
            this.torneioBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.torneioBtn.Location = new System.Drawing.Point(12, 214);
            this.torneioBtn.Name = "torneioBtn";
            this.torneioBtn.Size = new System.Drawing.Size(190, 46);
            this.torneioBtn.TabIndex = 2;
            this.torneioBtn.Text = "        Torneios ";
            this.torneioBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.torneioBtn.UseVisualStyleBackColor = true;
            this.torneioBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.homeBtn.Image = global::ProjetoLP2.Properties.Resources.home__2_;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(12, 120);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(190, 46);
            this.homeBtn.TabIndex = 2;
            this.homeBtn.Text = "          Home";
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(197, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 24);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.fecharBtn);
            this.panel4.Location = new System.Drawing.Point(197, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(988, 107);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // fecharBtn
            // 
            this.fecharBtn.FlatAppearance.BorderSize = 0;
            this.fecharBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fecharBtn.Image = ((System.Drawing.Image)(resources.GetObject("fecharBtn.Image")));
            this.fecharBtn.Location = new System.Drawing.Point(931, 7);
            this.fecharBtn.Name = "fecharBtn";
            this.fecharBtn.Size = new System.Drawing.Size(37, 35);
            this.fecharBtn.TabIndex = 2;
            this.fecharBtn.UseVisualStyleBackColor = true;
            this.fecharBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // partControl1
            // 
            this.partControl1.Location = new System.Drawing.Point(199, 130);
            this.partControl1.Name = "partControl1";
            this.partControl1.Size = new System.Drawing.Size(988, 510);
            this.partControl1.TabIndex = 6;
            this.partControl1.Load += new System.EventHandler(this.partControl1_Load);
            // 
            // torneiosControl1
            // 
            this.torneiosControl1.Location = new System.Drawing.Point(199, 130);
            this.torneiosControl1.Name = "torneiosControl1";
            this.torneiosControl1.Size = new System.Drawing.Size(984, 513);
            this.torneiosControl1.TabIndex = 5;
            this.torneiosControl1.Load += new System.EventHandler(this.torneiosControl1_Load);
            // 
            // homeControl1
            // 
            this.homeControl1.Location = new System.Drawing.Point(199, 127);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(983, 513);
            this.homeControl1.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 643);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.partControl1);
            this.Controls.Add(this.torneiosControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button torneioBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button participanteBtn;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Button fecharBtn;
        private System.Windows.Forms.Panel panel4;
        private HomeControl homeControl1;
        private TorneiosControl torneiosControl1;
        private partControl partControl1;
        private System.Windows.Forms.Panel panel3;
    }
}

