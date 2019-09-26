using System;
using System.Windows.Forms;

namespace Sistema_facturación_2019_2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

       private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string Respuesta = "";

            if (txtUsuario.Text != "" && txtClave.Text != "")
            {
                accesoDatos acceso = new accesoDatos();
                Respuesta = acceso.validarUsuario(txtUsuario.Text, txtClave.Text);
                if (Respuesta != "")
                {
                    MessageBox.Show("Bienvenido: " + Respuesta);
                    frmPrincipal frmppal = new frmPrincipal();
                    this.Hide();
                    frmppal.Show();
                }
                else
                {
                    MessageBox.Show("Datos no Encontrados");
                    txtUsuario.Text = "";
                    txtClave.Text = "";
                    txtUsuario.Focus();
                    txtClave.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Debe de Ingresar los Datos");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
