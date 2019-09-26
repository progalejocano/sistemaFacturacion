using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_facturación_2019_2
{
    public partial class frmAdminUsuarios : Form
    {
        public frmAdminUsuarios()
        {
            InitializeComponent();
        }

        private void FrmAdminUsuarios_Load(object sender, EventArgs e)
        {
            llenarCombo();
        }

        private void llenarCombo()
        {
            DataTable dt = new DataTable();
            accesoDatos acceso = new accesoDatos();
            dt = acceso.cargarTabla("tblEmpleado", "");
            cboEmpleado.DataSource = dt;
            cboEmpleado.DisplayMember = "strNombre";
            cboEmpleado.ValueMember = "idEmpleado";
            acceso.cerrarDB();
        }

        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtUsuario.Text == "")
            {
                mensajeError.SetError(txtUsuario, "Debe de Ingresar un valor de Usuario");
                txtUsuario.Focus();
            }
            else
            {
                mensajeError.SetError(txtUsuario, "");
            }
            if (txtClave.Text == "")
            {
                mensajeError.SetError(txtClave, "Debe de Ingresar un valor de Clave");
                txtClave.Focus();
                errorCampos = false;
            }
            else
            {
                mensajeError.SetError(txtClave, "");
            }
            return errorCampos;
        }

        public void cargar()
        {
            DataTable dt = new DataTable();
            string sentencia = "SELECT strUsuario, strClave FROM tblSeguridad WHERE idEmpleado= " + cboEmpleado.SelectedValue.ToString();
            accesoDatos acceso = new accesoDatos();
            dt = acceso.ejecutarComandoDatos(sentencia);
            if (dt.Rows.Count > 0)
            {
                txtUsuario.Text = dt.Rows[0]["strUsuario"].ToString();
                txtClave.Text = dt.Rows[0]["strClave"].ToString();
            }
            else
            {
                MessageBox.Show("El Usuario no dispone de Datos de Ingreso");
                txtUsuario.Text = "";
                txtClave.Text = "";
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
                    string sentencia = $"EXEC actualizarSeguridad '{Convert.ToInt32(cboEmpleado.SelectedValue)}','{txtUsuario.Text}','{txtClave.Text}','{DateTime.Now.ToString("MM-dd-yyyy")}','admin'";
                    MessageBox.Show(acceso.ejecutarComando(sentencia));
                    llenarCombo();
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
            string sentencia = $"EXEC eliminarSeguridad '{Convert.ToInt32(cboEmpleado.SelectedValue)}'";
            MessageBox.Show(acceso.ejecutarComando(sentencia));
            txtUsuario.Text = "";
            txtClave.Text = "";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
    }
}
