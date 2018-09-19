/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/09/13
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - PerCircvol
 * This program calculates the perimeter of a rectangle, area of a circle, and volume of a sphere.
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

namespace AreaCircVol
{
    public partial class AreaCircVolForm : Form
    {
        public AreaCircVolForm()
        {
            InitializeComponent();
        }

        private void btnPerRect_Click(object sender, EventArgs e)
        {
            //Calculates the perimiter of the rectangle
            lblPerRectAns.Text = Convert.ToString(2 * 10 + 2 * 3) + "cm";
        }

        private void btnAreaCirc_Click(object sender, EventArgs e)
        {
            //This calculates the area of a circle
            lblAreaCircAns.Text = Convert.ToString(Math.PI * Math.Pow(10, 2)) + "cm^2";
        }

        private void btnVolSphere_Click(object sender, EventArgs e)
        {
            //This calculates the volume of the sphere. 4 / 3 didn't work so I used 1.3 repeated
            lblVolSphereAns.Text = Convert.ToString( (double) 4 / (double) 3 * (Math.PI * Math.Pow(6, 3))) + "cm^3";
        }
    }
}
