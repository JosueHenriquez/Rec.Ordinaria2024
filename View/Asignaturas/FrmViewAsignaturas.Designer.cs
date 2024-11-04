namespace Refuerzo2024.View.Asignaturas
{
    partial class FrmViewAsignaturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.Label();
            this.txcodigo = new System.Windows.Forms.Label();
            this.txtNombreAsignatura = new System.Windows.Forms.Label();
            this.txtIdAsignatura = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(77, 344);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 41);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(137, 297);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 41);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar registro";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(14, 297);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 41);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(14, 233);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(235, 21);
            this.cmbEspecialidad.TabIndex = 4;
            // 
            // tbcodigo
            // 
            this.tbcodigo.Location = new System.Drawing.Point(14, 174);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(235, 20);
            this.tbcodigo.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(14, 119);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(235, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(14, 36);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(112, 20);
            this.tbId.TabIndex = 1;
            this.tbId.TabStop = false;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.AutoSize = true;
            this.txtEspecialidad.Location = new System.Drawing.Point(11, 217);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.txtEspecialidad.TabIndex = 27;
            this.txtEspecialidad.Text = "Especialidad";
            // 
            // txcodigo
            // 
            this.txcodigo.AutoSize = true;
            this.txcodigo.Location = new System.Drawing.Point(11, 158);
            this.txcodigo.Name = "txcodigo";
            this.txcodigo.Size = new System.Drawing.Size(40, 13);
            this.txcodigo.TabIndex = 17;
            this.txcodigo.Text = "Código";
            // 
            // txtNombreAsignatura
            // 
            this.txtNombreAsignatura.AutoSize = true;
            this.txtNombreAsignatura.Location = new System.Drawing.Point(11, 103);
            this.txtNombreAsignatura.Name = "txtNombreAsignatura";
            this.txtNombreAsignatura.Size = new System.Drawing.Size(107, 13);
            this.txtNombreAsignatura.TabIndex = 14;
            this.txtNombreAsignatura.Text = "Nombre Especialidad";
            // 
            // txtIdAsignatura
            // 
            this.txtIdAsignatura.AutoSize = true;
            this.txtIdAsignatura.Location = new System.Drawing.Point(11, 18);
            this.txtIdAsignatura.Name = "txtIdAsignatura";
            this.txtIdAsignatura.Size = new System.Drawing.Size(96, 13);
            this.txtIdAsignatura.TabIndex = 11;
            this.txtIdAsignatura.Text = "ID de la asignatura";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(539, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(144, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar asignatura";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscar.Location = new System.Drawing.Point(119, 23);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(404, 20);
            this.tbBuscar.TabIndex = 8;
            // 
            // txtBuscar
            // 
            this.txtBuscar.AutoSize = true;
            this.txtBuscar.Location = new System.Drawing.Point(18, 26);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(95, 13);
            this.txtBuscar.TabIndex = 33;
            this.txtBuscar.Text = "Buscar asignatura:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.txtIdAsignatura);
            this.panel1.Controls.Add(this.txtNombreAsignatura);
            this.panel1.Controls.Add(this.txcodigo);
            this.panel1.Controls.Add(this.txtEspecialidad);
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.tbcodigo);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.cmbEspecialidad);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 428);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.tbBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(284, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 65);
            this.panel2.TabIndex = 36;
            // 
            // dgvAsignaturas
            // 
            this.dgvAsignaturas.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvAsignaturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAsignaturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAsignaturas.Location = new System.Drawing.Point(284, 65);
            this.dgvAsignaturas.Name = "dgvAsignaturas";
            this.dgvAsignaturas.ReadOnly = true;
            this.dgvAsignaturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsignaturas.Size = new System.Drawing.Size(713, 363);
            this.dgvAsignaturas.TabIndex = 37;
            // 
            // FrmViewAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 428);
            this.Controls.Add(this.dgvAsignaturas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmViewAsignaturas";
            this.Text = "Asignaturas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.ComboBox cmbEspecialidad;
        public System.Windows.Forms.TextBox tbcodigo;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.TextBox tbId;
        public System.Windows.Forms.Label txtEspecialidad;
        public System.Windows.Forms.Label txcodigo;
        public System.Windows.Forms.Label txtNombreAsignatura;
        public System.Windows.Forms.Label txtIdAsignatura;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox tbBuscar;
        public System.Windows.Forms.Label txtBuscar;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvAsignaturas;
    }
}