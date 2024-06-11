namespace niuniakweb1
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            label1 = new Label();
            label2 = new Label();
            btnOK = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(68, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 0;
            label1.Text = "NiuniakWeb";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 61);
            label2.Name = "label2";
            label2.Size = new Size(221, 96);
            label2.TabIndex = 1;
            label2.Text = "Version 0.10\r\nby Bellie, 2024.\r\nThis software is not meant to be paid for.\r\nIt is totally free.\r\nSo, if you paid for this, \r\nyou got scammed!";
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.FromArgb(48, 48, 48);
            btnOK.FlatStyle = FlatStyle.Popup;
            btnOK.Location = new Point(212, 128);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 31);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmAbout
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(299, 171);
            Controls.Add(pictureBox1);
            Controls.Add(btnOK);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAbout";
            ShowInTaskbar = false;
            Text = "About NiuniakWeb";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnOK;
        private PictureBox pictureBox1;
    }
}