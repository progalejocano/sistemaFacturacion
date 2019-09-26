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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void llenarGrid()
        {
            DataTable dt = new DataTable();
            accesoDatos acceso = new accesoDatos();
            dt = acceso.cargarTabla("tblClientes", "");
            dgClientes.DataSource = dt;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
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
                mensajeError.SetError(txtNombre, "Debe de Ingresar un Nombre");
                txtNombre.Focus();
            }
            else
            {
                mensajeError.SetError(txtNombre, "");
            }
            if (txtDocumento.Text == "")
            {
                mensajeError.SetError(txtDocumento, "Debe de Ingresar un Documento");
                txtDocumento.Focus();
                errorCampos = false;
            }
            else
            {
                mensajeError.SetError(txtDocumento, "");
            }

            if (!esNumerico(txtDocumento.Text))
            {
                mensajeError.SetError(txtDocumento, "Debe ser un valor numerico");
                txtDocumento.Focus();
                return false;
            }
            mensajeError.SetError(txtDocumento, "");
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

        public bool guardar()
        {
            Boolean actualizado = false;

            if (validar())
            {
                try
                {
                    accesoDatos acceso = new accesoDatos();
                    string sentencia = $"EXEC creacionCliente '{txtNombre.Text}','{txtDocumento.Text}','{txtDireccion.Text}','{txtTelefono.Text}','{txtEmail.Text}','{DateTime.Now.ToString("MM-dd-yyyy")}','{"admin"}'";
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
            txtIdCliente.Text = "";
            txtNombre.Text = "";
            txtDocumento.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }

        public void eliminar()
        {
            accesoDatos acceso = new accesoDatos();
            string sentencia = $"EXEC eliminarCliente '{txtIdCliente.Text}'";
            MessageBox.Show(acceso.ejecutarComando(sentencia));
            nuevo();
            llenarGrid();
        }

        private void dgCellMouse_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int posActual = 0;
                posActual = dgClientes.CurrentRow.Index;
                txtIdCliente.Text = dgClientes[0, posActual].Value.ToString();
                txtNombre.Text = dgClientes[1, posActual].Value.ToString();
                txtDocumento.Text = dgClientes[2, posActual].Value.ToString();
                txtDireccion.Text = dgClientes[3, posActual].Value.ToString();
                txtTelefono.Text = dgClientes[4, posActual].Value.ToString();
                txtEmail.Text = dgClientes[5, posActual].Value.ToString();
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
