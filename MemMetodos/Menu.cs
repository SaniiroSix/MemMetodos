using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemMetodos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
       
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Instr instru = new Instr();
            instru.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Principal princi = new Principal();
            princi.Show();
            this.Close();
        }
    }
}
