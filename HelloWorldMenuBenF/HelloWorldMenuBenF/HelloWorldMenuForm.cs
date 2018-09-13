/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/09/11
 * Created for: ICS3U Programming
 * Daily Assignment – Day #4 - Hello World with Menu
 * This program displays Hello World but with an exit menu
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldMenuBenF
{
    public partial class frmHelloWorldMenu : Form
    {
        public frmHelloWorldMenu()
        {
            InitializeComponent();
        }

        private void mnuProgram_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // when press "Exit", close the program 
            this.Close();
        }

        private void get1MillionDollarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // when press "Get 1 million dollars", close the program
            this.Close()
        }
    }
}
