using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Presentacion.Productos.Res;

namespace Presentacion
{
    public partial class FormProductos : Form
    {
        private  Inicio formInicio;
        public FormProductos(object inicio)
        {
            this.formInicio = (Inicio) inicio;
            this.UseWaitCursor = false;
            InitializeComponent();
            this.UseWaitCursor = false;
        }

        public FormProductos()
        {
            InitializeComponent();
        }


        private void iconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formInicio.AbrirFormPanel(new FormRes());
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.formInicio.CleanFormPanel();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
