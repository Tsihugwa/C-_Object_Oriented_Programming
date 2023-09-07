The system should be made available as a client-server application but your task has been simplified. You are required to develop a prototype application that will run on a standalone PC but you should make use of separation of concerns so that the job of transferring the application to the event management company’s client-server environment in the future will be possible with minimum adjustments to your code.
An example XML file showing the structure of the data is provided below:
<?xml version="1.0" encoding="utf-8" ?>
<SpeedyEat>
<Driver name="Liz Gandy">
<Journey date="16/02/2023">
<Collection>SR6 0DD</Collection>
<Delivery>NE10 4XX</Delivery>
<Distance>3</Distance>
</Journey>
<Journey date="21/03/2023">
<Collection>DH3 2YZ</Collection>
<Delivery>SR1 5XY</Delivery>
<Distance>12</Distance>
</Journey>
</Driver>
</SpeedyEat>
This XML file represents the data for a driver called Liz Gandy, with two journeys completed; 16th February
2023 of 3 miles from SR6 0DD to NE10 4XX and 21st March 2023 of 12 miles from DH3 2YZ to SR1 5XY.
The data for each driver will be stored in a separate file and each driver may have any number of journeys recorded, which may be on different dates in the same file.
You have been tasked with implementing this application as a multi-threaded windows application, making use of the Producer/Consumer pattern and LINQ query language. You have been given the following list of functional requirements for the system:
1. Select and queue the processing of multiple XML files.
2.  Merge the data from multiple XML files and carry out the necessary processing in order to generate
the following output reports (via display on a Windows Form):
3.  A list of drivers, with the ability to select and view details of all journeys made by that driver
(including the date, collection and delivery postcodes plus the journey distance)
Page 3 of 5
4.  A list of drivers, sorted alphabetically, with the total distance of journeys made by each driver
5.  A list of dates, with the total distance covered on each date (across all drivers), sorted by date
5.  The longest journey recorded by the system (the driver, date and distance for the highest
recorded distance across all amalgamated files
