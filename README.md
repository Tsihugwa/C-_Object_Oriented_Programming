# C-_Object_Oriented_Programming
Object Oriented Programming final prototype
This is a prototype for a software application that allows users to schedule appointments. The application includes four different types of appointments: in-person with no nurse, in-person with a nurse, video with no nurse, and video with a nurse.

The NewAppointment form allows users to input information about their appointment, including the patient's name, phone number, date and time of the appointment, duration of the appointment, and the ID of the doctor. If the appointment is a video appointment, the user can also input the patient's email. If the appointment is in-person with a nurse, the user can input the room number and the ID of the nurse.

When the user clicks the "Summary" button, the information inputted is used to create objects for the different types of appointments. These objects are then added to a list called allAppointments. The list is then displayed in a list view on the form.

The NewAppointment form also includes a "Save" button, which allows the user to save the list of appointments to a file called Appointments.dat. The form also includes a "Load" button, which allows the user to load the list of appointments from the file.

Requirements
To run this prototype, you will need:

.NET Framework 4.6.1 or higher
Visual Studio 2015 or higher
How to Run
Clone or download the repository to your local machine.
Open the solution file IntermediateSoftwareDevelopmentPrototype1.sln in Visual Studio.
Build and run the solution.
Follow the prompts on the NewAppointment form to input information about the appointment and view the list of appointments.
Use the "Save" and "Load" buttons to save and load the list of appointments.


AllAppointments
This is a C# Windows Form application that displays a list of appointments. The AllAppointments class extends the Form class and has a constructor that takes a list of Appointments objects as a parameter. The AllAppointments class has a method called AllAppointments_Load which populates a ListView control with appointment data. There are also several buttons that allow the user to navigate to different forms, clear the filter panel, and filter the appointments by type.

Usage
To use this application, you will need to create an instance of the AllAppointments class and pass it a list of Appointments objects. You can then call the Show method to display the form.

Copy code
List<Appointments> appointments = GetAppointments(); // Replace with a method to retrieve your appointments

AllAppointments allAppointments = new AllAppointments(appointments);
allAppointments.Show();
Features
Display a list of appointments in a ListView control
Navigate to the NewAppointment form to create a new appointment
Clear the filter panel to show all appointments
Filter the appointments by type (InPerson, Nurse, Video, or Appointment)
Requirements
.NET Framework 4.5 or higher
A List of Appointments objects to display in the ListView control
File List
AllAppointments.cs: Contains the code for the AllAppointments class
Appointments.cs: Contains the code for the base Appointments class
InPerson.cs: Contains the code for the InPerson class which extends the Appointments class
Nurse.cs: Contains the code for the Nurse class which extends the Appointments class
Video.cs: Contains the code for the Video class which extends the Appointments class
Form1.cs: Contains the code for the main form
NewAppointment.cs: Contains the code for the NewAppointment form


This code contains a Form1 class that serves as a main menu for a scheduling application. The Form1 class contains three buttons:

btnExit: closes the window
btnNewAppointments: opens a new window for creating appointments
btnAppointments: opens a window displaying all appointments
The btnAppointments button also deserializes data from the "Appointments.dat" file and displays it in the AllAppointments form. If the file does not exist or is empty, a message box will appear saying "No data available to display".
  
The Appointments file shows this project contains three classes: Appointments, Video, and InPerson. Appointments is the base class and Video and InPerson inherit from it. All three classes implement the ICostable interface which allows them to calculate the cost of an appointment.

The Appointments class has private variables for appointment ID, date, time, duration, patient name, phone number, and doctor ID. It also has public properties to access these variables. The Appointments class has two constructors - one with no parameters and one with parameters for all of its private variables. It also has a CalculateCost method which calculates the cost of the appointment based on the duration and a staff cost of £10 per minute.

The Video class inherits from Appointments and adds an additional private variable for the patient's email. It has a public property for this variable and a constructor with parameters for all of the variables from both the Appointments and Video classes. It also has a CalculateCost method which calculates the cost of the appointment based on the duration and a staff cost of £10 per minute.

The InPerson class also inherits from Appointments and adds a private variable for the room the appointment will be held in. It has a public property for this variable and two constructors - one with parameters for all of the variables from both the Appointments and InPerson classes, and one with parameters for the variables in the Appointments class. It has a CalculateCost method which calculates the cost of the appointment based on the duration and a staff cost of £25 per minute for appointments less than or equal to 10 minutes, and £35 per minute for appointments over 10 minutes.

Please feel free to explore the code and use it as a reference for your own project. If you have any questions or suggestions, don't hesitate to reach out to us. Thank you for visiting!
