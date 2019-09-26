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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void llenarGrid()
        {
            DataTable dt = new DataTable();
            accesoDatos acceso = new accesoDatos();
            dt = acceso.cargarTabla("tblEmpleado", "");
            dgEmpleados.DataSource = dt;

            dt = acceso.cargarTabla("tblRoles", "");
            cboRol.DataSource = dt;
            cboRol.DisplayMember = "strDescripcion";
            cboRol.ValueMember = "idRolEmpleado";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            llenarGrid();
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
                    string sentencia = $"EXEC creacionEmpleado '{txtNombre.Text}','{txtDocumento.Text}','{txtDireccion.Text}','{txtTelefono.Text}','{txtEmail.Text}','{Convert.ToInt32(cboRol.SelectedValue)}','{DateTime.Now.ToString("MM-dd-yyyy")}','{DateTime.Now.ToString("MM-dd-yyyy")}','{txtDatosAdicionales.Text}','{DateTime.Now.ToString("MM-dd-yyyy")}','{"admin"}'";
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
            txtIdEmpleado.Text = "";
            txtNombre.Text = "";
            txtDocumento.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            cboRol.SelectedIndex = 0;
            dtmIngreso.Value = DateTime.Now;
            dtmSalida.Value = Convert.ToDateTime("01/01/1990");
            txtDatosAdicionales.Text = "";
        }

        public void eliminar()
        {
            accesoDatos acceso = new accesoDatos();
            string sentencia = $"EXEC eliminarEmpleado '{txtIdEmpleado.Text}'";
            MessageBox.Show(acceso.ejecutarComando(sentencia));
            nuevo();
            llenarGrid();
        }

        private void dgCellMouse_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int posActual = 0;
                posActual = dgEmpleados.CurrentRow.Index;
                txtIdEmpleado.Text = dgEmpleados[0, posActual].Value.ToString();
                txtNombre.Text = dgEmpleados[1, posActual].Value.ToString();
                txtDocumento.Text = dgEmpleados[2, posActual].Value.ToString();
                txtDireccion.Text = dgEmpleados[3, posActual].Value.ToString();
                txtTelefono.Text = dgEmpleados[4, posActual].Value.ToString();
                txtEmail.Text = dgEmpleados[5, posActual].Value.ToString();
                cboRol.SelectedIndex = Convert.ToInt16(dgEmpleados[6, posActual].Value.ToString());
                dtmIngreso.Value = Convert.ToDateTime(dgEmpleados[7, posActual].Value.ToString());
                if (dgEmpleados[8, posActual].Value.ToString() != "")
                {
                    dtmSalida.Value = Convert.ToDateTime(dgEmpleados[8, posActual].Value.ToString());
                }
                else
                {
                    dtmSalida.Value = Convert.ToDateTime("01-01-1990");
                }
                txtDatosAdicionales.Text = dgEmpleados[9, posActual].Value.ToString();

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
