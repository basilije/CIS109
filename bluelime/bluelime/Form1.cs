using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bluelime
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        private void CboLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(cboLocation.Text);
            }
        }

        /// <summary>
        /// Function that exexutes when the "Back" button is clicked.
        /// </summary>
        private void BtnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        /// <summary>
        /// Function that exexutes when the "Forward" button is clicked.
        /// </summary>
        private void BtnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        /// <summary>
        /// Function that exexutes when the "Go" button is clicked.
        /// </summary>
        private void BtnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cboLocation.Text);
        }

        /// <summary>
        /// Function that started when the document hosted in the Web browser control is fully loaded.
        /// </summary>
        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "bluelime - " + webBrowser1.Document.Title;
        }
    }
}
