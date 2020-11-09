using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Ventas
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtBoxCantidad.Text= "0";
        }


        double cantidadTotal = 0; 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //cantidad_1Medio = float.Parse(btn1.Text);

            cantidadTotal = cantidadTotal + 1;


            txtBoxCantidad.Text = cantidadTotal.ToString();


        }

        private void btn1Medio_Click(object sender, EventArgs e)
        {
            cantidadTotal = cantidadTotal + 1.5;


            txtBoxCantidad.Text = cantidadTotal.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            cantidadTotal = cantidadTotal + 2;


            txtBoxCantidad.Text = cantidadTotal.ToString();
        }

        private void txtBoxCantidad_Validated(object sender, EventArgs e)
        {
     
        
        }

        private void txtBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Si deseas, puedes permitir numeros decimales (o float)
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void btnVender_Click(object sender, EventArgs e)
        {
            MessageBox.Show("    Desea Generar Factura?", "", MessageBoxButtons.YesNo);
        }


      
    }
}
