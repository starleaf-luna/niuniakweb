using System;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Xml;
using System.Net.Http;

namespace niuniakweb1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] MinorErrorStrings = {
            "Page loaded successfully!",                                    // 0  - no errors
            "Couldn't find {0}!",                                           // 1  - couldn't find a linked file
            "Found illegal HTML control {0}. May not work as intended!",    // 2  - illegal HTML control
            "Unsupported CSS! <style> and <link> tags are skipped.",        // 3  - CSS is unsupported
            "Found illegal CSS syntax {0}. Skipped!",                       // 4  - invalid CSS syntax
            "Couldn't find the page! (Error 404)",                          // 5  - 404
            "Unauthorised to view the page! (Error 403)",                   // 6  - 403
            "Error {0}!",                                                   // 7  - another type of error code
            "Control {0} is part of the top bar. Cannot remove it!",        // 8  - cannot remove top bar control
            "Unsupported JS! <script> tags are skipped.",                   // 9  - JS is unsupported
            "Loading...",                                                   // 10 - loading webpage indicator
            "{0} errors while displaying the webpage...",                   // 11 - general after-load 1+ error string
            "tag {0}",                                                      // 12 - test display of which tag it's reading
            "Invalid document!",                                            // 13 - if the document cannot be read by the XML parser
            "This document is an XML document, but isn't a HTML document!", // 14 - if the DocumentType isn't html
        };

        // array of names of controls that are part of the top bar, and therefore cannot, under ANY circumstance,
        // be removed from Controls
        string[] TopBarControls = {
            "lblAddrBarBackground",
            "lblMinorErrorReporter",
            "edtAddress",
            "btnNavigation",
            "btnAbout"
        };

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout form = new frmAbout();
            form.ShowDialog();
        }

        public void ClearPage()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                if (!TopBarControls.Contains(Controls[i].Name))
                {
                    Controls.RemoveAt(i);
                }
                else
                {
                    lblMinorErrorReporter.Text = string.Format(MinorErrorStrings[8], Controls[i].Name);
                }
            }
        }

        private async Task<string> CreatePage(string url)
        {
            ClearPage();
            HttpClient hpClient = new();
            XmlReader xmDoc = XmlReader.Create(url, null);
            var uri = new Uri(url);
            MessageBox.Show("load");
            lblMinorErrorReporter.Text = MinorErrorStrings[10];
            /*Label lblTest = new();
                lblTest.Location = new Point(10, 70); // about the right position for the top-left
                lblTest.AutoSize = true;
                lblTest.Text = response;
                Controls.Add(lblTest);*/
            MessageBox.Show("coords");
            Point coords = new(10, 70);
            MessageBox.Show("newnode");
            string newNode = xmDoc.ReadElementContentAsString();
            MessageBox.Show("while");
            while (newNode != null)
            {
                MessageBox.Show(newNode.ToString());
                newNode = xmDoc.ReadElementContentAsString();
                lblMinorErrorReporter.Text = String.Format(MinorErrorStrings[12], newNode.ToString());
                switch (newNode) {
                    default:
                        lblMinorErrorReporter.Text = string.Format(MinorErrorStrings[2], newNode.ToString());
                        Label lblElement = new();
                        lblElement.Location = coords;
                        lblElement.AutoSize = true;
                        lblElement.Text = xmDoc.ReadElementContentAsString(); 
                        Controls.Add(lblElement);
                        coords.Offset(0, 20);
                        break;
                }
            }
            return "";
        }

        public void CreateErrorPage(string header, string subtext)
        {
            ClearPage();
            BackColor = Color.FromArgb(255, 128, 0, 0);
            ForeColor = Color.White;
            Font = new("Segoe UI Variable", 18, FontStyle.Regular);
            Label lblErrText1 = new();
            lblErrText1.Text = header;
            lblErrText1.Location = new Point(36, 70);
            lblErrText1.AutoSize = true;
            Label lblErrText2 = new();
            lblErrText2.Text = subtext;
            lblErrText2.Location = new Point(36, 140);
            lblErrText2.AutoSize = true;
            lblErrText2.Font = new Font("Segoe UI Variable", 9, FontStyle.Regular);
            Controls.Add(lblErrText1);
            Controls.Add(lblErrText2);
            lblMinorErrorReporter.Text = "";
        }

        public void CreateStartingPage()
        {
            ClearPage();
            BackColor = Color.White;
            ForeColor = Color.Black;
            Font = new("Times New Roman", 9, FontStyle.Regular);
            Label lblInstrText = new();
            lblInstrText.Text = "Type an address (i.e. https://google.com) into the top bar above\n" +
                "and press [Enter] to get started";
            lblInstrText.Font = new Font("Segoe UI Variable", 18, FontStyle.Regular);
            lblInstrText.Location = new Point(36, 70);
            lblInstrText.ForeColor = Color.Gray;
            lblInstrText.AutoSize = true;
            Controls.Add(lblInstrText);
            lblMinorErrorReporter.Text = "";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CreateStartingPage();
        }

        private void btnNavigation_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(edtAddress.Text))
                CreateStartingPage();
            else
                CreatePage(edtAddress.Text);
        }
    }
}
