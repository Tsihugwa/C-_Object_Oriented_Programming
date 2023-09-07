provide a client-server application where doctors can log on and obtain their appointment information directly but, before embarking on such a project, they initially require a single-user, stand-alone system which will enable the receptionists to manage the lists more efficiently than manually generating the text file. 

The data fields recorded for each Appointment are listed in the table below:

Name	          Description	                                                    Example
ID	            Unique code to identify the appointment	                         9876
Date	          Date of the appointment	                                         15/11/22
Time	          Time of the appointment	                                         10:30
Duration	      Length of time allocated to the appointment (in minutes)	       10
Patient name	  Name of patient                                                  Buzz Lightyear
Phone number	  Contact phone number for the patient	                           07123456789
Doctor ID	      ID number of the doctor allocated to the appointment	           GP10

In-person appointments have the following additional data fields:

Room allocated	Code which identifies the room which will be used for the appointment	TR5
Nurse required	Whether additional support from a nurse will be required for this appointment	Yes or No

If the in-person appointment requires additional support from a nurse, then the ID number of the nurse should also be recorded (e.g. NS2).

Virtual appointments have the following additional data field:

Video call	Whether or not the appointment will be held via video calling	Yes or No

If a virtual appointment has an associated video call requirement, then an email address should also be recorded, to send joining instructions and a link for the call.

You have been tasked with developing this application in C# (using a multi-form windows application) and have been given the following list of functional requirements for the system: 
•	Add the details of an appointment. All data must be entered by the user and not generated automatically; however, bookings with duplicate id numbers must be prevented. 
•	Display a list of all appointments. 
•	Store the appointments list to .dat file.
•	Retrieve the appointments list from .dat when the application first loads.
•	Filter bookings: 
o	A list of all in-person appointments including room allocated and nurse ID (where relevant).
o	A list of all virtual appointments and email address for video call where relevant.


Software Development Methodology

The software is being developed within an agile framework  

Sprint 1 deliverables include the alpha design documentation and software prototype. 

Sprint 2 deliverables include the final software prototype, updated design documentation and unit tests for data persistence functionality.  

Both prototypes should be C# forms applications implemented using Visual Studio 2019 or 2022. The final prototype must be a multi-form application which incorporates a class from the Generics Collections Framework, Data Serialization, and declaration, throwing, and catching, of a new exception type. You should apply ALL the coding conventions used in the module including naming, layout and commenting: Marks will be explicitly awarded on this and poor presentation may adversely affect marks for other aspects if it obscures the correctness of otherwise satisfactory code.

This portfolio element covers the assessment of Sprint 2.
