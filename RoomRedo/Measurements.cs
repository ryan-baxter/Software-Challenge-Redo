using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomRedo
{
    public partial class Measurements : Form
    {
        //Room measurements & area/volume
        double length;
        double width;
        double height;
        public static double area;
        public static double volume;

        //Calculating the surface area of the walls
        double lengthDouble;
        double widthDouble;
        public static double walls;

        //Room measurement
        public static string measure;

        public Measurements()
        {
            InitializeComponent();
        }

        //Validation checks
        private new bool Validate()
        {
            //Validation variables
            double allowedChars;
            double number = 0;
            string lengthText = txtLength.Text;
            string widthText = txtWidth.Text;
            string heightText = txtHeight.Text;
            string measureText = cboMeasurements.Text;

            //Length validation checks
            if (string.IsNullOrEmpty(lengthText))
            {
                MessageBox.Show("Please enter the length of the room e.g. 10, 15.4, etc.", "Length Error");
                return false;
            }
            
            if (Convert.ToDouble(lengthText) > 100)
            {
                MessageBox.Show("Please enter a length that is below 100", "Length Error");
                return false;
            }

            if (!double.TryParse(lengthText, out allowedChars))
            {
                MessageBox.Show("Please enter whole or decimal numbers e.g. 10, 15.4, etc.", "Length Error");
                return false;
            }

            if (double.TryParse(lengthText, out number))
            {
                if (number < 0)
                {
                    MessageBox.Show("Please enter a measurement that isn't negative e.g. 10, 15.4, etc.", "Length Error");
                    return false;
                }
            }

            //Width validation checks
            if (string.IsNullOrEmpty(widthText))
            {
                MessageBox.Show("Please enter the width of the room e.g. 10, 15.4, etc.", "Width Error");
                return false;
            }

            if (Convert.ToDouble(widthText) > 100)
            {
                MessageBox.Show("Please enter a width that is below 100", "Width Error");
                return false;
            }

            if (!double.TryParse(widthText, out allowedChars))
            {
                MessageBox.Show("Please enter whole or decimal numbers e.g. 10, 15.4, etc.", "Width Error");
                return false;
            }

            if (double.TryParse(widthText, out number))
            {
                if (number < 0)
                {
                    MessageBox.Show("Please enter a measurement that isn't negative e.g. 10, 15.4, etc.", "Width Error");
                    return false;
                }
            }

            //Height validation checks
            if (string.IsNullOrEmpty(heightText))
            {
                MessageBox.Show("Please enter the height of the room e.g. 10, 15.4, etc.", "Height Error");
                return false;
            }

            if (Convert.ToDouble(heightText) > 100)
            {
                MessageBox.Show("Please enter a height that is below 100", "Height Error");
                return false;
            }

            if (!double.TryParse(heightText, out allowedChars))
            {
                MessageBox.Show("Please enter whole or decimal numbers e.g. 10, 15.4, etc.", "Height Error");
                return false;
            }

            if (double.TryParse(heightText, out number))
            {
                if (number < 0)
                {
                    MessageBox.Show("Please enter a measurement that isn't negative e.g. 10, 15.4, etc.", "Height Error");
                    return false;
                }
            }

            //Measurement validation checks
            if (string.IsNullOrEmpty(measureText))
            {
                MessageBox.Show("Please enter the measurement of the room", "Measurement Error");
                return false;
            }

            if (cboMeasurements.Text.Contains("Feet"))
            {
                return true;
            }
            else if (cboMeasurements.Text.Contains("Metres"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please select either Feet or Metres", "Measurement Error");
                return false;
            }
        }

        //Calculates the area and volume of the fixture
        private void CalculateRoom()
        {
            //Convert inputs
            length = Convert.ToDouble(txtLength.Text);
            width = Convert.ToDouble(txtWidth.Text);
            height = Convert.ToDouble(txtHeight.Text);
            measure = Convert.ToString(cboMeasurements.SelectedItem);

            //Area of the room
            area = length * width;

            //Volume of the room
            volume = length * width * height;
        }

        //Calculate the surface area of the walls
        private void CalculateWalls()
        {
            lengthDouble = length * height * 2;
            widthDouble = width * height * 2;
            walls = lengthDouble + widthDouble;

            //Converts the variables, 'area', 'volume', and 'walls' into feet or metres based on the measurement selected
            switch (measure)
            {
                case "Feet (Converted to Metres)":
                    area = area / 10.764;
                    volume = volume / 10.764;
                    walls = walls / 10.764;
                    MessageBox.Show("Area of the Room: " + area + " Square Metres" + Environment.NewLine + "Volume of the Room: " + volume + " Cubic Metres " + Environment.NewLine + "Surface Area of Walls: " + walls + " Cubic Metres ", "Measurements");
                    break;
                case "Metres (Converted to Feet)":
                    area = area * 10.764;
                    volume = volume * 10.764;
                    walls = walls * 10.764;
                    MessageBox.Show("Area of the Room: " + area + " Square Feet" + Environment.NewLine + "Volume of the Room: " + volume + " Cubic Feet " + Environment.NewLine + "Surface Area of Walls: " + walls + " Cubic Feet ", "Measurements");
                    break;
            }
        }

        //When btnNext is clicked, the inputs are validated first and, if valid, calculates the area, volume, and surface area of the room
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                return;
            }

            CalculateRoom();
            CalculateWalls();

            //Once the calculations are done, this form is hidden and 'Windows' is opened
            this.Hide();
            Windows f2 = new Windows();
            f2.ShowDialog();
        }
    }
}
