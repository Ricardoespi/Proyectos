namespace Cronómetro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSeg = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblxd = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSeg
            // 
            this.txtSeg.BackColor = System.Drawing.Color.Black;
            this.txtSeg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 76F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txtSeg.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSeg.Location = new System.Drawing.Point(288, 42);
            this.txtSeg.Multiline = true;
            this.txtSeg.Name = "txtSeg";
            this.txtSeg.ReadOnly = true;
            this.txtSeg.Size = new System.Drawing.Size(158, 152);
            this.txtSeg.TabIndex = 5;
            this.txtSeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Black;
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlay.Location = new System.Drawing.Point(362, 219);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(84, 33);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Black;
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStop.Location = new System.Drawing.Point(255, 219);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(84, 33);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 76F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txtMin.ForeColor = System.Drawing.SystemColors.Info;
            this.txtMin.Location = new System.Drawing.Point(93, 42);
            this.txtMin.Multiline = true;
            this.txtMin.Name = "txtMin";
            this.txtMin.ReadOnly = true;
            this.txtMin.Size = new System.Drawing.Size(158, 152);
            this.txtMin.TabIndex = 8;
            this.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblxd
            // 
            this.lblxd.AutoSize = true;
            this.lblxd.BackColor = System.Drawing.Color.Transparent;
            this.lblxd.Font = new System.Drawing.Font("Microsoft Sans Serif", 75.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxd.ForeColor = System.Drawing.Color.White;
            this.lblxd.Location = new System.Drawing.Point(236, 59);
            this.lblxd.Name = "lblxd";
            this.lblxd.Size = new System.Drawing.Size(77, 114);
            this.lblxd.TabIndex = 9;
            this.lblxd.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Black;
            this.btnPause.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPause.Location = new System.Drawing.Point(93, 219);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(84, 33);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(521, 277);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtSeg);
            this.Controls.Add(this.lblxd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(537, 273);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSeg;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblxd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPause;
    }
}

