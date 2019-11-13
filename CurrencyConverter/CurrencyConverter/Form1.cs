/* Vasilije Mehandzic
 * Reno Technology Academy
 * CIS109: Coding in C# for Imbedded Systems
 * Udemy, 17 Beginner C# Walktrough Projects Step By Step
 * Project 7: Create a world Currency Converter
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class CurrencyConvert : Form
    {
        public CurrencyConvert()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function that starts when user click on the "Currencty Converter" button.
        /// </summary>
        private void BtnConverter_Click(object sender, EventArgs e)
        {
            // open the website with working currency converter
            webBrowser1.Navigate("https://www.foreignexchangeresource.com/currency-converter.php");
        }
    }
}
