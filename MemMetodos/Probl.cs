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
    public partial class Probl : Form
    {
        public Probl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(RButt1.Checked)
            {
                venta vent = new venta();
                vent.Show();
                this.Hide();
            }

            if (RButt2.Checked)
            {
                MessageBox.Show("Respuesta correcta");
                this.Hide();
               
                
            }
            if (RButt3.Checked)
            {
                venta vent = new venta();
                vent.Show();
                this.Hide();
            }
        }

        private void Probl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
