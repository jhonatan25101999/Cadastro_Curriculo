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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool bAccesso = true;
            string campo_entrar, campo_senha;

            campo_entrar = txtLogin.Text;
            campo_senha = txtSenha.Text;

            Usuario usuario = null;

            try
            {
                 usuario = new UsuarioDAO()
                                .usuario(new Usuario { 
                                            Nome_usuario = txtLogin.Text,
                                            senha = long.Parse(txtSenha.Text)
                                });
            }
            catch (Exception)
            {
                MessageBox.Show("falha ao efetuar login");
            }

            if (usuario != null) {
                AcessarSistema(bAccesso);
            }
            else if (usuario == null)
            {
                AcessarSistema(false);
            }
            else if (campo_entrar == "jhonatan.carvalho" && campo_senha == "itec")
            {
                AcessarSistema(true);
            }
            else if (campo_entrar == "abner.cavalcante" && campo_senha == "itec")
            {
                AcessarSistema(true);
            }
            else if (campo_entrar == "marcos.turci" && campo_senha == "itec")
            {
                AcessarSistema(true);
            }
            else if (campo_entrar == "marcelo.jesus" && campo_senha == "itec")
            {
                AcessarSistema(true);
            }
            else if (campo_entrar == "marcelo.davy" && campo_senha == "itec")
            {
                AcessarSistema(true);
            }
            else if (campo_entrar == "vitor.gomes" && campo_senha == "itec")
            {
                AcessarSistema(true);
            }
            else if (campo_entrar == "bruno.mariano" && campo_senha == "itec")
            {
                AcessarSistema(true);
            }
            else if (campo_entrar == "michel.cavalcante" && campo_senha == "itec")
            {
                AcessarSistema(true);
            }
            else {
                bAccesso = false;
            }
        }

        private void AcessarSistema (bool bAcessar)
        {
            if (bAcessar == true) { 
                frmDashboard outroForm = new frmDashboard();
                outroForm.ShowDialog();
            }
            else 
                MessageBox.Show("Dados incorretos");
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro outroForm = new frmCadastro();
            outroForm.ShowDialog();
        }
    }
    }
