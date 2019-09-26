namespace Sistema_facturación_2019_2
{
    partial class frmRoles
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
            this.lblAdminRoles = new System.Windows.Forms.Label();
            this.lblRol = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescripcionRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgListaRoles = new System.Windows.Forms.DataGridView();
            this.lblListaRoles = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdRol = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminRoles
            // 
            this.lblAdminRoles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdminRoles.AutoSize = true;
            this.lblAdminRoles.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminRoles.ForeColor = System.Drawing.Color.Black;
            this.lblAdminRoles.Location = new System.Drawing.Point(214, 49);
            this.lblAdminRoles.Name = "lblAdminRoles";
            this.lblAdminRoles.Size = new System.Drawing.Size(223, 23);
            this.lblAdminRoles.TabIndex = 5;
            this.lblAdminRoles.Text = "Administrador de Roles";
            this.lblAdminRoles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRol
            // 
            this.lblRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRol.AutoSize = true;
            this.lblRol.Depth = 0;
            this.lblRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRol.Location = new System.Drawing.Point(151, 146);
            this.lblRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(35, 19);
            this.lblRol.TabIndex = 12;
            this.lblRol.Text = "Rol:";
            // 
            // txtDescripcionRol
            // 
            this.txtDescripcionRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcionRol.Depth = 0;
            this.txtDescripcionRol.Hint = "Descripcion";
            this.txtDescripcionRol.Location = new System.Drawing.Point(218, 142);
            this.txtDescripcionRol.MaxLength = 32767;
            this.txtDescripcionRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcionRol.Name = "txtDescripcionRol";
            this.txtDescripcionRol.PasswordChar = '\0';
            this.txtDescripcionRol.SelectedText = "";
            this.txtDescripcionRol.SelectionLength = 0;
            this.txtDescripcionRol.SelectionStart = 0;
            this.txtDescripcionRol.Size = new System.Drawing.Size(219, 23);
            this.txtDescripcionRol.TabIndex = 13;
            this.txtDescripcionRol.TabStop = false;
            this.txtDescripcionRol.UseSystemPasswordChar = false;
            // 
            // dgListaRoles
            // 
            this.dgListaRoles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgListaRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaRoles.Location = new System.Drawing.Point(140, 209);
            this.dgListaRoles.Name = "dgListaRoles";
            this.dgListaRoles.Size = new System.Drawing.Size(235, 259);
            this.dgListaRoles.TabIndex = 14;
            this.dgListaRoles.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgCellMouse_Click);
            // 
            // lblListaRoles
            // 
            this.lblListaRoles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblListaRoles.AutoSize = true;
            this.lblListaRoles.Depth = 0;
            this.lblListaRoles.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblListaRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblListaRoles.Location = new System.Drawing.Point(151, 187);
            this.lblListaRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblListaRoles.Name = "lblListaRoles";
            this.lblListaRoles.Size = new System.Drawing.Size(130, 19);
            this.lblListaRoles.TabIndex = 15;
            this.lblListaRoles.Text = "Roles Disponibles";
            // 
            // txtIdRol
            // 
            this.txtIdRol.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdRol.Location = new System.Drawing.Point(40, 25);
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.Size = new System.Drawing.Size(17, 13);
            this.txtIdRol.TabIndex = 16;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(505, 208);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(104, 24);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(505, 174);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnActualizar.Size = new System.Drawing.Size(104, 24);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(505, 141);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNuevo.Size = new System.Drawing.Size(104, 24);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(505, 457);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(104, 24);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // mensajeError
            // 
            this.mensajeError.ContainerControl = this;
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtIdRol);
            this.Controls.Add(this.lblListaRoles);
            this.Controls.Add(this.dgListaRoles);
            this.Controls.Add(this.txtDescripcionRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblAdminRoles);
            this.Name = "frmRoles";
            this.Text = "frmRoles";
            this.Load += new System.EventHandler(this.FrmRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminRoles;
        private MaterialSkin.Controls.MaterialLabel lblRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcionRol;
        private System.Windows.Forms.DataGridView dgListaRoles;
        private MaterialSkin.Controls.MaterialLabel lblListaRoles;
        private System.Windows.Forms.TextBox txtIdRol;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider mensajeError;
    }
}