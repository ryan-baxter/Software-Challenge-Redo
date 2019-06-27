using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomRedo
{
    public partial class Doors : Form
    {
        double length;
        double width;
        double area;
        public static double walls;
        double testValue;
        double fetchedArea;

        public Doors()
        {
            InitializeComponent();
        }

        private new bool Validate()
        {
            //Validation variables
            double allowedChars;
            double number = 0;
            string lengthText = txtDoorLength.Text;
            string widthText = txtDoorWidth.Text;

            //Length validation checks
            if (string.IsNullOrEmpty(lengthText))
            {
                MessageBox.Show("Please enter the length of the fixture e.g. 10, 15.4, etc.", "Length Error");
                return false;
            }

            if (lengthText.Length > 4)
            {
                MessageBox.Show("Please enter a reasonable length e.g. 10, 15.4, etc.", "Length Error");
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
                MessageBox.Show("Please enter the width of the fixture e.g. 10, 15.4, etc.", "Width Error");
                return false;
            }

            if (widthText.Length > 4)
            {
                MessageBox.Show("Please enter a reasonable width e.g. 10, 15.4, etc.", "Width Error");
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

            if (!string.IsNullOrEmpty(widthText))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Error");
                return false;
            }
        }

        //Recalculate the surface area of the room whenever a new fixture is added
        private void RecalculateWalls()
        {
            walls = walls - area;
            lblAreaOfWalls.Text = "Surface Area of Walls: " + Convert.ToString(walls);
        }

        //Calculates the area of the fixture
        private void CalculateWindowFixture()
        {
            //Convert inputs
            length = Convert.ToDouble(txtDoorLength.Text);
            width = Convert.ToDouble(txtDoorWidth.Text);

            //Area of the fixture
            area = length * width;
        }

        //Before a fixture is added, a check is conducted to make sure the surface area doesn't go below 0 when the fixture is added
        private void CheckWallMeasurements()
        {
            //If the surface area (minus the area of the fixture) doesn't equal 0, the program calculates the fixture,
            //takes it away from the surface area of the walls, and adds the fixture to lstDoors
            testValue = walls - area;
            if (testValue >= 0)
            {
                CalculateWindowFixture();
                RecalculateWalls();
                lstDoors.Items.Add("Door Area = " + area);
            }
            //If the testValue is less than 0, an error message is thrown back
            else
            {
                MessageBox.Show("The surface area of the walls can't go below 0", "Error");
            }
        }

        //This procedure removes the last fixture in the listbox, and the area of the fixture is added back to the 'walls' variable
        private void FetchLastArea()
        {
            if (lstDoors.Items.Count > 0)
            {
                string subjectString = lstDoors.Items[lstDoors.Items.Count - 1].ToString();
                string numbersOnly = Regex.Replace(subjectString, "[^0-9.]", "");
                fetchedArea = Convert.ToDouble(numbersOnly);
            }

            walls = walls + fetchedArea;
            lblAreaOfWalls.Text = "Surface Area of Walls: " + Convert.ToString(walls);
        }

        //Hides this form and opens the previous form, 'Windows'
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Windows f2 = new Windows();
            f2.ShowDialog();
        }

        //When a new fixture is added, the inputs are validated first and, if valid, passes the inputs onto CheckWallMeasurements()
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                return;
            }

            CheckWallMeasurements();
        }

        //When btnRemove is clicked, if there is an item in lstDoors, the last item in the list is removed and FetchLastArea() is executed
        //Otherwise, an error message is thrown back
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstDoors.Items.Count < 1)
            {
                MessageBox.Show("There are no fixtures to remove", "Removal Error");
            }
            else
            {
                FetchLastArea();
                lstDoors.Items.RemoveAt(lstDoors.Items.Count - 1);
            }
        }

        //When the form first loads, the previous value of 'walls' from 'Windows' is fetched, and displayed to the user
        private void Doors_Load(object sender, EventArgs e)
        {
            walls = Convert.ToDouble(Windows.walls);
            lblAreaOfWalls.Text = "Surface Area of Walls: " + Convert.ToString(walls);
        }

        //Hides this form and opens the final form, 'Results'
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Results f4 = new Results();
            f4.ShowDialog();
        }
    }
}
