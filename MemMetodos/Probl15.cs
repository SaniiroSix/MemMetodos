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
    public partial class Probl15 : Form
    {
        public Probl15()
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
                venta vent = new venta();
                vent.Show();
                this.Hide();


            }
            if (RButt3.Checked)
            {
                MessageBox.Show("Respuesta correcta");
                this.Hide();
            }
        }

        private void Probl15_Load(object sender, EventArgs e)
        {
            
        }
    }
}
