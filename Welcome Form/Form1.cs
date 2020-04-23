using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Welcome_Form
{
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
        }

        private void closeApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method will show the user the best price for
        /// the computers and changes the label colours
        /// </summary>
        private void showComputer(object sender, EventArgs e)
        {
            bragLabel.Text = "Supa Dupa Computer\n Selling for £399";
            bragLabel.BackColor = Color.Purple;
            bragLabel.ForeColor = Color.Yellow;
            greetingLabel.BackColor = Color.Purple;
            greetingLabel.ForeColor = Color.Yellow;
        }

        /// <summary>
        /// This method will show the user the best price for
        /// the software on offer and changes the label colours.
        /// </summary>
        private void showSoftware(object sender, EventArgs e)
        {
            bragLabel.Text = "C# .NET for Dumbos\n A real bargain at £29.99";
            bragLabel.BackColor = Color.Blue;
            bragLabel.ForeColor = Color.Yellow;
            greetingLabel.BackColor = Color.Blue;
            greetingLabel.ForeColor = Color.Yellow;
        }
    }
}
