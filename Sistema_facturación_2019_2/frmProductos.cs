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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void llenarGrid()
        {
            DataTable dt = new DataTable();
            accesoDatos acceso = new accesoDatos();
            dt = acceso.cargarTabla("tblProductos", "");
            dgProductos.DataSource = dt;

            dt = acceso.cargarTabla("tblCategoriaProd", "");
            cboCategoria.DataSource = dt;
            cboCategoria.DisplayMember = "strReferencia";
            cboCategoria.ValueMember = "idCategoria";
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtNombre.Text == "")
            {
                mensajeError.SetError(txtPrecioCompra, "Debe de Ingresar un Valor");
                txtPrecioCompra.Focus();
            }
            else
            {
                mensajeError.SetError(txtNombre, "");
            }
            if (txtPrecioVenta.Text == "")
            {
                mensajeError.SetError(txtPrecioVenta, "Debe de Ingresar un Valor");
                txtPrecioVenta.Focus();
                errorCampos = false;
            }
            else
            {
                mensajeError.SetError(txtPrecioVenta, "");
            }

            if (!esNumerico(txtPrecioCompra.Text))
            {
                mensajeError.SetError(txtPrecioCompra, "Debe ser un valor numerico");
                txtPrecioCompra.Focus();
                return false;
            }

            if (!esNumerico(txtPrecioVenta.Text))
            {
                mensajeError.SetError(txtPrecioVenta, "Debe ser un valor numerico");
                txtPrecioVenta.Focus();
                return false;
            }
            mensajeError.SetError(txtPrecioCompra, "");
            mensajeError.SetError(txtPrecioVenta, "");
            return errorCampos;
        }

        private bool esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void nuevo()
        {
            txtNombre.Text = "";
            txtReferencia.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            cboCategoria.SelectedIndex = 0;
            txtDetalle.Text = "";
            txtForo.Text = "";
            txtNumStock.Text = "";
        }

        public bool guardar()
        {
            Boolean actualizado = false;

            if (validar())
            {
                try
                {
                    accesoDatos acceso = new accesoDatos();
                    string sentencia = $"EXEC creacionProducto '{txtNombre.Text}','{txtReferencia.Text}','{txtPrecioCompra.Text}','{txtPrecioVenta.Text}','{Convert.ToInt32(cboCategoria.SelectedValue)}','{txtDetalle.Text}','{txtForo.Text}','{txtNumStock.Text}','{DateTime.Now.ToString("MM-dd-yyyy")}','{"admin"}'";
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

        public void eliminar()
        {
            accesoDatos acceso = new accesoDatos();
            string sentencia = $"EXEC eliminarProducto '{txtIdProducto.Text}'";
            MessageBox.Show(acceso.ejecutarComando(sentencia));
            nuevo();
            llenarGrid();
        }

        private void dgCellMouse_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int posActual = 0;
                posActual = dgProductos.CurrentRow.Index;
                txtIdProducto.Text = dgProductos[0, posActual].Value.ToString();
                txtNombre.Text = dgProductos[1, posActual].Value.ToString();
                txtReferencia.Text = dgProductos[2, posActual].Value.ToString();
                txtPrecioCompra.Text = dgProductos[3, posActual].Value.ToString();
                txtPrecioVenta.Text = dgProductos[4, posActual].Value.ToString();
                cboCategoria.SelectedIndex = Convert.ToInt16(dgProductos[5, posActual].Value.ToString());
                txtDetalle.Text = dgProductos[6, posActual].Value.ToString();
                txtForo.Text = dgProductos[7, posActual].Value.ToString();
                txtNumStock.Text = dgProductos[8, posActual].Value.ToString();
            }
            catch (Exception ex)
            {
                return;
            }
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
    }
}
