# C-_Object_Oriented_Programming
Appointments
This is a C# Windows Forms application that allows users to schedule appointments with a healthcare provider. The application includes four types of appointments: AppDetails, Virtual, InPerson, and Nurse. Each type of appointment includes unique details such as email address for virtual appointments and room number for in-person appointments. The application also includes options to display the appointment details for each type and a summary of all appointments.
This project consists of four classes: AppDetails, Virtual, Nurse and InPerson. The AppDetails class contains private variables and corresponding public properties for an appointment, including the appointment ID, patient name, date, time, duration, phone number, and doctor ID. It also includes a constructor with no parameters and a constructor with parameters, as well as a ToString method to allow for the summary of the class.

The Virtual class is a subclass of AppDetails and includes an additional private variable and corresponding public property for the patient's email address. It also includes a constructor with parameters that includes all of the variables from the AppDetails class as well as the email variable. It also includes a ToString method to allow for the summary of the class.

The InPerson class is also a subclass of AppDetails and includes an additional private variable and corresponding public property for the room the appointment will take place in. It includes a constructor with no parameters, a constructor with parameters that includes all of the variables from the AppDetails class as well as the room variable, and a ToString method to allow for the summary of the class.

Overall, this project is meant to keep track of appointments and their details, including virtual and in-person appointments. Thank you for visiting the AppDetails project on GitHub.
Getting Started
To use this application, clone or download the repository and open the solution file in Visual Studio. Run the application to access the scheduling and display options.

Prerequisites
Visual Studio
C# Windows Forms application
Built With
C#
Visual Studio
Author- Ryan Tsihugwa
![Screenshot_20230106_234648](https://user-images.githubusercontent.com/101879237/211123343-c90c4eab-a7d5-4540-8c58-af019315beba.png)
![Screenshot_20230106_234918](https://user-images.githubusercontent.com/101879237/211123363-307cd098-8a26-4230-bc6a-a416e1f38fbc.png)
