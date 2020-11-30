namespace WindowsFormsApp5
{
    partial class frmQuemSomos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuemSomos));
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.lblItec = new System.Windows.Forms.Label();
            this.lblQuemSomos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptxQuemSomos = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblQuemSomoos = new System.Windows.Forms.Label();
            this.txtQuemSomos = new System.Windows.Forms.TextBox();
            this.txtEquipe = new System.Windows.Forms.TextBox();
            this.lblEquipe = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxQuemSomos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItec
            // 
            this.lblItec.AutoSize = true;
            this.lblItec.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItec.ForeColor = System.Drawing.SystemColors.Control;
            this.lblItec.Location = new System.Drawing.Point(69, 45);
            this.lblItec.Name = "lblItec";
            this.lblItec.Size = new System.Drawing.Size(69, 32);
            this.lblItec.TabIndex = 2;
            this.lblItec.Text = "ITEC";
            this.lblItec.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblQuemSomos
            // 
            this.lblQuemSomos.AutoSize = true;
            this.lblQuemSomos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuemSomos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuemSomos.Location = new System.Drawing.Point(30, 307);
            this.lblQuemSomos.Name = "lblQuemSomos";
            this.lblQuemSomos.Size = new System.Drawing.Size(148, 25);
            this.lblQuemSomos.TabIndex = 4;
            this.lblQuemSomos.Text = "Quem Somos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.ptxQuemSomos);
            this.panel1.Controls.Add(this.lblQuemSomos);
            this.panel1.Controls.Add(this.lblItec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 568);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ptxQuemSomos
            // 
            this.ptxQuemSomos.Location = new System.Drawing.Point(45, 220);
            this.ptxQuemSomos.Name = "ptxQuemSomos";
            this.ptxQuemSomos.Size = new System.Drawing.Size(121, 84);
            this.ptxQuemSomos.TabIndex = 5;
            this.ptxQuemSomos.TabStop = false;
            this.ptxQuemSomos.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(217, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 23);
            this.panel2.TabIndex = 170;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(755, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(22, 545);
            this.panel4.TabIndex = 175;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(217, 550);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 18);
            this.panel3.TabIndex = 176;
            // 
            // lblQuemSomoos
            // 
            this.lblQuemSomoos.AutoSize = true;
            this.lblQuemSomoos.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuemSomoos.ForeColor = System.Drawing.Color.Black;
            this.lblQuemSomoos.Location = new System.Drawing.Point(237, 45);
            this.lblQuemSomoos.Name = "lblQuemSomoos";
            this.lblQuemSomoos.Size = new System.Drawing.Size(160, 25);
            this.lblQuemSomoos.TabIndex = 177;
            this.lblQuemSomoos.Text = "Quem Somos?";
            // 
            // txtQuemSomos
            // 
            this.txtQuemSomos.Enabled = false;
            this.txtQuemSomos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuemSomos.Location = new System.Drawing.Point(242, 73);
            this.txtQuemSomos.Multiline = true;
            this.txtQuemSomos.Name = "txtQuemSomos";
            this.txtQuemSomos.Size = new System.Drawing.Size(458, 143);
            this.txtQuemSomos.TabIndex = 1;
            this.txtQuemSomos.Text = resources.GetString("txtQuemSomos.Text");
            // 
            // txtEquipe
            // 
            this.txtEquipe.Enabled = false;
            this.txtEquipe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipe.Location = new System.Drawing.Point(242, 265);
            this.txtEquipe.Multiline = true;
            this.txtEquipe.Name = "txtEquipe";
            this.txtEquipe.Size = new System.Drawing.Size(458, 259);
            this.txtEquipe.TabIndex = 178;
            this.txtEquipe.Text = resources.GetString("txtEquipe.Text");
            // 
            // lblEquipe
            // 
            this.lblEquipe.AutoSize = true;
            this.lblEquipe.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipe.ForeColor = System.Drawing.Color.Black;
            this.lblEquipe.Location = new System.Drawing.Point(237, 237);
            this.lblEquipe.Name = "lblEquipe";
            this.lblEquipe.Size = new System.Drawing.Size(82, 25);
            this.lblEquipe.TabIndex = 179;
            this.lblEquipe.Text = "Equipe";
            // 
            // frmQuemSomos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(777, 568);
            this.Controls.Add(this.lblEquipe);
            this.Controls.Add(this.txtEquipe);
            this.Controls.Add(this.lblQuemSomoos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtQuemSomos);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmQuemSomos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPaginaMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxQuemSomos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label lblItec;
        private System.Windows.Forms.Label lblQuemSomos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptxQuemSomos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblQuemSomoos;
        private System.Windows.Forms.TextBox txtQuemSomos;
        private System.Windows.Forms.TextBox txtEquipe;
        private System.Windows.Forms.Label lblEquipe;
    }
}