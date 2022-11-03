namespace AppTechNikalDice
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.numudAgregarNroCaras = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadDeDados = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAgregarDado = new System.Windows.Forms.ToolStripSplitButton();
            this.agregarDadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudAgregarNroCaras)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.numudAgregarNroCaras);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblCantidadDeDados);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblResultado);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnRoll);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // numudAgregarNroCaras
            // 
            this.numudAgregarNroCaras.Location = new System.Drawing.Point(36, 55);
            this.numudAgregarNroCaras.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numudAgregarNroCaras.Name = "numudAgregarNroCaras";
            this.numudAgregarNroCaras.Size = new System.Drawing.Size(53, 20);
            this.numudAgregarNroCaras.TabIndex = 4;
            this.numudAgregarNroCaras.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblCantidadDeDados
            // 
            this.lblCantidadDeDados.AutoSize = true;
            this.lblCantidadDeDados.Location = new System.Drawing.Point(543, 191);
            this.lblCantidadDeDados.Name = "lblCantidadDeDados";
            this.lblCantidadDeDados.Size = new System.Drawing.Size(105, 13);
            this.lblCantidadDeDados.TabIndex = 3;
            this.lblCantidadDeDados.Text = "Número de Dados: 0";
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("PMingLiU-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(328, 180);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(168, 46);
            this.lblResultado.TabIndex = 2;
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Segoe Print", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(328, 259);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(168, 78);
            this.btnRoll.TabIndex = 1;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAgregarDado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(33, 446);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAgregarDado
            // 
            this.tsbtnAgregarDado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAgregarDado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDadoToolStripMenuItem});
            this.tsbtnAgregarDado.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAgregarDado.Image")));
            this.tsbtnAgregarDado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAgregarDado.Name = "tsbtnAgregarDado";
            this.tsbtnAgregarDado.Size = new System.Drawing.Size(30, 20);
            this.tsbtnAgregarDado.Text = "Agregar Dado";
            this.tsbtnAgregarDado.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // agregarDadoToolStripMenuItem
            // 
            this.agregarDadoToolStripMenuItem.Name = "agregarDadoToolStripMenuItem";
            this.agregarDadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarDadoToolStripMenuItem.Text = "Agregar Dado";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "frmPrincipal";
            this.Text = "TechNikalDice";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numudAgregarNroCaras)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblCantidadDeDados;
        private System.Windows.Forms.NumericUpDown numudAgregarNroCaras;
        private System.Windows.Forms.ToolStripSplitButton tsbtnAgregarDado;
        private System.Windows.Forms.ToolStripMenuItem agregarDadoToolStripMenuItem;
    }
}

