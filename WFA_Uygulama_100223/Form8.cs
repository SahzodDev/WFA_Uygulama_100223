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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void lstBilgiler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void BilgiYansit(string bilgi)
        {
            lstBilgiler.Items.Add(bilgi);
        }
    }
}
