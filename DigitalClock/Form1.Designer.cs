namespace DigitalClock
{
    partial class DigitalClock
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
            this.lblClock = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.btnRed = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnStyle = new System.Windows.Forms.Button();
            this.btnStyle3 = new System.Windows.Forms.Button();
            this.btnStyle2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClock
            // 
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F);
            this.lblClock.ForeColor = System.Drawing.Color.Red;
            this.lblClock.Location = new System.Drawing.Point(12, 9);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(956, 422);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "Loading...";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.Location = new System.Drawing.Point(12, 434);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(20, 20);
            this.btnRed.TabIndex = 1;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.Location = new System.Drawing.Point(64, 434);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(20, 20);
            this.btnYellow.TabIndex = 2;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrange.Location = new System.Drawing.Point(38, 434);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(20, 20);
            this.btnOrange.TabIndex = 3;
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Lime;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.Location = new System.Drawing.Point(90, 434);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(20, 20);
            this.btnGreen.TabIndex = 4;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.Location = new System.Drawing.Point(116, 434);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(20, 20);
            this.btnBlue.TabIndex = 5;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhite.Location = new System.Drawing.Point(142, 434);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(20, 20);
            this.btnWhite.TabIndex = 6;
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnStyle
            // 
            this.btnStyle.BackColor = System.Drawing.Color.Black;
            this.btnStyle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStyle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStyle.FlatAppearance.BorderSize = 2;
            this.btnStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStyle.Font = new System.Drawing.Font("DS-Digital", 0.12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.btnStyle.ForeColor = System.Drawing.Color.White;
            this.btnStyle.Location = new System.Drawing.Point(168, 426);
            this.btnStyle.Name = "btnStyle";
            this.btnStyle.Size = new System.Drawing.Size(75, 28);
            this.btnStyle.TabIndex = 7;
            this.btnStyle.Text = "00:00:00";
            this.btnStyle.UseVisualStyleBackColor = false;
            this.btnStyle.Click += new System.EventHandler(this.btnStyle_Click);
            // 
            // btnStyle3
            // 
            this.btnStyle3.BackColor = System.Drawing.Color.Black;
            this.btnStyle3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStyle3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStyle3.FlatAppearance.BorderSize = 2;
            this.btnStyle3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStyle3.Font = new System.Drawing.Font("NSimSun", 0.12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Inch);
            this.btnStyle3.ForeColor = System.Drawing.Color.White;
            this.btnStyle3.Location = new System.Drawing.Point(329, 426);
            this.btnStyle3.Name = "btnStyle3";
            this.btnStyle3.Size = new System.Drawing.Size(81, 28);
            this.btnStyle3.TabIndex = 8;
            this.btnStyle3.Text = "00:00:00";
            this.btnStyle3.UseVisualStyleBackColor = false;
            this.btnStyle3.Click += new System.EventHandler(this.btnStyle_Click);
            // 
            // btnStyle2
            // 
            this.btnStyle2.BackColor = System.Drawing.Color.Black;
            this.btnStyle2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStyle2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStyle2.FlatAppearance.BorderSize = 2;
            this.btnStyle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStyle2.Font = new System.Drawing.Font("Times New Roman", 0.12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.btnStyle2.ForeColor = System.Drawing.Color.White;
            this.btnStyle2.Location = new System.Drawing.Point(248, 426);
            this.btnStyle2.Name = "btnStyle2";
            this.btnStyle2.Size = new System.Drawing.Size(75, 28);
            this.btnStyle2.TabIndex = 9;
            this.btnStyle2.Text = "00:00:00";
            this.btnStyle2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStyle2.UseVisualStyleBackColor = false;
            this.btnStyle2.Click += new System.EventHandler(this.btnStyle_Click);
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(980, 466);
            this.Controls.Add(this.btnStyle2);
            this.Controls.Add(this.btnStyle3);
            this.Controls.Add(this.btnStyle);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnOrange);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.lblClock);
            this.Name = "DigitalClock";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.DigitalClock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnStyle;
        private System.Windows.Forms.Button btnStyle3;
        private System.Windows.Forms.Button btnStyle2;
    }
}

