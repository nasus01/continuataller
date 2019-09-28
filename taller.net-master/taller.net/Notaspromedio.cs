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
    public partial class Notaspromedio : Form
    {

        promedionotas promedionotas = new promedionotas();
        public Notaspromedio()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            promedionotas.setnota1(double.Parse(txtnota1.Text));
            promedionotas.setnota2(double.Parse(txtnota2.Text));
            promedionotas.setnota3(double.Parse(txtnota3.Text));
            promedionotas.setnota4(double.Parse(txtnota4.Text));

            lbltotal.Text = promedionotas.resultado().ToString();
            lbltotal.Visible = true;
            txtnota1.Text = "";
            txtnota2.Text = "";
            txtnota3.Text = "";
            txtnota4.Text = "";

            txtnota1.Focus();
            if (promedionotas.resultado() < 2.99)
            {
                MessageBox.Show("deficiente");
            }
            else
            {
              if(promedionotas.resultado()<=3.99)
                {
                    MessageBox.Show("bien");
                }
                else
                {
                    if (promedionotas.resultado() >= 4 && (promedionotas.resultado() <= 5))
                    {
                        MessageBox.Show("Exelente");
                    }
                }
            }





        }
    }
}
