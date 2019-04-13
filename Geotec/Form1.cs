using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geotec
{
    public partial class frmGeotec : Form
    {
        public frmGeotec()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string txt = System.IO.File.ReadAllText(@"C:\tecinfo\nome.txt");
            lblNome.Text = txt;

            string txtDes = System.IO.File.ReadAllText(@"C:\tecinfo\desc.txt");
            txtDescricao.Text = txtDes;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Process.Start("https://geotecinformatica.herokuapp.com/");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente fechar essa aplicação?", "Atenção!",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
                );
            if(result == DialogResult.No)
            {

            }
            else
            {
                Close();
            }
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGarantia_Click(object sender, EventArgs e)
        {
            string data = System.IO.File.ReadAllText(@"C:\tecinfo\data.txt");

            DateTime dataAtual = DateTime.Now.Date;
            DateTime outraData = Convert.ToDateTime(data);

            if (dataAtual > outraData || dataAtual == outraData)
            {
                MessageBox.Show("Sua Garantia expirou o prazo!");
            }
            else
            {
                MessageBox.Show(data, "Sua Garantia é valida até o dia!");
            }
        }

        private void btnSite_Click(object sender, EventArgs e)
        {
            Process.Start("https://geotecinformatica.herokuapp.com/");
        }

        private void btnWhatsapp_Click(object sender, EventArgs e)
        {
            Process.Start("https://wa.me/5561995488068?text=Olá%20Geovane%20Carvalho!");
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Process.Start("D:/bkp");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
