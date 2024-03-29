﻿using System;
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
    public partial class Windows : Form
    {
        //Fixture Measurements & Area
        double length;
        double width;
        double area;
        public static double walls;
        double testValue;
        double fetchedArea;

        public Windows()
        {
            InitializeComponent();
        }

        //Validation Checks
        private new bool Validate()
        {
            //Validation Variables
            double allowedChars;
            double number = 0;
            string lengthText = txtWindowLength.Text;
            string widthText = txtWindowWidth.Text;

            //Length validation checks
            if (string.IsNullOrEmpty(lengthText))
            {
                MessageBox.Show("Please enter the length of the fixture e.g. 10, 15.4, etc.", "Length Error");
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
                MessageBox.Show("Please enter the width of the fixture e.g. 10, 15.4, etc.", "Width Error");
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
            length = Convert.ToDouble(txtWindowLength.Text);
            width = Convert.ToDouble(txtWindowWidth.Text);

            //Area of the fixture
            area = length * width;
        }

        //Before a fixture is added, a check is conducted to make sure the surface area doesn't go below 0 when the fixture is added
        private void CheckWallMeasurements()
        {
            //If the surface area (minus the area of the fixture) doesn't equal 0, the program calculates the fixture,
            //takes it away from the surface area of the walls, and adds the fixture to lstWindows
            testValue = walls - area;
            if (testValue >= 0)
            {
                CalculateWindowFixture();
                RecalculateWalls();
                lstWindows.Items.Add("Window Area = " + area);
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
            if (lstWindows.Items.Count > 0)
            {
                string subjectString = lstWindows.Items[lstWindows.Items.Count - 1].ToString();
                string numbersOnly = Regex.Replace(subjectString, "[^0-9.]", "");
                fetchedArea = Convert.ToDouble(numbersOnly);
            }

            walls = walls + fetchedArea;
            lblAreaOfWalls.Text = "Surface Area of Walls: " + Convert.ToString(walls);
        }

        //Hides this form and opens the previous form, 'Measurements'
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Measurements f1 = new Measurements();
            f1.ShowDialog();
        }

        //Hides this form and opens the next form, 'Doors'
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doors f3 = new Doors();
            f3.ShowDialog();
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

        //When the form first loads, the previous value of 'walls' from 'Measurements' is fetched, and displayed to the user
        private void Windows_Load(object sender, EventArgs e)
        {
            walls = Convert.ToDouble(Measurements.walls);
            lblAreaOfWalls.Text = "Surface Area of Walls: " + Convert.ToString(walls);
        }

        //When btnRemove is clicked, if there is an item in lstWindows, the last item in the list is removed and FetchLastArea() is executed
        //Otherwise, an error message is thrown back
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lstWindows.Items.Count < 1)
            {
                MessageBox.Show("There are no fixtures to remove", "Removal Error");
            }
            else
            {
                FetchLastArea();
                lstWindows.Items.RemoveAt(lstWindows.Items.Count - 1);
            }
        }
    }
}
