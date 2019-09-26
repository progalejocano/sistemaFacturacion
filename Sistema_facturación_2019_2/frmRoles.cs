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
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        private void llenarGrid()
        {
            DataTable dt = new DataTable();
            accesoDatos acceso = new accesoDatos();
            dt = acceso.cargarTabla("tblRoles", "");
            dgListaRoles.DataSource = dt;
        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void dgCellMouse_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int posActual = 0;
                posActual = dgListaRoles.CurrentRow.Index;
                txtIdRol.Text = dgListaRoles[0, posActual].Value.ToString();
                txtDescripcionRol.Text = dgListaRoles[1, posActual].Value.ToString();
            }
            catch (Exception ex)
            {
                return;
            }

        }

        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtDescripcionRol.Text == "")
            {
                mensajeError.SetError(txtDescripcionRol, "Debe de Ingresar una Descripcion");
                txtDescripcionRol.Focus();
            }
            else
            {
                mensajeError.SetError(txtDescripcionRol, "");
            }
            
            return errorCampos;
        }

        public void nuevo()
        {
            txtDescripcionRol.Text = "";
            txtIdRol.Text = "";
        }

        public bool guardar()
        {
            Boolean actualizado = false;

            if (validar())
            {
                try
                {
                    accesoDatos acceso = new accesoDatos();
                    string sentencia = $"EXEC creacionRol '{txtDescripcionRol.Text}'";
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
            string sentencia = $"EXEC eliminarRol '{txtIdRol.Text}'";
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
    }
}

     
