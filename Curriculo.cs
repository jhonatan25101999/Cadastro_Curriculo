using Cadastro.Models;
using Cadastro.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class frmCurriculo : Form
    {
        public frmCurriculo()
        {
            InitializeComponent();
            //ptxAvatar.Load("usuarios.png");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboSexo.Items.Add("Masculino");
            cboSexo.Items.Add("Feminino");

            cboDispensa.Items.Add("Sim");
            cboDispensa.Items.Add("Não");



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void sexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string AvatarSexo;

            AvatarSexo = cboSexo.Text;

            switch (AvatarSexo)
            {
                case "Masculino":
                    //ptxAvatar.Load("Homem.png");
                    break;

                case "Feminino":
                    //ptxAvatar.Load("Mulher.png");
                    break;

            }



        }

        private void idade_SelectedIndexChanged(object sender, EventArgs e)
        {
            int situacao;

            situacao = int.Parse(txtNasc.Text);

            if (situacao >= 18)
            {

                //MessageBox.Show("Maior", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void idade_TextChanged(object sender, EventArgs e)
        {
            if (txtNasc.Text != "")
            {



                if (Convert.ToInt32(txtNasc.Text) >= 18)
                {
                    cboDispensa.Visible = false;

                }

                else
                {
                    cboDispensa.Visible = true;

                }

            }

        }

        private void teste_Click(object sender, EventArgs e)
        {
            frmLogin outroForm = new frmLogin();

            outroForm.ShowDialog();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void picAvatar_Click(object sender, EventArgs e)
        {

        }

        private void Dispenca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtLocal_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboCsharp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                new CurriculumDAO()
                    .save(new Curriculum
                    {
                        Cpf = long.Parse(txtCpf.Text),
                        Dt_nasc = Convert.ToDateTime(txtNasc.Text),
                        Sexo = cboSexo.Text,
                        St_de_dispensa = cboDispensa.Text,
                        Nome_completo = txtNomeCompleto.Text,
                        Telefone = mtbTelefone.Text,
                        Cep = mtbCep.Text,
                        Cidade = cboEstado.Text,
                        Bairro = txtEndereco.Text,
                        Email = txtEmail.Text,
                        Csharp = cboCsharp.Text,
                        Python = cboPython.Text,
                        Javascript = cboJavaScript.Text,
                        Windows = cboWindows.Text,
                        Linux = cboLinux.Text,
                        MacOS = cboMacOs.Text,
                        Objetivo_profissional = txtObjetivoProfissional.Text,
                        Curso = cboFormacao.Text,
                        Ano_de_conclusao = Convert.ToDateTime(cboAnoConclusao.Text),
                        Experiencia_profissional = txtExperienciaProfissional.Text,
                        Cursos_extracurriculares = txtCursosExtra.Text
                    }) ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na gravação do registro " + ex.Message.ToString());
                throw new Exception("Erro na gravação do registro " + ex.Message.ToString());
            }
        }
    }
}
