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
    }
}
