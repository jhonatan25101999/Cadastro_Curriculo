namespace WindowsFormsApp5
{
    partial class frmDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ptxEmpresasParceiras = new System.Windows.Forms.PictureBox();
            this.ptxDashboard = new System.Windows.Forms.PictureBox();
            this.lklblQuemSomos = new System.Windows.Forms.LinkLabel();
            this.lkblContato = new System.Windows.Forms.LinkLabel();
            this.lklblCurriculo = new System.Windows.Forms.LinkLabel();
            this.ptxSomos = new System.Windows.Forms.PictureBox();
            this.ptxContato = new System.Windows.Forms.PictureBox();
            this.ptxCurriculo = new System.Windows.Forms.PictureBox();
            this.lblDashBoard = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ptxBanner = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxEmpresasParceiras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxSomos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxCurriculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 26;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.ptxEmpresasParceiras);
            this.panel2.Controls.Add(this.ptxDashboard);
            this.panel2.Controls.Add(this.lklblQuemSomos);
            this.panel2.Controls.Add(this.lkblContato);
            this.panel2.Controls.Add(this.lklblCurriculo);
            this.panel2.Controls.Add(this.ptxSomos);
            this.panel2.Controls.Add(this.ptxContato);
            this.panel2.Controls.Add(this.ptxCurriculo);
            this.panel2.Controls.Add(this.lblDashBoard);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 521);
            this.panel2.TabIndex = 167;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(65, 238);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(157, 19);
            this.linkLabel1.TabIndex = 39;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Empresas Parceiras";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // ptxEmpresasParceiras
            // 
            this.ptxEmpresasParceiras.Location = new System.Drawing.Point(12, 229);
            this.ptxEmpresasParceiras.Name = "ptxEmpresasParceiras";
            this.ptxEmpresasParceiras.Size = new System.Drawing.Size(38, 28);
            this.ptxEmpresasParceiras.TabIndex = 38;
            this.ptxEmpresasParceiras.TabStop = false;
            this.ptxEmpresasParceiras.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // ptxDashboard
            // 
            this.ptxDashboard.Location = new System.Drawing.Point(12, 12);
            this.ptxDashboard.Name = "ptxDashboard";
            this.ptxDashboard.Size = new System.Drawing.Size(38, 32);
            this.ptxDashboard.TabIndex = 37;
            this.ptxDashboard.TabStop = false;
            // 
            // lklblQuemSomos
            // 
            this.lklblQuemSomos.ActiveLinkColor = System.Drawing.Color.White;
            this.lklblQuemSomos.AutoSize = true;
            this.lklblQuemSomos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lklblQuemSomos.LinkColor = System.Drawing.Color.White;
            this.lklblQuemSomos.Location = new System.Drawing.Point(65, 340);
            this.lklblQuemSomos.Name = "lklblQuemSomos";
            this.lklblQuemSomos.Size = new System.Drawing.Size(112, 19);
            this.lklblQuemSomos.TabIndex = 36;
            this.lklblQuemSomos.TabStop = true;
            this.lklblQuemSomos.Text = "Quem Somos";
            this.lklblQuemSomos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // lkblContato
            // 
            this.lkblContato.ActiveLinkColor = System.Drawing.Color.White;
            this.lkblContato.AutoSize = true;
            this.lkblContato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lkblContato.LinkColor = System.Drawing.Color.White;
            this.lkblContato.Location = new System.Drawing.Point(65, 289);
            this.lkblContato.Name = "lkblContato";
            this.lkblContato.Size = new System.Drawing.Size(70, 19);
            this.lkblContato.TabIndex = 35;
            this.lkblContato.TabStop = true;
            this.lkblContato.Text = "Contato";
            this.lkblContato.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkblContato_LinkClicked);
            // 
            // lklblCurriculo
            // 
            this.lklblCurriculo.ActiveLinkColor = System.Drawing.Color.White;
            this.lklblCurriculo.AutoSize = true;
            this.lklblCurriculo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lklblCurriculo.LinkColor = System.Drawing.Color.White;
            this.lklblCurriculo.Location = new System.Drawing.Point(65, 186);
            this.lklblCurriculo.Name = "lklblCurriculo";
            this.lklblCurriculo.Size = new System.Drawing.Size(79, 19);
            this.lklblCurriculo.TabIndex = 34;
            this.lklblCurriculo.TabStop = true;
            this.lklblCurriculo.Text = "Currículo";
            this.lklblCurriculo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ptxSomos
            // 
            this.ptxSomos.Location = new System.Drawing.Point(12, 332);
            this.ptxSomos.Name = "ptxSomos";
            this.ptxSomos.Size = new System.Drawing.Size(38, 27);
            this.ptxSomos.TabIndex = 33;
            this.ptxSomos.TabStop = false;
            this.ptxSomos.Click += new System.EventHandler(this.ptxSomos_Click);
            // 
            // ptxContato
            // 
            this.ptxContato.Location = new System.Drawing.Point(12, 280);
            this.ptxContato.Name = "ptxContato";
            this.ptxContato.Size = new System.Drawing.Size(38, 28);
            this.ptxContato.TabIndex = 32;
            this.ptxContato.TabStop = false;
            this.ptxContato.Click += new System.EventHandler(this.ptxContato_Click);
            // 
            // ptxCurriculo
            // 
            this.ptxCurriculo.Location = new System.Drawing.Point(12, 177);
            this.ptxCurriculo.Name = "ptxCurriculo";
            this.ptxCurriculo.Size = new System.Drawing.Size(38, 28);
            this.ptxCurriculo.TabIndex = 31;
            this.ptxCurriculo.TabStop = false;
            this.ptxCurriculo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDashBoard
            // 
            this.lblDashBoard.AutoSize = true;
            this.lblDashBoard.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashBoard.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDashBoard.Location = new System.Drawing.Point(69, 14);
            this.lblDashBoard.Name = "lblDashBoard";
            this.lblDashBoard.Size = new System.Drawing.Size(69, 32);
            this.lblDashBoard.TabIndex = 27;
            this.lblDashBoard.Text = "ITEC";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(265, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 25);
            this.panel1.TabIndex = 170;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(808, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(22, 496);
            this.panel4.TabIndex = 174;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(265, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 18);
            this.panel3.TabIndex = 175;
            // 
            // ptxBanner
            // 
            this.ptxBanner.Location = new System.Drawing.Point(332, 94);
            this.ptxBanner.Name = "ptxBanner";
            this.ptxBanner.Size = new System.Drawing.Size(402, 336);
            this.ptxBanner.TabIndex = 176;
            this.ptxBanner.TabStop = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(830, 521);
            this.Controls.Add(this.ptxBanner);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxEmpresasParceiras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxSomos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxCurriculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel lklblQuemSomos;
        private System.Windows.Forms.LinkLabel lkblContato;
        private System.Windows.Forms.LinkLabel lklblCurriculo;
        private System.Windows.Forms.PictureBox ptxSomos;
        private System.Windows.Forms.PictureBox ptxContato;
        private System.Windows.Forms.PictureBox ptxCurriculo;
        private System.Windows.Forms.Label lblDashBoard;
        private System.Windows.Forms.PictureBox ptxDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox ptxEmpresasParceiras;
        private System.Windows.Forms.PictureBox ptxBanner;
    }
}