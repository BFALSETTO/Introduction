/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/09/12
 * Created for: ICS3U Programming
 * Daily Assignment – Day #5 - Name of Program
 * This program changes the language displayed when the radio buttons are clicked
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

namespace HelloWorldInt
{
    public partial class frmHelloWorldInt : Form
    {
        public frmHelloWorldInt()
        {
            InitializeComponent();
        }

        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {
            this.lblHelloWorld.Text = "Hello World!";
        }

        private void radFrench_CheckedChanged(object sender, EventArgs e)
        {
            this.lblHelloWorld.Text = "Bonjour le monde!";
        }

        private void radItalian_CheckedChanged(object sender, EventArgs e)
        {
            this.lblHelloWorld.Text = "Ciao mondo!";
        }

        private void radSpanish_CheckedChanged(object sender, EventArgs e)
        {
            this.lblHelloWorld.Text = "¡Hola mundo!";
        }

        private void radIrish_CheckedChanged(object sender, EventArgs e)
        {
            this.lblHelloWorld.Text = "Dia duit Domhanda!";
        }

        private void radRussian_CheckedChanged(object sender, EventArgs e)
        {
            this.lblHelloWorld.Text = "Добрый день, товарищ!";
        }

        private void lblHelloWorld_Click(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
