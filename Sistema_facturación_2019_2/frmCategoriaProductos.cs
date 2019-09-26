using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_facturación_2019_2
{
    public partial class frmCategoriaProductos : Form
    {
        public frmCategoriaProductos()
        {
            InitializeComponent();
        }

        private void llenarGrid()
        {
            DataTable dt = new DataTable();
            accesoDatos acceso = new accesoDatos();
            dt = acceso.cargarTabla("tblCategoriaProd", "");
            dgCategorias.DataSource = dt;
        }

        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtReferencia.Text == "")
            {
                mensajeError.SetError(txtReferencia, "Debe de Ingresar una Referencia");
                txtReferencia.Focus();
            }
            else
            {
                mensajeError.SetError(txtReferencia, "");
            }
            if (txtDescripcion.Text == "")
            {
                mensajeError.SetError(txtDescripcion, "Debe de Ingresar una Descripcion");
                txtDescripcion.Focus();
                errorCampos = false;
            }
            
            mensajeError.SetError(txtReferencia, "");
            return errorCampos;
        }

        
        public bool guardar()
        {
            Boolean actualizado = false;

            if (validar())
            {
                try
                {
                    accesoDatos acceso = new accesoDatos();
                    string sentencia = $"EXEC creacionCategoria '{txtReferencia.Text}','{txtDescripcion.Text}','{DateTime.Now.ToString("MM-dd-yyyy")}','{"admin"}'";
                    MessageBox.Show(acceso.ejecutarComando(sentencia));
                    nuevo();
                    llenarGrid();
                    actualizado = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fallo Insercion: " + ex);
                    actualizado = false;
                }
            }
            return actualizado;
        }

        public void nuevo()
        {
            txtIdCategoria.Text = "";
            txtReferencia.Text = "";
            txtDescripcion.Text = "";
        }

        public void eliminar()
        {
            accesoDatos acceso = new accesoDatos();
            string sentencia = $"EXEC eliminarCategoria '{txtIdCategoria.Text}'";
            MessageBox.Show(acceso.ejecutarComando(sentencia));
            nuevo();
            llenarGrid();
        }

        

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCategoriaProductos_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void dgCellMouse_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int posActual = 0;
                posActual = dgCategorias.CurrentRow.Index;
                txtIdCategoria.Text = dgCategorias[0, posActual].Value.ToString();
                txtReferencia.Text = dgCategorias[1, posActual].Value.ToString();
                txtDescripcion.Text = dgCategorias[2, posActual].Value.ToString();
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
