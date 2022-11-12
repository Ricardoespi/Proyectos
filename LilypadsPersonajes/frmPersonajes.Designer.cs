namespace LilypadsPersonajes
{
    partial class frmPersonajes
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
            this.dgvPersonajes = new System.Windows.Forms.DataGridView();
            this.pbxPersonajes = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltroAvanzado = new System.Windows.Forms.Button();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonajes
            // 
            this.dgvPersonajes.AllowUserToDeleteRows = false;
            this.dgvPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonajes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPersonajes.Location = new System.Drawing.Point(12, 50);
            this.dgvPersonajes.MultiSelect = false;
            this.dgvPersonajes.Name = "dgvPersonajes";
            this.dgvPersonajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonajes.Size = new System.Drawing.Size(725, 343);
            this.dgvPersonajes.TabIndex = 0;
            this.dgvPersonajes.SelectionChanged += new System.EventHandler(this.dgvPersonajes_SelectionChanged);
            // 
            // pbxPersonajes
            // 
            this.pbxPersonajes.Location = new System.Drawing.Point(743, 12);
            this.pbxPersonajes.Name = "pbxPersonajes";
            this.pbxPersonajes.Size = new System.Drawing.Size(241, 426);
            this.pbxPersonajes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPersonajes.TabIndex = 1;
            this.pbxPersonajes.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 402);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 402);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(174, 402);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.Location = new System.Drawing.Point(255, 402);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(88, 23);
            this.btnEliminarLogico.TabIndex = 4;
            this.btnEliminarLogico.Text = "Eliminar Lógico";
            this.btnEliminarLogico.UseVisualStyleBackColor = true;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(12, 27);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(39, 16);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Filtro:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(55, 25);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(180, 20);
            this.txtFiltro.TabIndex = 6;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnFiltroAvanzado
            // 
            this.btnFiltroAvanzado.Location = new System.Drawing.Point(639, 466);
            this.btnFiltroAvanzado.Name = "btnFiltroAvanzado";
            this.btnFiltroAvanzado.Size = new System.Drawing.Size(75, 21);
            this.btnFiltroAvanzado.TabIndex = 7;
            this.btnFiltroAvanzado.Text = "Buscar";
            this.btnFiltroAvanzado.UseVisualStyleBackColor = true;
            this.btnFiltroAvanzado.Click += new System.EventHandler(this.btnFiltroAvanzado_Click);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(323, 466);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 8;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(146, 466);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 9;
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(501, 466);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(132, 20);
            this.txtFiltroAvanzado.TabIndex = 10;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(96, 470);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 11;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(274, 470);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 12;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(451, 470);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(43, 13);
            this.lblFiltroAvanzado.TabIndex = 13;
            this.lblFiltroAvanzado.Text = "Buscar:";
            // 
            // frmPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 520);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.btnFiltroAvanzado);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxPersonajes);
            this.Controls.Add(this.dgvPersonajes);
            this.Name = "frmPersonajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personajes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonajes;
        private System.Windows.Forms.PictureBox pbxPersonajes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnFiltroAvanzado;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
    }
}

