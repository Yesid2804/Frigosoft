using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Productos.Res
{
    public partial class FormRes : Form
    {
        private Inicio formInicio;
        public FormRes(object inicio)
        {
            this.formInicio = (Inicio)inicio;
            InitializeComponent();
        }

        public FormRes()
        {
            InitializeComponent();
        }
        private void FormRes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //formInicio.AbrirFormPanel(new FormProductos());
        }
    }
}
