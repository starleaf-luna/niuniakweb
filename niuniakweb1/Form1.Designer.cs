namespace niuniakweb1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtURL1 = new ToolStripTextBox();
            lblAddrBarBackground = new Label();
            edtAddress = new TextBox();
            btnNavigation = new Button();
            btnAbout = new Button();
            lblMinorErrorReporter = new Label();
            SuspendLayout();
            // 
            // txtURL1
            // 
            txtURL1.BackColor = Color.FromArgb(64, 64, 64);
            txtURL1.ForeColor = Color.White;
            txtURL1.Name = "txtURL1";
            txtURL1.Size = new Size(100, 23);
            txtURL1.ToolTipText = "URL to navigate to...";
            // 
            // lblAddrBarBackground
            // 
            lblAddrBarBackground.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAddrBarBackground.BackColor = Color.FromArgb(32, 32, 32);
            lblAddrBarBackground.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddrBarBackground.ForeColor = Color.White;
            lblAddrBarBackground.Location = new Point(0, -1);
            lblAddrBarBackground.Name = "lblAddrBarBackground";
            lblAddrBarBackground.Size = new Size(800, 53);
            lblAddrBarBackground.TabIndex = 1;
            // 
            // edtAddress
            // 
            edtAddress.BackColor = Color.FromArgb(64, 64, 64);
            edtAddress.BorderStyle = BorderStyle.FixedSingle;
            edtAddress.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            edtAddress.ForeColor = Color.White;
            edtAddress.Location = new Point(7, 4);
            edtAddress.Name = "edtAddress";
            edtAddress.Size = new Size(446, 23);
            edtAddress.TabIndex = 2;
            // 
            // btnNavigation
            // 
            btnNavigation.BackColor = Color.FromArgb(32, 32, 32);
            btnNavigation.FlatAppearance.BorderSize = 0;
            btnNavigation.FlatStyle = FlatStyle.Popup;
            btnNavigation.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnNavigation.ForeColor = Color.White;
            btnNavigation.Location = new Point(459, 2);
            btnNavigation.Name = "btnNavigation";
            btnNavigation.Size = new Size(75, 48);
            btnNavigation.TabIndex = 3;
            btnNavigation.Text = "Navigate";
            btnNavigation.UseVisualStyleBackColor = false;
            btnNavigation.Click += btnNavigation_Click;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.FromArgb(32, 32, 32);
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Popup;
            btnAbout.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnAbout.ForeColor = Color.White;
            btnAbout.Location = new Point(540, 2);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(75, 48);
            btnAbout.TabIndex = 4;
            btnAbout.Text = "About...\r\n";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // lblMinorErrorReporter
            // 
            lblMinorErrorReporter.BackColor = Color.FromArgb(32, 32, 32);
            lblMinorErrorReporter.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblMinorErrorReporter.ForeColor = Color.White;
            lblMinorErrorReporter.Location = new Point(7, 30);
            lblMinorErrorReporter.Name = "lblMinorErrorReporter";
            lblMinorErrorReporter.Size = new Size(446, 20);
            lblMinorErrorReporter.TabIndex = 5;
            lblMinorErrorReporter.Text = " ";
            // 
            // Form1
            // 
            AcceptButton = btnNavigation;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(800, 426);
            Controls.Add(lblMinorErrorReporter);
            Controls.Add(btnAbout);
            Controls.Add(btnNavigation);
            Controls.Add(edtAddress);
            Controls.Add(lblAddrBarBackground);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(768, 256);
            Name = "Form1";
            Text = "NiuniakWeb 0.10";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripTextBox txtURL1;
        private Label lblAddrBarBackground;
        private TextBox edtAddress;
        private Button btnNavigation;
        private Button btnAbout;
        private Label lblMinorErrorReporter;
    }
}
