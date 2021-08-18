/*
 * 8/18/2021
 * CSC-253
 * Branden Alder
 * Program displaying a table of celsius converted to fahrenheit
 */

using System;
using System.Windows.Forms;
using TempConversionClassLibrary;

namespace M1HW1_Alder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double celsius;         // To hold the celsius temperature
            double fahrenheit;      // To hold the fahrenheit temperature

            // Display a header for the table
            temperatureListBox.Items.Add("Celsius\tFahrenheit");

            // Display the table of temperatures
            for (celsius = 0; celsius <= 20; celsius++)
            {
                fahrenheit = Conversion.ConvertToFahrenheit(celsius);
                temperatureListBox.Items.Add(celsius + "\t" + fahrenheit);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        } // Closes program
    }
}
