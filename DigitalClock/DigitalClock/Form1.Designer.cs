namespace DigitalClock
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
            this.hourMinuteLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hourMinuteLabel
            // 
            this.hourMinuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourMinuteLabel.ForeColor = System.Drawing.Color.White;
            this.hourMinuteLabel.Location = new System.Drawing.Point(71, 58);
            this.hourMinuteLabel.Name = "hourMinuteLabel";
            this.hourMinuteLabel.Size = new System.Drawing.Size(308, 98);
            this.hourMinuteLabel.TabIndex = 0;
            this.hourMinuteLabel.Text = "11 : 55";
            // 
            // secondsLabel
            // 
            this.secondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLabel.ForeColor = System.Drawing.Color.White;
            this.secondsLabel.Location = new System.Drawing.Point(366, 58);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(163, 98);
            this.secondsLabel.TabIndex = 1;
            this.secondsLabel.Text = "33";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(673, 365);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.hourMinuteLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hourMinuteLabel;
        private System.Windows.Forms.Label secondsLabel;
    }
}

