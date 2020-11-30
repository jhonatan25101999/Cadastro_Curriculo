namespace WindowsFormsApp5
{
    partial class frmCurriculo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtObjetivoProfissional = new System.Windows.Forms.TextBox();
            this.lblObjetivoProfissional = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFormacao = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblExperienciaProfissional = new System.Windows.Forms.Label();
            this.txtExperienciaProfissional = new System.Windows.Forms.TextBox();
            this.lblCursosExtra = new System.Windows.Forms.Label();
            this.txtCursosExtra = new System.Windows.Forms.TextBox();
            this.cboFormacao = new System.Windows.Forms.ComboBox();
            this.cboAnoConclusao = new System.Windows.Forms.ComboBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLinguagemdoDominio = new System.Windows.Forms.Label();
            this.lblSistemasOperacionais = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtNasc = new System.Windows.Forms.TextBox();
            this.cboDispensa = new System.Windows.Forms.ComboBox();
            this.lbldtnasc = new System.Windows.Forms.Label();
            this.cboCsharp = new System.Windows.Forms.ComboBox();
            this.cboLinux = new System.Windows.Forms.ComboBox();
            this.cboJavaScript = new System.Windows.Forms.ComboBox();
            this.cboPython = new System.Windows.Forms.ComboBox();
            this.cboWindows = new System.Windows.Forms.ComboBox();
            this.cboMacOs = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.ptxAvatar = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.ptxEmail = new System.Windows.Forms.PictureBox();
            this.ptxContato = new System.Windows.Forms.PictureBox();
            this.ptxLocalizacao = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxLocalizacao)).BeginInit();
            this.SuspendLayout();
            // 
            // txtObjetivoProfissional
            // 
            this.txtObjetivoProfissional.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObjetivoProfissional.Location = new System.Drawing.Point(345, 73);
            this.txtObjetivoProfissional.Multiline = true;
            this.txtObjetivoProfissional.Name = "txtObjetivoProfissional";
            this.txtObjetivoProfissional.Size = new System.Drawing.Size(417, 145);
            this.txtObjetivoProfissional.TabIndex = 167;
            // 
            // lblObjetivoProfissional
            // 
            this.lblObjetivoProfissional.AutoSize = true;
            this.lblObjetivoProfissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetivoProfissional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lblObjetivoProfissional.Location = new System.Drawing.Point(340, 45);
            this.lblObjetivoProfissional.Name = "lblObjetivoProfissional";
            this.lblObjetivoProfissional.Size = new System.Drawing.Size(230, 25);
            this.lblObjetivoProfissional.TabIndex = 168;
            this.lblObjetivoProfissional.Text = "Objetivo Profissional";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(295, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 23);
            this.panel1.TabIndex = 169;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblFormacao
            // 
            this.lblFormacao.AutoSize = true;
            this.lblFormacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lblFormacao.Location = new System.Drawing.Point(340, 235);
            this.lblFormacao.Name = "lblFormacao";
            this.lblFormacao.Size = new System.Drawing.Size(116, 25);
            this.lblFormacao.TabIndex = 170;
            this.lblFormacao.Text = "Formação";
            this.lblFormacao.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(295, 731);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 18);
            this.panel3.TabIndex = 172;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(812, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(22, 708);
            this.panel4.TabIndex = 173;
            // 
            // lblExperienciaProfissional
            // 
            this.lblExperienciaProfissional.AutoSize = true;
            this.lblExperienciaProfissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperienciaProfissional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lblExperienciaProfissional.Location = new System.Drawing.Point(340, 307);
            this.lblExperienciaProfissional.Name = "lblExperienciaProfissional";
            this.lblExperienciaProfissional.Size = new System.Drawing.Size(267, 25);
            this.lblExperienciaProfissional.TabIndex = 175;
            this.lblExperienciaProfissional.Text = "Experiência Profissional";
            // 
            // txtExperienciaProfissional
            // 
            this.txtExperienciaProfissional.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExperienciaProfissional.Location = new System.Drawing.Point(345, 335);
            this.txtExperienciaProfissional.Multiline = true;
            this.txtExperienciaProfissional.Name = "txtExperienciaProfissional";
            this.txtExperienciaProfissional.Size = new System.Drawing.Size(417, 145);
            this.txtExperienciaProfissional.TabIndex = 176;
            this.txtExperienciaProfissional.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lblCursosExtra
            // 
            this.lblCursosExtra.AutoSize = true;
            this.lblCursosExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursosExtra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.lblCursosExtra.Location = new System.Drawing.Point(340, 494);
            this.lblCursosExtra.Name = "lblCursosExtra";
            this.lblCursosExtra.Size = new System.Drawing.Size(272, 25);
            this.lblCursosExtra.TabIndex = 177;
            this.lblCursosExtra.Text = "Cursos Extracurriculares";
            // 
            // txtCursosExtra
            // 
            this.txtCursosExtra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCursosExtra.Location = new System.Drawing.Point(345, 522);
            this.txtCursosExtra.Multiline = true;
            this.txtCursosExtra.Name = "txtCursosExtra";
            this.txtCursosExtra.Size = new System.Drawing.Size(417, 145);
            this.txtCursosExtra.TabIndex = 178;
            // 
            // cboFormacao
            // 
            this.cboFormacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormacao.FormattingEnabled = true;
            this.cboFormacao.Items.AddRange(new object[] {
            "Análise e Desenvolvimento de Sistemas",
            "Ciência da Computação",
            "Gestão de Tecnologia da Informação",
            "Segurança da Informação"});
            this.cboFormacao.Location = new System.Drawing.Point(345, 263);
            this.cboFormacao.Name = "cboFormacao";
            this.cboFormacao.Size = new System.Drawing.Size(280, 24);
            this.cboFormacao.TabIndex = 179;
            this.cboFormacao.Text = "Curso";
            // 
            // cboAnoConclusao
            // 
            this.cboAnoConclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAnoConclusao.FormattingEnabled = true;
            this.cboAnoConclusao.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            ""});
            this.cboAnoConclusao.Location = new System.Drawing.Point(641, 263);
            this.cboAnoConclusao.Name = "cboAnoConclusao";
            this.cboAnoConclusao.Size = new System.Drawing.Size(121, 24);
            this.cboAnoConclusao.TabIndex = 180;
            this.cboAnoConclusao.Text = "Ano de Conclusão";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtNomeCompleto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCompleto.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNomeCompleto.Location = new System.Drawing.Point(20, 126);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(255, 22);
            this.txtNomeCompleto.TabIndex = 15;
            this.txtNomeCompleto.Text = "Nome Completo";
            this.txtNomeCompleto.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(39, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "C#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(30, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Python";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(21, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "JavaScript";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(21, 661);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Windows";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(30, 688);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 167;
            this.label6.Text = "Linux";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(26, 715);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 168;
            this.label7.Text = "MacOS";
            // 
            // lblLinguagemdoDominio
            // 
            this.lblLinguagemdoDominio.AutoSize = true;
            this.lblLinguagemdoDominio.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinguagemdoDominio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLinguagemdoDominio.Location = new System.Drawing.Point(46, 492);
            this.lblLinguagemdoDominio.Name = "lblLinguagemdoDominio";
            this.lblLinguagemdoDominio.Size = new System.Drawing.Size(215, 21);
            this.lblLinguagemdoDominio.TabIndex = 178;
            this.lblLinguagemdoDominio.Text = "LINGUAGENS DE DOMÍNIO";
            // 
            // lblSistemasOperacionais
            // 
            this.lblSistemasOperacionais.AutoSize = true;
            this.lblSistemasOperacionais.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemasOperacionais.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSistemasOperacionais.Location = new System.Drawing.Point(46, 622);
            this.lblSistemasOperacionais.Name = "lblSistemasOperacionais";
            this.lblSistemasOperacionais.Size = new System.Drawing.Size(207, 21);
            this.lblSistemasOperacionais.TabIndex = 179;
            this.lblSistemasOperacionais.Text = "SISTEMAS OPERACIONAIS";
            // 
            // cboSexo
            // 
            this.cboSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.cboSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cboSexo.ForeColor = System.Drawing.SystemColors.Window;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(150, 16);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(114, 24);
            this.cboSexo.TabIndex = 180;
            this.cboSexo.Text = "Sexo";
            this.cboSexo.SelectedIndexChanged += new System.EventHandler(this.sexo_SelectedIndexChanged);
            // 
            // txtNasc
            // 
            this.txtNasc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNasc.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNasc.Location = new System.Drawing.Point(221, 49);
            this.txtNasc.Name = "txtNasc";
            this.txtNasc.Size = new System.Drawing.Size(68, 21);
            this.txtNasc.TabIndex = 183;
            this.txtNasc.TextChanged += new System.EventHandler(this.idade_TextChanged);
            // 
            // cboDispensa
            // 
            this.cboDispensa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.cboDispensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.cboDispensa.ForeColor = System.Drawing.SystemColors.Window;
            this.cboDispensa.FormattingEnabled = true;
            this.cboDispensa.Location = new System.Drawing.Point(126, 84);
            this.cboDispensa.Name = "cboDispensa";
            this.cboDispensa.Size = new System.Drawing.Size(165, 24);
            this.cboDispensa.TabIndex = 184;
            this.cboDispensa.Text = "Situação de dispensa";
            this.cboDispensa.SelectedIndexChanged += new System.EventHandler(this.Dispenca_SelectedIndexChanged);
            // 
            // lbldtnasc
            // 
            this.lbldtnasc.AutoSize = true;
            this.lbldtnasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtnasc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldtnasc.Location = new System.Drawing.Point(131, 52);
            this.lbldtnasc.Name = "lbldtnasc";
            this.lbldtnasc.Size = new System.Drawing.Size(83, 15);
            this.lbldtnasc.TabIndex = 185;
            this.lbldtnasc.Text = "Nascimento";
            this.lbldtnasc.Click += new System.EventHandler(this.label14_Click);
            // 
            // cboCsharp
            // 
            this.cboCsharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cboCsharp.FormattingEnabled = true;
            this.cboCsharp.Items.AddRange(new object[] {
            "Básico ",
            "Intermediário",
            "Avançado"});
            this.cboCsharp.Location = new System.Drawing.Point(103, 526);
            this.cboCsharp.Name = "cboCsharp";
            this.cboCsharp.Size = new System.Drawing.Size(121, 21);
            this.cboCsharp.TabIndex = 186;
            this.cboCsharp.Text = "Nível";
            this.cboCsharp.SelectedIndexChanged += new System.EventHandler(this.cboCsharp_SelectedIndexChanged);
            // 
            // cboLinux
            // 
            this.cboLinux.FormattingEnabled = true;
            this.cboLinux.Items.AddRange(new object[] {
            "Básico",
            "Intermediário",
            "Avançado"});
            this.cboLinux.Location = new System.Drawing.Point(103, 683);
            this.cboLinux.Name = "cboLinux";
            this.cboLinux.Size = new System.Drawing.Size(121, 21);
            this.cboLinux.TabIndex = 187;
            this.cboLinux.Text = "Nível";
            // 
            // cboJavaScript
            // 
            this.cboJavaScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cboJavaScript.FormattingEnabled = true;
            this.cboJavaScript.Items.AddRange(new object[] {
            "Básico",
            "Intermediário",
            "Avançado"});
            this.cboJavaScript.Location = new System.Drawing.Point(103, 580);
            this.cboJavaScript.Name = "cboJavaScript";
            this.cboJavaScript.Size = new System.Drawing.Size(121, 21);
            this.cboJavaScript.TabIndex = 188;
            this.cboJavaScript.Text = "Nível";
            // 
            // cboPython
            // 
            this.cboPython.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cboPython.FormattingEnabled = true;
            this.cboPython.Items.AddRange(new object[] {
            "Básico",
            "Intermediário",
            "Avançado"});
            this.cboPython.Location = new System.Drawing.Point(103, 553);
            this.cboPython.Name = "cboPython";
            this.cboPython.Size = new System.Drawing.Size(121, 21);
            this.cboPython.TabIndex = 189;
            this.cboPython.Text = "Nível";
            // 
            // cboWindows
            // 
            this.cboWindows.FormattingEnabled = true;
            this.cboWindows.Items.AddRange(new object[] {
            "Básico",
            "Intermediário",
            "Avançado"});
            this.cboWindows.Location = new System.Drawing.Point(103, 656);
            this.cboWindows.Name = "cboWindows";
            this.cboWindows.Size = new System.Drawing.Size(121, 21);
            this.cboWindows.TabIndex = 190;
            this.cboWindows.Text = "Nível";
            // 
            // cboMacOs
            // 
            this.cboMacOs.FormattingEnabled = true;
            this.cboMacOs.Items.AddRange(new object[] {
            "Básico",
            "Intermediário",
            "Avançado"});
            this.cboMacOs.Location = new System.Drawing.Point(103, 710);
            this.cboMacOs.Name = "cboMacOs";
            this.cboMacOs.Size = new System.Drawing.Size(121, 21);
            this.cboMacOs.TabIndex = 191;
            this.cboMacOs.Text = "Nível";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.txtCpf);
            this.panel2.Controls.Add(this.cboEstado);
            this.panel2.Controls.Add(this.mtbTelefone);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.mtbCep);
            this.panel2.Controls.Add(this.txtEndereco);
            this.panel2.Controls.Add(this.cboMacOs);
            this.panel2.Controls.Add(this.cboWindows);
            this.panel2.Controls.Add(this.cboPython);
            this.panel2.Controls.Add(this.cboJavaScript);
            this.panel2.Controls.Add(this.cboLinux);
            this.panel2.Controls.Add(this.cboCsharp);
            this.panel2.Controls.Add(this.lbldtnasc);
            this.panel2.Controls.Add(this.cboDispensa);
            this.panel2.Controls.Add(this.txtNasc);
            this.panel2.Controls.Add(this.ptxAvatar);
            this.panel2.Controls.Add(this.cboSexo);
            this.panel2.Controls.Add(this.lblSistemasOperacionais);
            this.panel2.Controls.Add(this.lblLinguagemdoDominio);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNomeCompleto);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.ptxEmail);
            this.panel2.Controls.Add(this.ptxContato);
            this.panel2.Controls.Add(this.ptxLocalizacao);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 749);
            this.panel2.TabIndex = 166;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cboEstado
            // 
            this.cboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.cboEstado.ForeColor = System.Drawing.SystemColors.Window;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "São Paulo"});
            this.cboEstado.Location = new System.Drawing.Point(87, 349);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(117, 21);
            this.cboEstado.TabIndex = 198;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.mtbTelefone.ForeColor = System.Drawing.SystemColors.Window;
            this.mtbTelefone.HideSelection = false;
            this.mtbTelefone.Location = new System.Drawing.Point(98, 221);
            this.mtbTelefone.Mask = "00000-9999";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(93, 20);
            this.mtbTelefone.TabIndex = 197;
            this.mtbTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 196;
            this.label9.Text = "ex. 12345-678";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 195;
            this.label8.Text = "ex. 97898-9856";
            // 
            // mtbCep
            // 
            this.mtbCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.mtbCep.ForeColor = System.Drawing.SystemColors.Window;
            this.mtbCep.HideSelection = false;
            this.mtbCep.Location = new System.Drawing.Point(98, 307);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(91, 20);
            this.mtbCep.TabIndex = 194;
            this.mtbCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtEndereco
            // 
            this.txtEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtEndereco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEndereco.Location = new System.Drawing.Point(58, 379);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(173, 22);
            this.txtEndereco.TabIndex = 192;
            this.txtEndereco.Text = "Bairro";
            // 
            // ptxAvatar
            // 
            this.ptxAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptxAvatar.Location = new System.Drawing.Point(7, 12);
            this.ptxAvatar.Name = "ptxAvatar";
            this.ptxAvatar.Size = new System.Drawing.Size(113, 96);
            this.ptxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptxAvatar.TabIndex = 182;
            this.ptxAvatar.TabStop = false;
            this.ptxAvatar.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(20, 448);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 22);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "E-mail";
            // 
            // ptxEmail
            // 
            this.ptxEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptxEmail.Location = new System.Drawing.Point(132, 419);
            this.ptxEmail.Name = "ptxEmail";
            this.ptxEmail.Size = new System.Drawing.Size(26, 23);
            this.ptxEmail.TabIndex = 12;
            this.ptxEmail.TabStop = false;
            // 
            // ptxContato
            // 
            this.ptxContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptxContato.Location = new System.Drawing.Point(132, 190);
            this.ptxContato.Name = "ptxContato";
            this.ptxContato.Size = new System.Drawing.Size(26, 25);
            this.ptxContato.TabIndex = 10;
            this.ptxContato.TabStop = false;
            this.ptxContato.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ptxLocalizacao
            // 
            this.ptxLocalizacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptxLocalizacao.Location = new System.Drawing.Point(132, 279);
            this.ptxLocalizacao.Name = "ptxLocalizacao";
            this.ptxLocalizacao.Size = new System.Drawing.Size(26, 25);
            this.ptxLocalizacao.TabIndex = 8;
            this.ptxLocalizacao.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalvar.Location = new System.Drawing.Point(675, 683);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 31);
            this.btnSalvar.TabIndex = 181;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.txtCpf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCpf.Location = new System.Drawing.Point(20, 159);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(255, 22);
            this.txtCpf.TabIndex = 199;
            this.txtCpf.Text = "Cpf";
            // 
            // frmCurriculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(834, 749);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cboAnoConclusao);
            this.Controls.Add(this.cboFormacao);
            this.Controls.Add(this.txtCursosExtra);
            this.Controls.Add(this.lblCursosExtra);
            this.Controls.Add(this.txtExperienciaProfissional);
            this.Controls.Add(this.lblExperienciaProfissional);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblFormacao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblObjetivoProfissional);
            this.Controls.Add(this.txtObjetivoProfissional);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "frmCurriculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxLocalizacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtObjetivoProfissional;
        private System.Windows.Forms.Label lblObjetivoProfissional;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFormacao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblExperienciaProfissional;
        private System.Windows.Forms.TextBox txtExperienciaProfissional;
        private System.Windows.Forms.Label lblCursosExtra;
        private System.Windows.Forms.TextBox txtCursosExtra;
        private System.Windows.Forms.ComboBox cboFormacao;
        private System.Windows.Forms.ComboBox cboAnoConclusao;
        private System.Windows.Forms.PictureBox ptxLocalizacao;
        private System.Windows.Forms.PictureBox ptxContato;
        private System.Windows.Forms.PictureBox ptxEmail;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLinguagemdoDominio;
        private System.Windows.Forms.Label lblSistemasOperacionais;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtNasc;
        private System.Windows.Forms.ComboBox cboDispensa;
        private System.Windows.Forms.Label lbldtnasc;
        private System.Windows.Forms.ComboBox cboCsharp;
        private System.Windows.Forms.ComboBox cboLinux;
        private System.Windows.Forms.ComboBox cboJavaScript;
        private System.Windows.Forms.ComboBox cboPython;
        private System.Windows.Forms.ComboBox cboWindows;
        private System.Windows.Forms.ComboBox cboMacOs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptxAvatar;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCpf;
    }
}

