namespace Text_To_Speech
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trkSpeed = new System.Windows.Forms.TrackBar();
            this.trkVolume = new System.Windows.Forms.TrackBar();
            this.Btnread = new System.Windows.Forms.Button();
            this.Btnpause = new System.Windows.Forms.Button();
            this.BtnResume = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, -3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1113, 363);
            this.textBox1.TabIndex = 0;
            // 
            // trkSpeed
            // 
            this.trkSpeed.Location = new System.Drawing.Point(33, 387);
            this.trkSpeed.Name = "trkSpeed";
            this.trkSpeed.Size = new System.Drawing.Size(137, 56);
            this.trkSpeed.TabIndex = 1;
            // 
            // trkVolume
            // 
            this.trkVolume.Location = new System.Drawing.Point(202, 387);
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Size = new System.Drawing.Size(137, 56);
            this.trkVolume.TabIndex = 2;
            // 
            // Btnread
            // 
            this.Btnread.Location = new System.Drawing.Point(659, 385);
            this.Btnread.Name = "Btnread";
            this.Btnread.Size = new System.Drawing.Size(90, 58);
            this.Btnread.TabIndex = 3;
            this.Btnread.Text = "Read";
            this.Btnread.UseVisualStyleBackColor = true;
            this.Btnread.Click += new System.EventHandler(this.Btnread_Click);
            // 
            // Btnpause
            // 
            this.Btnpause.Location = new System.Drawing.Point(795, 385);
            this.Btnpause.Name = "Btnpause";
            this.Btnpause.Size = new System.Drawing.Size(97, 58);
            this.Btnpause.TabIndex = 4;
            this.Btnpause.Text = "Pause";
            this.Btnpause.UseVisualStyleBackColor = true;
            this.Btnpause.Click += new System.EventHandler(this.Btnpause_Click);
            // 
            // BtnResume
            // 
            this.BtnResume.Location = new System.Drawing.Point(942, 387);
            this.BtnResume.Name = "BtnResume";
            this.BtnResume.Size = new System.Drawing.Size(97, 58);
            this.BtnResume.TabIndex = 5;
            this.BtnResume.Text = "Resume";
            this.BtnResume.UseVisualStyleBackColor = true;
            this.BtnResume.Click += new System.EventHandler(this.BtnResume_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(659, 470);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(97, 58);
            this.BtnOpen.TabIndex = 6;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(795, 470);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(97, 58);
            this.btnRecord.TabIndex = 7;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(942, 470);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(97, 58);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 620);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.BtnResume);
            this.Controls.Add(this.Btnpause);
            this.Controls.Add(this.Btnread);
            this.Controls.Add(this.trkVolume);
            this.Controls.Add(this.trkSpeed);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trkSpeed;
        private System.Windows.Forms.TrackBar trkVolume;
        private System.Windows.Forms.Button Btnread;
        private System.Windows.Forms.Button Btnpause;
        private System.Windows.Forms.Button BtnResume;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

