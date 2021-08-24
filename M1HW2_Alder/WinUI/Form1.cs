 /*
 * 8 / 20 / 2021
 * CSC - 253
 * Branden Alder
 * Program displaying kinetic energy from mass and velocity. 
  */

using System;
using System.Windows.Forms;
using KineticEnergyLibrary;

namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double mass = 0, velocity = 0, energy;

            // Parses mass and velocity doubles from textboxes and assigns to mass and velocity
            TryParse.ParseDouble(ref mass, ref velocity, massTextBox, velocityTextBox);

            // Calculates kinetic energy
            energy = Calculate.KineticEnergy(mass, velocity);

            // Displays to kinetic energy text label
            kineticEnergyText.Text = energy.ToString("n1");
        }

        // Closes program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
