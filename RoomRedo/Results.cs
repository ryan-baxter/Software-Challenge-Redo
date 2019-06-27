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
    public partial class Results : Form
    {
        double area;
        double volume;
        double walls;
        double wallsValue;
        int paintNeeded;
        string measure;
        string mass;

        public Results()
        {
            InitializeComponent();
        }

        //Closes the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //If the room was calculated in metres, 10m² is taken away from 'wallsValue', and adds 1 to 'paintNeeded'
        private void CalculatePaintMetres()
        {
            paintNeeded = 0;
            wallsValue = walls;

            for (int i = 0; 1 < wallsValue;)
            {
                paintNeeded = paintNeeded + 1;
                wallsValue = wallsValue - 10;
            }
        }

        //If the room was calculated in feet, 400ft² is taken away from 'wallsValue', and adds 1 to 'paintNeeded'
        private void CalculatePaintFeet()
        {
            paintNeeded = 0;
            wallsValue = walls;

            for (int i = 0; 1 < wallsValue;)
            {
                paintNeeded = paintNeeded + 1;
                wallsValue = wallsValue - 400;
            }
        }

        //Prints the results of the application into lstResults
        private void PrintResults()
        {
            lstResults.Items.Add("The area of the room is: " + area);
            lstResults.Items.Add("The volume of the room is: " + volume);
            lstResults.Items.Add("The total area of the walls (excluding doors and windows) is: " + walls);
            lstResults.Items.Add("The amount of paint needed to do the walls " + mass + paintNeeded + ", covering " + measure);
        }

        //Using the variable 'measure', the program checks what measurement was selected from the 'Measurements' form,
        //and calculates the amount of paint needed based on the result
        private void MetresOrFeet()
        {
            switch (measure)
            {
                case "Feet (Converted to Metres)":
                    measure = "10m² per Litre";
                    mass = "(in Metres) is ";
                    CalculatePaintMetres();
                    break;
                case "Metres (Converted to Feet)":
                    measure = "400ft² per Gallon";
                    mass = "(in Gallons) is ";
                    CalculatePaintFeet();
                    break;
            }
        }

        //When the form first loads, the variables 'area', 'volume', 'measure', and 'walls' is fetched from the previous forms
        private void Results_Load(object sender, EventArgs e)
        {
            area = Convert.ToDouble(Measurements.area);
            volume = Convert.ToDouble(Measurements.volume);
            measure = Measurements.measure;
            walls = Convert.ToDouble(Doors.walls);

            MetresOrFeet();
            PrintResults();
        }
    }
}
