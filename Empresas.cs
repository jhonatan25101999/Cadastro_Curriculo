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
    public partial class frmEmpresaParceiras : Form
    {
        public frmEmpresaParceiras()
        {
            InitializeComponent();

            ptxEmpresa1.Load("empresa.png");
            ptxEmpresa2.Load("empresas2.png");
            ptxEmpresa3.Load("empresas3.png");
        }

        private void ptxEmpresa1_Click(object sender, EventArgs e)
        {

        }

        private void lkblTivit_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            // Altere a cor do texto do link, definindo LinkVisited
            // para true.
            lkblCtis.LinkVisited = true;

            // Chame o método Process.Start para abrir o navegador padrão
            // com um URL:
            System.Diagnostics.Process.Start("https://tivit.com/tivit/");
        }

        private void lkblCtis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Altere a cor do texto do link, definindo LinkVisited
            // para true.
            lkblCtis.LinkVisited = true;

            // Chame o método Process.Start para abrir o navegador padrão
            // com um URL:
            System.Diagnostics.Process.Start("https://www.ctis.com.br/ConhecaACTIS");
        }

        private void lkblInterfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            // Altere a cor do texto do link, definindo LinkVisited
            // para true.
            lkblCtis.LinkVisited = true;

            // Chame o método Process.Start para abrir o navegador padrão
            // com um URL:
            System.Diagnostics.Process.Start("https://www.interfile.com.br/?page_id=168");
        }
    }
}
