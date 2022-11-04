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
            this.lblNombrePersonaje = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonajes
            // 
            this.dgvPersonajes.AllowUserToDeleteRows = false;
            this.dgvPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonajes.Location = new System.Drawing.Point(12, 12);
            this.dgvPersonajes.Name = "dgvPersonajes";
            this.dgvPersonajes.Size = new System.Drawing.Size(156, 318);
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
            // lblNombrePersonaje
            // 
            this.lblNombrePersonaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePersonaje.Location = new System.Drawing.Point(434, 9);
            this.lblNombrePersonaje.Name = "lblNombrePersonaje";
            this.lblNombrePersonaje.Size = new System.Drawing.Size(303, 57);
            this.lblNombrePersonaje.TabIndex = 2;
            this.lblNombrePersonaje.Text = "Nombre";
            this.lblNombrePersonaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(432, 80);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(305, 358);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion.";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 361);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombrePersonaje);
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
        private System.Windows.Forms.Label lblNombrePersonaje;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnAgregar;
    }
}

