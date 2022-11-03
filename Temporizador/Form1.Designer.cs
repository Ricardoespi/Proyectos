namespace Temporizador
{
    partial class Form1
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
            this.cbMinutos = new System.Windows.Forms.ComboBox();
            this.cbHoras = new System.Windows.Forms.ComboBox();
            this.cbSegundos = new System.Windows.Forms.ComboBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPomodoro = new System.Windows.Forms.Button();
            this.lblPomodoro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMinutos
            // 
            this.cbMinutos.FormattingEnabled = true;
            this.cbMinutos.Location = new System.Drawing.Point(176, 48);
            this.cbMinutos.Name = "cbMinutos";
            this.cbMinutos.Size = new System.Drawing.Size(121, 21);
            this.cbMinutos.TabIndex = 0;
            // 
            // cbHoras
            // 
            this.cbHoras.FormattingEnabled = true;
            this.cbHoras.Location = new System.Drawing.Point(49, 48);
            this.cbHoras.Name = "cbHoras";
            this.cbHoras.Size = new System.Drawing.Size(121, 21);
            this.cbHoras.TabIndex = 1;
            // 
            // cbSegundos
            // 
            this.cbSegundos.FormattingEnabled = true;
            this.cbSegundos.Location = new System.Drawing.Point(303, 48);
            this.cbSegundos.Name = "cbSegundos";
            this.cbSegundos.Size = new System.Drawing.Size(121, 21);
            this.cbSegundos.TabIndex = 2;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(46, 32);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(35, 13);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Horas";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(300, 32);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(55, 13);
            this.lblSegundos.TabIndex = 4;
            this.lblSegundos.Text = "Segundos";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(173, 32);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(44, 13);
            this.lblMinutos.TabIndex = 5;
            this.lblMinutos.Text = "Minutos";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(100, 72);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(284, 73);
            this.lblTiempo.TabIndex = 6;
            this.lblTiempo.Text = "00:00:00";
            // 
            // btnIniciar
            // 
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnIniciar.Location = new System.Drawing.Point(49, 160);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(189, 50);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnPausar.Location = new System.Drawing.Point(244, 160);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(189, 50);
            this.btnPausar.TabIndex = 9;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPomodoro
            // 
            this.btnPomodoro.Location = new System.Drawing.Point(413, 75);
            this.btnPomodoro.Name = "btnPomodoro";
            this.btnPomodoro.Size = new System.Drawing.Size(75, 23);
            this.btnPomodoro.TabIndex = 10;
            this.btnPomodoro.Text = "Pomodoro";
            this.btnPomodoro.UseVisualStyleBackColor = true;
            this.btnPomodoro.Click += new System.EventHandler(this.btnPomodoro_Click);
            // 
            // lblPomodoro
            // 
            this.lblPomodoro.AutoSize = true;
            this.lblPomodoro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPomodoro.ForeColor = System.Drawing.Color.Crimson;
            this.lblPomodoro.Location = new System.Drawing.Point(199, 42);
            this.lblPomodoro.Name = "lblPomodoro";
            this.lblPomodoro.Size = new System.Drawing.Size(86, 25);
            this.lblPomodoro.TabIndex = 11;
            this.lblPomodoro.Text = "Trabajo";
            this.lblPomodoro.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 233);
            this.Controls.Add(this.lblPomodoro);
            this.Controls.Add(this.btnPomodoro);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.cbSegundos);
            this.Controls.Add(this.cbHoras);
            this.Controls.Add(this.cbMinutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMinutos;
        private System.Windows.Forms.ComboBox cbHoras;
        private System.Windows.Forms.ComboBox cbSegundos;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPomodoro;
        private System.Windows.Forms.Label lblPomodoro;
    }
}

