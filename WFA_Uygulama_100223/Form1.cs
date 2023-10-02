using System.ComponentModel;
using System.DirectoryServices;

namespace WFA_Uygulama_100223
{
    public partial class Form1 : Form
    {

        Form2 frm = new Form2();
        public Form1()
        {
            InitializeComponent();


        }


        string kullaniciAdi = "bilgeadam";
        string sifre = "123";
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == kullaniciAdi && txtSifre.Text == sifre)
            {
                frm.Kontrollerim($"Hoþgeldin {txtKullaniciAdi.Text}");
                this.Hide();
                frm.Show();

            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre hatalý.");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}