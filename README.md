# Software Challenge (Redo)

Enclosed in this repository is an application that can be used to calculate the area and volume of a room, taking into account any window and door fixtures within the room, and how much paint will be needed in order to paint the room. This is a redo of my previous attempt called, "Room-Calculator".

## Getting Started

The next few sections will go over the instructions on how to get the application up and running on your machine for development/testing purposes. See the 'Deployment' section for information on how to deploy and run the application.

### Prerequisites

In order to get the application working, you will need to install Visual Studio on your machine. This section will cover how to install this software on your machine. If you already have Visual Studio installed on your machine, you can skip this section of the file. Use the link provided under the 'Built With' section to get to the Visual Studio website.

#### Step 1
Use the link provided above to open the Visual Studio website and download the Visual Studio IDE. When you hover over the 'Download Visual Studio' button, download the 'Community 2019' version of Visual Studio.

#### Step 2
Once the executable file has downloaded, run the file and follow the instructions in order to install Visual Studio on your machine.

#### Step 3
After the installation process, you will be presented with a selection of 'Web & Cloud' and 'Windows' workloads. Select the option entitled, ".NET desktop development" and click 'Install'.

Once Visual Studio Community 2019 has installed on your machine, you will be able to open and run the application.
### Installing

This section will cover a step by step process on how to install the software application on your machine and get it up and running.

#### Step 1
On the repository page for the software application, click on the 'Clone or download' button in the top right, then click on 'Download ZIP'. The application will be downloaded as a .zip file to your machine.

#### Step 2
Extract the application folder from the ZIP file and save it anywhere to your machine. Once extracted, open the folder and access the solution file, called 'RoomRedo.sln'. The application will now open up in Visual Studio.

In Visual Studio, click the 'Start' button in the navigation bar at the top of the screen to run the application.

## Deployment

Once the application is up and running, you will be presented with a window form entitled, "Add Room Measurements". On this form, you will be able to add the length, width, and height of the room you are calculating, as well as the measurements you used (either Feet or Metres) to measure the room.

```
For example, you can enter whole (5, 14, etc.) and decimal (24.6, 2.15, etc.) numbers for each input, except the 'Measurement' field.
```

Once you have input the length, width, height, and measurement of the room, click 'Next' to move onto the 'Add Windows' form. On this form, you will be able to add the length and width of each window fixture. 

```
For example, you can enter a whole (5, 14, etc.) or decimal (24.6, 2.15, etc.) number for each fixture.
```

Each fixture you add will be added to the listbox at bottom of the form, with the surface area of all the walls constantly being displayed and updated with each fixture added.

```
For example, a surface area of 253 and a fixture of 40 will update the surface area of the walls to 213.
```

If there you wish to remove the last fixture you added to the listbox, click the 'Remove' button to remove the latest fixture; the area of the removed fixture will be added back to the surface area of the walls and updated. Once you have entered all the window fixtures you need, click the 'Next' button.

The 'Add Doors' form is similar to the previous form; on this form, you can enter the length and width of each door fixture within the room. Each fixture you add will be added to the listbox at bottom of the form, with the surface area of all the walls constantly being displayed and updated with each fixture added. If you added any window fixtures on the previous form, the surface area of the walls (minus the total area of the each window fixture) will be brought across to this form.

```
For example, if the surface area of the walls was 213, the area of each door fixture will be taken away from this.
```

Again, if you wish to remove the last fixture you added, click the 'Remove' button to remove the latest fixture; the area of the removed fixture will be added back to the surface area of the walls and updated. Once you have entered all the window fixtures you need, click the 'Next' button.

On the last form (entitled 'Results'), all the calculations you entered will be displayed in a listbox, displaying:
* The area of the room
* The volume of the room
* The surface area of all the walls (excluding the fixtures), and
* The amount of paint needed to paint the room.

Once you have finished with the application, click the 'Exit' button to close the application.

## Built With

* [Visual Studio](https://visualstudio.microsoft.com/)

## Authors

* **Ryan Baxter** - [ryan-baxter](https://github.com/ryan-baxter)
