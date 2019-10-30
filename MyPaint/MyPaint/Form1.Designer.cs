namespace MyPaint
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RedButton = new System.Windows.Forms.ToolStripButton();
            this.BlueButton = new System.Windows.Forms.ToolStripButton();
            this.GreenButton = new System.Windows.Forms.ToolStripButton();
            this.PurpleButton = new System.Windows.Forms.ToolStripButton();
            this.LimeButton = new System.Windows.Forms.ToolStripButton();
            this.WhiteButton = new System.Windows.Forms.ToolStripButton();
            this.BlackButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 40);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 40);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.saveImageAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // saveImageAsToolStripMenuItem
            // 
            this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.saveImageAsToolStripMenuItem.Text = "Save Image As";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RedButton,
            this.BlueButton,
            this.GreenButton,
            this.PurpleButton,
            this.LimeButton,
            this.WhiteButton,
            this.BlackButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 64);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // RedButton
            // 
            this.RedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RedButton.ForeColor = System.Drawing.Color.Red;
            this.RedButton.Image = ((System.Drawing.Image)(resources.GetObject("RedButton.Image")));
            this.RedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(54, 36);
            this.RedButton.Text = "red";
            this.RedButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // BlueButton
            // 
            this.BlueButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BlueButton.ForeColor = System.Drawing.Color.Blue;
            this.BlueButton.Image = ((System.Drawing.Image)(resources.GetObject("BlueButton.Image")));
            this.BlueButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(66, 36);
            this.BlueButton.Text = "blue";
            this.BlueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GreenButton.ForeColor = System.Drawing.Color.Green;
            this.GreenButton.Image = ((System.Drawing.Image)(resources.GetObject("GreenButton.Image")));
            this.GreenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(81, 36);
            this.GreenButton.Text = "green";
            this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // PurpleButton
            // 
            this.PurpleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PurpleButton.ForeColor = System.Drawing.Color.Purple;
            this.PurpleButton.Image = ((System.Drawing.Image)(resources.GetObject("PurpleButton.Image")));
            this.PurpleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PurpleButton.Name = "PurpleButton";
            this.PurpleButton.Size = new System.Drawing.Size(88, 36);
            this.PurpleButton.Text = "purple";
            this.PurpleButton.Click += new System.EventHandler(this.PurpleButton_Click);
            // 
            // LimeButton
            // 
            this.LimeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LimeButton.ForeColor = System.Drawing.Color.Lime;
            this.LimeButton.Image = ((System.Drawing.Image)(resources.GetObject("LimeButton.Image")));
            this.LimeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LimeButton.Name = "LimeButton";
            this.LimeButton.Size = new System.Drawing.Size(65, 36);
            this.LimeButton.Text = "lime";
            this.LimeButton.Click += new System.EventHandler(this.LimeButton_Click);
            // 
            // WhiteButton
            // 
            this.WhiteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WhiteButton.ForeColor = System.Drawing.Color.White;
            this.WhiteButton.Image = ((System.Drawing.Image)(resources.GetObject("WhiteButton.Image")));
            this.WhiteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WhiteButton.Name = "WhiteButton";
            this.WhiteButton.Size = new System.Drawing.Size(77, 36);
            this.WhiteButton.Text = "white";
            this.WhiteButton.Click += new System.EventHandler(this.WhiteButton_Click);
            // 
            // BlackButton
            // 
            this.BlackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BlackButton.ForeColor = System.Drawing.Color.Black;
            this.BlackButton.Image = ((System.Drawing.Image)(resources.GetObject("BlackButton.Image")));
            this.BlackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BlackButton.Name = "BlackButton";
            this.BlackButton.Size = new System.Drawing.Size(74, 36);
            this.BlackButton.Text = "black";
            this.BlackButton.Click += new System.EventHandler(this.BlackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 347);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "My Paint";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton RedButton;
        private System.Windows.Forms.ToolStripButton BlueButton;
        private System.Windows.Forms.ToolStripButton GreenButton;
        private System.Windows.Forms.ToolStripButton PurpleButton;
        private System.Windows.Forms.ToolStripButton LimeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton WhiteButton;
        private System.Windows.Forms.ToolStripButton BlackButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

