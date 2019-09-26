namespace Sistema_facturación_2019_2
{
    partial class frmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlInformacionEmpleado = new System.Windows.Forms.Panel();
            this.lblDatosAdicionales = new MaterialSkin.Controls.MaterialLabel();
            this.txtDatosAdicionales = new System.Windows.Forms.TextBox();
            this.lblRol = new MaterialSkin.Controls.MaterialLabel();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.lblSalida = new MaterialSkin.Controls.MaterialLabel();
            this.lblIngreso = new MaterialSkin.Controls.MaterialLabel();
            this.dtmSalida = new System.Windows.Forms.DateTimePicker();
            this.dtmIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblAdminEmpleados = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.mensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnlInformacionEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInformacionEmpleado
            // 
            this.pnlInformacionEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlInformacionEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.pnlInformacionEmpleado.Controls.Add(this.lblDatosAdicionales);
            this.pnlInformacionEmpleado.Controls.Add(this.txtDatosAdicionales);
            this.pnlInformacionEmpleado.Controls.Add(this.lblRol);
            this.pnlInformacionEmpleado.Controls.Add(this.cboRol);
            this.pnlInformacionEmpleado.Controls.Add(this.lblSalida);
            this.pnlInformacionEmpleado.Controls.Add(this.lblIngreso);
            this.pnlInformacionEmpleado.Controls.Add(this.txtTelefono);
            this.pnlInformacionEmpleado.Controls.Add(this.dtmSalida);
            this.pnlInformacionEmpleado.Controls.Add(this.dtmIngreso);
            this.pnlInformacionEmpleado.Controls.Add(this.txtEmail);
            this.pnlInformacionEmpleado.Controls.Add(this.txtDireccion);
            this.pnlInformacionEmpleado.Controls.Add(this.txtDocumento);
            this.pnlInformacionEmpleado.Controls.Add(this.txtNombre);
            this.pnlInformacionEmpleado.Location = new System.Drawing.Point(12, 63);
            this.pnlInformacionEmpleado.Name = "pnlInformacionEmpleado";
            this.pnlInformacionEmpleado.Size = new System.Drawing.Size(528, 259);
            this.pnlInformacionEmpleado.TabIndex = 1;
            // 
            // lblDatosAdicionales
            // 
            this.lblDatosAdicionales.AutoSize = true;
            this.lblDatosAdicionales.Depth = 0;
            this.lblDatosAdicionales.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDatosAdicionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatosAdicionales.Location = new System.Drawing.Point(317, 163);
            this.lblDatosAdicionales.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDatosAdicionales.Name = "lblDatosAdicionales";
            this.lblDatosAdicionales.Size = new System.Drawing.Size(132, 19);
            this.lblDatosAdicionales.TabIndex = 13;
            this.lblDatosAdicionales.Text = "Datos Adicionales";
            // 
            // txtDatosAdicionales
            // 
            this.txtDatosAdicionales.Location = new System.Drawing.Point(321, 185);
            this.txtDatosAdicionales.Multiline = true;
            this.txtDatosAdicionales.Name = "txtDatosAdicionales";
            this.txtDatosAdicionales.Size = new System.Drawing.Size(193, 71);
            this.txtDatosAdicionales.TabIndex = 12;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Depth = 0;
            this.lblRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRol.Location = new System.Drawing.Point(366, 33);
            this.lblRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(35, 19);
            this.lblRol.TabIndex = 11;
            this.lblRol.Text = "Rol:";
            // 
            // cboRol
            // 
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(407, 32);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(107, 21);
            this.cboRol.TabIndex = 10;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Depth = 0;
            this.lblSalida.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSalida.Location = new System.Drawing.Point(347, 123);
            this.lblSalida.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(54, 19);
            this.lblSalida.TabIndex = 9;
            this.lblSalida.Text = "Salida:";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Depth = 0;
            this.lblIngreso.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIngreso.Location = new System.Drawing.Point(338, 89);
            this.lblIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(63, 19);
            this.lblIngreso.TabIndex = 8;
            this.lblIngreso.Text = "Ingreso:";
            // 
            // dtmSalida
            // 
            this.dtmSalida.Location = new System.Drawing.Point(407, 122);
            this.dtmSalida.Name = "dtmSalida";
            this.dtmSalida.Size = new System.Drawing.Size(107, 20);
            this.dtmSalida.TabIndex = 6;
            // 
            // dtmIngreso
            // 
            this.dtmIngreso.Location = new System.Drawing.Point(407, 88);
            this.dtmIngreso.Name = "dtmIngreso";
            this.dtmIngreso.Size = new System.Drawing.Size(107, 20);
            this.dtmIngreso.TabIndex = 5;
            // 
            // lblAdminEmpleados
            // 
            this.lblAdminEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdminEmpleados.AutoSize = true;
            this.lblAdminEmpleados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminEmpleados.ForeColor = System.Drawing.Color.Black;
            this.lblAdminEmpleados.Location = new System.Drawing.Point(191, 9);
            this.lblAdminEmpleados.Name = "lblAdminEmpleados";
            this.lblAdminEmpleados.Size = new System.Drawing.Size(279, 23);
            this.lblAdminEmpleados.TabIndex = 4;
            this.lblAdminEmpleados.Text = "Administrador de Empleados";
            this.lblAdminEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(552, 486);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(104, 24);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(552, 63);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNuevo.Size = new System.Drawing.Size(104, 24);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(552, 96);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnActualizar.Size = new System.Drawing.Size(104, 24);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(552, 130);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(104, 24);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Location = new System.Drawing.Point(12, 350);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.Size = new System.Drawing.Size(528, 160);
            this.dgEmpleados.TabIndex = 15;
            this.dgEmpleados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCellMouse_Click);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdEmpleado.Location = new System.Drawing.Point(12, 14);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(17, 13);
            this.txtIdEmpleado.TabIndex = 16;
            // 
            // mensajeError
            // 
            this.mensajeError.ContainerControl = this;
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Hint = "Nombre";
            this.txtNombre.Location = new System.Drawing.Point(19, 24);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(237, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TabStop = false;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Depth = 0;
            this.txtDocumento.Hint = "Documento";
            this.txtDocumento.Location = new System.Drawing.Point(19, 67);
            this.txtDocumento.MaxLength = 32767;
            this.txtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.Size = new System.Drawing.Size(162, 23);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.TabStop = false;
            this.txtDocumento.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Hint = "Direccion";
            this.txtDireccion.Location = new System.Drawing.Point(19, 112);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(288, 23);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.TabStop = false;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "Email";
            this.txtEmail.Location = new System.Drawing.Point(19, 201);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(288, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TabStop = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "Telefono";
            this.txtTelefono.Location = new System.Drawing.Point(20, 155);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(162, 23);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblAdminEmpleados);
            this.Controls.Add(this.pnlInformacionEmpleado);
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.pnlInformacionEmpleado.ResumeLayout(false);
            this.pnlInformacionEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlInformacionEmpleado;
        private System.Windows.Forms.DateTimePicker dtmSalida;
        private System.Windows.Forms.DateTimePicker dtmIngreso;
        private MaterialSkin.Controls.MaterialLabel lblRol;
        private System.Windows.Forms.ComboBox cboRol;
        private MaterialSkin.Controls.MaterialLabel lblSalida;
        private MaterialSkin.Controls.MaterialLabel lblIngreso;
        private System.Windows.Forms.Label lblAdminEmpleados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblDatosAdicionales;
        private System.Windows.Forms.TextBox txtDatosAdicionales;
        private System.Windows.Forms.ErrorProvider mensajeError;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
    }
}