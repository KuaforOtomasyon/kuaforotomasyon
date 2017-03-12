using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuaforOtomasyon
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void KGirisYap_Form2_Gecis(object sender, EventArgs e)
        {
            this.Hide();
            Index Anasayfa= new Index();
            Anasayfa.Show();
        }
    }
}
