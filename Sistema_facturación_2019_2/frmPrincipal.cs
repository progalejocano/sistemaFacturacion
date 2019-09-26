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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            personalizarDiseño();
        }

        private void personalizarDiseño()
        {
            pnlTablasSub.Visible = false;
            pnlFacturacionSub.Visible = false;
            pnlSeguridadSub.Visible = false;
            pnlAyudasSub.Visible = false;
        }

        public void AbrirForm(Form formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void ocultarSub()
        {
            if (pnlTablasSub.Visible == true)
            {
                pnlTablasSub.Visible = false;
            }

            if (pnlFacturacionSub.Visible == true)
            {
                pnlFacturacionSub.Visible = false;
            }

            if (pnlSeguridadSub.Visible == true)
            {
                pnlSeguridadSub.Visible = false;
            }

            if (pnlAyudasSub.Visible == true)
            {
                pnlAyudasSub.Visible = false;
            }
        }

        private void mostrarSub(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSub();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void BtnTablas_Click(object sender, EventArgs e)
        {
            mostrarSub(pnlTablasSub);
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            AbrirForm(frmClientes);
            ocultarSub();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            frmProductos frmProductos = new frmProductos();
            AbrirForm(frmProductos);
            ocultarSub();
        }

        private void BtnCategoriaProducto_Click(object sender, EventArgs e)
        {
            frmCategoriaProductos frmCategoriaProductos = new frmCategoriaProductos();
            AbrirForm(frmCategoriaProductos);
            ocultarSub();
        }

        private void BtnFacturacion_Click(object sender, EventArgs e)
        {
            mostrarSub(pnlFacturacionSub);
        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {

            ocultarSub();
        }

        private void BtnInformes_Click(object sender, EventArgs e)
        {

            ocultarSub();
        }

        private void BtnSeguridad_Click(object sender, EventArgs e)
        {
            mostrarSub(pnlSeguridadSub);
        }

        private void BtnAdminUsuarios_Click(object sender, EventArgs e)
        {
            frmAdminUsuarios frmAdminUsuarios = new frmAdminUsuarios();
            AbrirForm(frmAdminUsuarios);
            ocultarSub();
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            AbrirForm(frmEmpleados);
            ocultarSub();
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            frmRoles frmRoles = new frmRoles();
            AbrirForm(frmRoles);
            ocultarSub();
        }

        private void BtnAyudas_Click(object sender, EventArgs e)
        {
            mostrarSub(pnlAyudasSub);
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {

            ocultarSub();
        }

        private void BtnAcercaDe_Click(object sender, EventArgs e)
        {

            ocultarSub();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
