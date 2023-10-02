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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        string bilgiler = string.Empty;
        string cinsiyet = string.Empty;
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (chkKadin.Checked)
            {
                cinsiyet = "Kadın";
            }
            else if (chkErkek.Checked)
            {
                cinsiyet = "Erkek";
            }
            bilgiler = $"{txtAd.Text} {txtSoyad.Text} {cinsiyet} {numYas.Value}";

            lstBilgiler.Items.Add(bilgiler);
        }
        Form8 frm = new Form8();
        private void btnDigerFormaGonder_Click(object sender, EventArgs e)
        {
            foreach (string bilgi in lstBilgiler.Items) 
            {
                frm.BilgiYansit(bilgi);
            }

            frm.Show();
        }
    }
}
