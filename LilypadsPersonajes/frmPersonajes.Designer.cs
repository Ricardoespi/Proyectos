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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonajes
            // 
            this.dgvPersonajes.AllowUserToDeleteRows = false;
            this.dgvPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonajes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPersonajes.Location = new System.Drawing.Point(12, 12);
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
            this.btnAgregar.Location = new System.Drawing.Point(12, 361);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 361);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(174, 361);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.Location = new System.Drawing.Point(255, 361);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(88, 23);
            this.btnEliminarLogico.TabIndex = 4;
            this.btnEliminarLogico.Text = "Eliminar Lógico";
            this.btnEliminarLogico.UseVisualStyleBackColor = true;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // frmPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 450);
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

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonajes;
        private System.Windows.Forms.PictureBox pbxPersonajes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEliminarLogico;
    }
}

