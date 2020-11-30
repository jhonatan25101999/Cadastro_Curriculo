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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();

            //Imagens ícones

            //ptxDashboard.Load("dashboard.png");
            //ptxCurriculo.Load("curriculo.png");
            //ptxEmpresasParceiras.Load("empresas.png");
            //ptxContato.Load("contato.png");
            //ptxSomos.Load("somos.png");
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Redirecionar
            frmCurriculo outroForm = new frmCurriculo();
            outroForm.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //ptxBanner.Load("banner2.png");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionar
            frmCurriculo outroForm = new frmCurriculo();
            outroForm.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionar
            frmQuemSomos outroForm = new frmQuemSomos();
            outroForm.ShowDialog();
        }

        private void lkblContato_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionar
            frmContato outroForm = new frmContato();
            outroForm.ShowDialog();
        }

        private void ptxSomos_Click(object sender, EventArgs e)
        {
            //Redirecionar
            frmQuemSomos outroForm = new frmQuemSomos();
            outroForm.ShowDialog();
        }

        private void ptxContato_Click(object sender, EventArgs e)
        {
            //Redirecionar
            frmContato outroForm = new frmContato();
            outroForm.ShowDialog();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionar
            frmEmpresaParceiras outroForm = new frmEmpresaParceiras();
            outroForm.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            frmEmpresaParceiras outroForm = new frmEmpresaParceiras();
            outroForm.ShowDialog();
        }
    }
}
