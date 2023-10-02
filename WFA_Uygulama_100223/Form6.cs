using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Uygulama_100223
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("C:\\Users\\Shohzod\\Desktop\\UygulamaDers.txt",true);

            streamWriter.Write(rtxText.Text);

            streamWriter.Close();
        }

        private void btnTextTemizle_Click(object sender, EventArgs e)
        {
            rtxText.Text = string.Empty;
        }

        private void btnDosyadanOku_Click(object sender, EventArgs e)
        {
            StreamReader strReader = new StreamReader("C:\\Users\\Shohzod\\Desktop\\UygulamaDers.txt");

            lblText.Text = strReader.ReadToEnd();

            strReader.Close();
        }

        private void btnLabelTemizle_Click(object sender, EventArgs e)
        {
            lblText.Text = string.Empty;
        }
    }
}
