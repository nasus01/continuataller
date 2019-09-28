using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller.net
{
    
    public partial class Raizcuadrada : Form
    {
        Raiz raiz = new Raiz();
        public Raizcuadrada()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            raiz.setNumero1(double.Parse(txtnumraiz.Text));
            lbltotal.Text = raiz.calcular().ToString();
            lbltotal.Visible = true;
            txtnumraiz.Text = "";
            txtnumraiz.Focus();

        }
    }
}
