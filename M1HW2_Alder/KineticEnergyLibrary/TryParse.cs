using System.Windows.Forms;

namespace KineticEnergyLibrary
{
    public class TryParse
    {
        // Parses double from textboxes otherwise returns errors
        public static void ParseDouble(ref double mass, ref double velocity, TextBox massBox, TextBox velocityBox)
        {
            if(double.TryParse(massBox.Text, out mass))
            {

                if(double.TryParse(velocityBox.Text, out velocity))
                {

                }
                else
                {
                    MessageBox.Show("Error parsing velocity.");
                }
            }
            else
            {
                MessageBox.Show("Error parsing mass.");
            }
        }
    }
}
