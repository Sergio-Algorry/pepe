using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pepe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int pepe = Convert.ToInt32(txtNumero.Text);

                if (pepe > 10)
                {
                    lblIndicacion.Text = "El numero ingresado ES mayor que 10";
                }
                else
                {
                    lblIndicacion.Text = "El numero ingresado NO mayor que 10";
                }
            }
            catch (Exception)
            {
                lblIndicacion.Text = "El dato ingresado no es correcto";
            }
        }
    }
}
