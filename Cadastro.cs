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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNascimento_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
               new UsuarioDAO()
                    .save(new Usuario
                    {
                       Nome_usuario = txtUsuario.Text,
                       senha = long.Parse(txtSenha.Text)
                    });
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na gravação do registro " + ex.Message.ToString());
            }

            frmLogin outroForm = new frmLogin();
            outroForm.ShowDialog();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
