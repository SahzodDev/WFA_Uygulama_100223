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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        
        

        private void btnForm4Ac_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void btnForm5Ac_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void btnFormplariKapat_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            Form5 form5 = new Form5();
            Form3 form3 = new Form3();

            for (int i = Application.OpenForms.Count - 1; i > 0; i--) 
            {
                Application.OpenForms[i].Close();
            }
        }
    }
}
