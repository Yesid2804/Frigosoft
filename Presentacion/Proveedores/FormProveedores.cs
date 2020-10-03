using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL.Proveedores;
using Entity;
using Microsoft.VisualBasic;

namespace Presentacion
{
    public partial class FormProveedores : Form
    {
        private int n = 0;
        public FormProveedores()
        {
            InitializeComponent();
        }
        private Boolean categoriaRes = false, categoriaCerdo, categoriaPollo;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Boolean verificarChexbox = true;

            this.categoriaRes = checkBoxRes.Checked;
            this.categoriaCerdo = checkBoxCerdo.Checked;
            this.categoriaPollo = checkBoxPollo.Checked;

            if (categoriaRes == true && categoriaCerdo == true && categoriaPollo == true)
            {
                dtgvProveedores.Rows[n].Cells[2].Value = checkBoxRes.Text + "," + checkBoxCerdo.Text + "," + checkBoxPollo.Text;
            }
            else if(categoriaRes == false && categoriaCerdo == false && categoriaPollo == false)
            {
                MessageBox.Show("Ingrese una Categoria");
                verificarChexbox = false;
            }

            if (verificarChexbox == true)
            {
                //Adiciono un nuevo renglon
                //Coloco la Informacion
                int n = dtgvProveedores.Rows.Add();
                dtgvProveedores.Rows[n].Cells[0].Value = txtNombre.Text;
                dtgvProveedores.Rows[n].Cells[1].Value = txtDireccion.Text;
                dtgvProveedores.Rows[n].Cells[3].Value = txtContacto.Text;

                //Limpiar txt
                txtNombre.Text = "";
                txtDireccion.Text = "";
                txtContacto.Text = "";

                checkBoxRes.Checked = false;
                checkBoxCerdo.Checked = false;
                checkBoxPollo.Checked = false;

            }



            if (categoriaRes == true && categoriaCerdo == false && categoriaPollo == false)
            {
                dtgvProveedores.Rows[n].Cells[2].Value = "Res";
            }
            else if (categoriaRes == false && categoriaCerdo == true && categoriaPollo == false)
            {
                dtgvProveedores.Rows[n].Cells[2].Value = "Cerdo";
            }
            else if (categoriaRes == false && categoriaCerdo == false && categoriaPollo == true)
            {
                dtgvProveedores.Rows[n].Cells[2].Value = "Pollo";
            }
            else if (categoriaRes == true && categoriaCerdo == true && categoriaPollo == false)
            {
                dtgvProveedores.Rows[n].Cells[2].Value = "Res,Cerdo";
            }
            else if (categoriaRes == true && categoriaCerdo == false && categoriaPollo == true)
            {
                dtgvProveedores.Rows[n].Cells[2].Value = "Res,Pollo";
            }
            else if (categoriaRes == false && categoriaCerdo == true && categoriaPollo == true)
            {
                dtgvProveedores.Rows[n].Cells[2].Value = "Cerdo,Pollo";
            }

            Proveedor proveedor = new Proveedor(txtNombre.Text);

            ControladorProveedor controlador = new ControladorProveedor();
            if (controlador.addProveedor(proveedor))
            {
                MessageBox.Show("Proveedor guardado");
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }

        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
        private void dtgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dtgvProveedores.Rows.RemoveAt(n);
            }
        }

       
    }
}
