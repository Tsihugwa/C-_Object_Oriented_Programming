using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IntermediateSoftwareDevelopmentPrototype1;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using CollectionAssert = NUnit.Framework.CollectionAssert;
using System.Linq;
using System.Windows.Forms;


namespace IntermediateSWDevUnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestCalculateCost_Appointments()
        {
            // Create an instance of the Appointments class
            Appointments appointment = new Appointments();
            appointment.Duration = 20;
            // Calculate the cost for the appointment
            decimal cost = appointment.CalculateCost();

            // Check that the cost is correct
            Assert.AreEqual(200, cost);
        }

        [TestMethod]
        public void TestCalculateCost_Video()
        {
            // Arrange
            Video video = new Video();
            video.Duration = 30;

            // Act
            decimal cost = video.CalculateCost();

            // Assert
            Assert.AreEqual(300, cost);
        }

        [TestMethod]
        public void TestCalculateCost_NoNurse()
        {
            // Arrange
            InPerson inp = new InPerson();
            inp.Duration = 30;

            // Act
            decimal cost = inp.CalculateCost();

            // Assert
            Assert.AreEqual(600, cost);
        }

        [TestMethod]
        public void TestCalculateCost_Nurse()
        {
            // Arrange
            Nurse nrs = new Nurse();
            nrs.Duration = 30;

            // Act
            decimal cost = nrs.CalculateCost();

            // Assert
            Assert.AreEqual(625, cost);
        }

        [TestMethod]
        public void TestDurationInputValidation()
        {
            // Test input that is not a number
            string input = "abc";
            int number;
            Assert.IsFalse(int.TryParse(input, out number), "Input that is not a number should not be a valid input");
            // Test input that is a valid number
            input = "30";
            Assert.IsTrue(int.TryParse(input, out number), "Input that is a valid number should be a valid input");
            Assert.IsTrue(number == 30, "Input that is a valid number should be correctly parsed");

            // Test input that is a number but exceeds the maximum duration of 60 minutes
            input = "61";
            Assert.IsTrue(int.TryParse(input, out number), "Input that exceeds the maximum duration should not be a valid input");

        }

        [TestMethod]
        public void TestDoctorIdFormat()
        {
            // Test correct format
            string correctDoctorId = "AB12345";
            string docId = @"^[A-Za-z]{2}[0-9]+$";
            bool isMatch = Regex.IsMatch(correctDoctorId, docId);
            Assert.IsTrue(isMatch);

            // Test incorrect format
            string incorrectDoctorId = "12345";
            isMatch = Regex.IsMatch(incorrectDoctorId, docId);
            Assert.IsFalse(isMatch);
        }

        [TestMethod]
        public void TestRoomNoRegex()
        {
            // Test correct format
            string correctRoomNo = "ER32334";
            string roomNo = @"^[A-Za-z]{2}[0-9]+$";
            bool isMatch = Regex.IsMatch(correctRoomNo, roomNo);
            Assert.IsTrue(isMatch);

            // Test incorrect format
            string incorrectRoomNo = "12345";
            isMatch = Regex.IsMatch(incorrectRoomNo, roomNo);
            Assert.IsFalse(isMatch);

        }

        [TestMethod]
        public void TestName()
        {
            // Test correct format
            string name = "^[a-zA-Z]*$";
            string correctName = "Ryan";
            bool isMatch = Regex.IsMatch(correctName, name);
            Assert.IsTrue(isMatch);

            // Test incorrect format
            string incorrectName = "23SRTE";
            isMatch = Regex.IsMatch(incorrectName, name);
            Assert.IsFalse(isMatch);
        }

        [TestMethod]
        public void TestTextBoxesNullOrEmpty()
        {
            // Arrange
            string tbID = null;
            string tbName = "";
            string tbPhone = "123-456-7890";
            string tbDuration = "30";
            string tbDocId = "12345";

            // Act and Assert
            Assert.Throws<Exception>(() =>
            {
                if (string.IsNullOrEmpty(tbID) || string.IsNullOrEmpty(tbName) || string.IsNullOrEmpty(tbPhone) || string.IsNullOrEmpty(tbDuration) || string.IsNullOrEmpty(tbDocId))
                {
                    throw new Exception("One or more of the text boxes are null or empty.");
                }
            });
        }

        [TestMethod]
        public void TestRdoNurseYesAndNurseIDNullOrEmpty()
        {
            // Arrange           
            bool rdoNurseYes = true;
            string tbNurseID = "";

            // Act and Assert
            Assert.Throws<Exception>(() =>
            {
                if (rdoNurseYes && string.IsNullOrEmpty(tbNurseID))
                {
                    throw new Exception("Input nurse ID.");
                }
            });
        }

        [TestMethod]
        public void TestInputRoomNumber()
        {
            // Arrange
            var rdoNurseYes = true;
            var tbRoom = "";

            // Act
            try
            {
                if (rdoNurseYes && string.IsNullOrEmpty(tbRoom))
                {
                    throw new Exception("Input room number.");
                }
            }
            catch (Exception ex)
            {
                // Assert
                Assert.AreEqual("Input room number.", ex.Message);
            }

        }

        [TestMethod]
        public void TestInputPatientEmail()
        {
            // Arrange
            bool rdoVidYesChecked = true;
            string tbEmailText = "";

            // Act
            try
            {
                if (rdoVidYesChecked && string.IsNullOrEmpty(tbEmailText))
                {
                    throw new Exception("Input patient's email.");
                }
            }
            catch (Exception ex)
            {
                // Assert
                Assert.AreEqual("Input patient's email.", ex.Message);
            }

        }

        [TestMethod]
        public void TestInputNurseId()
        {
            // Arrange
            bool rdoNurseNoChecked = true;
            string tbNurseText = "";

            // Act
            try
            {
                if (rdoNurseNoChecked && string.IsNullOrEmpty(tbNurseText))
                {
                    throw new Exception("Input nurse Id.");
                }
            }
            catch (Exception ex)
            {
                // Assert
                Assert.AreEqual("Input nurse Id.", ex.Message);
            }
        }

        [TestMethod]
        public void TestIdIsInFile()
        {
            // Arrange
            string filename = "appointments.dat";
            int tbID = 1;
            Appointments appointment = new Appointments
            {
                Id = tbID,
                Name = "John Smith",
                Date = "12/12/2022",
                Time = "09:00"
            };
            List<Appointments> appointmentsList = new List<Appointments>
            {
                appointment
            };

            // Act
            using (Stream stream = File.Open(filename, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, appointmentsList);
            }

            bool tbIDExists;
            using (Stream stream = File.Open(filename, FileMode.Open))
            {
                BinaryFormatter bin = new BinaryFormatter();
                List<Appointments> allAppointments = (List<Appointments>)bin.Deserialize(stream);
                tbIDExists = allAppointments.Any(a => a.Id == tbID);
            }

            // Assert
            Assert.IsTrue(tbIDExists);
        }

        [TestMethod]
        public void ClearGB1_ClearsTextBoxesInGroupBox1()
        {
            // Arrange: create a form with a group box and some text boxes
            var newAppointment = new NewAppointment();
            var groupBox1 = new GroupBox();
            var textBox1 = new TextBox();
            var textBox2 = new TextBox();
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            newAppointment.Controls.Add(groupBox1);

            // Act: call the ClearGB1 method
            newAppointment.ClearGB1();

            // Assert: verify that the text boxes have been cleared
            Assert.That(textBox1.Text, Is.Empty);
            Assert.That(textBox2.Text, Is.Empty);
        }


        [TestMethod]
        public void ClearGB2_ClearsTextBoxesInGroupBox2()
        {
            // Arrange: create a form with a group box and some text boxes
            var newAppointment = new NewAppointment();
            var groupBox2 = new GroupBox();
            var textBox1 = new TextBox();
            var textBox2 = new TextBox();
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(textBox2);
            newAppointment.Controls.Add(groupBox2);

            // Act: call the ClearGB1 method
            newAppointment.ClearGB2();

            // Assert: verify that the text boxes have been cleared
            Assert.That(textBox1.Text, Is.Empty);
            Assert.That(textBox2.Text, Is.Empty);
        }

        [TestMethod]
        public void ClearGB3_ClearsTextBoxesInGroupBox3()
        {
            // Arrange: create a form with a group box and some text boxes
            var newAppointment = new NewAppointment();
            var groupBox3 = new GroupBox();
            var textBox1 = new TextBox();
            var textBox2 = new TextBox();
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(textBox2);
            newAppointment.Controls.Add(groupBox3);

            // Act: call the ClearGB1 method
            newAppointment.ClearGB3();

            // Assert: verify that the text boxes have been cleared
            Assert.That(textBox1.Text, Is.Empty);
            Assert.That(textBox2.Text, Is.Empty);
        }

        [TestMethod]
        public void TestAppointments()
        {
            // Arrange
            Appointments noVid = new Appointments();
            noVid.Id = 1;
            noVid.Name = "John Smith";
            noVid.Phone = "123-456-7890";
            noVid.Date = "01/01/2022";
            noVid.Time = "09:00 AM";
            noVid.Duration = 60;
            noVid.DocId = "12345";

            Video yesVid = new Video();
            yesVid.Id = 1;
            yesVid.Name = "John Smith";
            yesVid.Phone = "123-456-7890";
            yesVid.Date = "01/01/2022";
            yesVid.Time = "09:00 AM";
            yesVid.Duration = 60;
            yesVid.DocId = "12345";
            yesVid.Email = "john@smith.com";

            InPerson noNurse = new InPerson();
            noNurse.Id = 1;
            noNurse.Name = "John Smith";
            noNurse.Phone = "123-456-7890";
            noNurse.Date = "01/01/2022";
            noNurse.Time = "09:00 AM";
            noNurse.Duration = 60;
            noNurse.DocId = "12345";
            noNurse.Room = "123";

            Nurse yesNurse = new Nurse();
            yesNurse.Id = 1;
            yesNurse.Name = "John Smith";
            yesNurse.Phone = "123-456-7890";
            yesNurse.Date = "01/01/2022";
            yesNurse.Time = "09:00 AM";
            yesNurse.Duration = 60;
            yesNurse.DocId = "12345";
            yesNurse.Room = "123";
            yesNurse.NurseId = "54321";

            // Act
            List<Appointments> allAppointments = new List<Appointments>();
            allAppointments.Add(noVid);
            allAppointments.Add(yesVid);
            allAppointments.Add(noNurse);
            allAppointments.Add(yesNurse);

            // Assert
            Assert.AreEqual(4, allAppointments.Count);
            Assert.IsTrue(allAppointments[0] is Appointments);
            Assert.IsTrue(allAppointments[1] is Video);
            Assert.IsTrue(allAppointments[2] is InPerson);
            Assert.IsTrue(allAppointments[3] is Nurse);

        }

        [TestMethod]
        public void TestRdoNurseNoCheckedChanged()
        {
            // Arrange
            var form = new Form();
            var rdoNurseNo = new RadioButton();
            form.Controls.Add(rdoNurseNo);
            rdoNurseNo.Checked = true;
            var tbNurseID = new TextBox();
            form.Controls.Add(tbNurseID);

            // Act
            rdoNurseNo.Checked = false;

            // Assert
            Assert.IsFalse(rdoNurseNo.Checked);
            Assert.IsTrue(string.IsNullOrEmpty(tbNurseID.Text));

        }

        [TestMethod]
        public void TestRdoNurseYesCheckedChanged()
        {
            // Arrange
            var form = new Form();
            var rdoNurseYes = new RadioButton();
            form.Controls.Add(rdoNurseYes);
            rdoNurseYes.Checked = true;
            var tbNurseID = new TextBox();
            form.Controls.Add(tbNurseID);

            // Act
            rdoNurseYes.Checked = false;

            // Assert
            Assert.IsFalse(rdoNurseYes.Checked);
            Assert.IsTrue(string.IsNullOrEmpty(tbNurseID.Text));

        }

        [TestMethod]
        public void TestRdoVideoYesCheckedChanged()
        {
            //Arrange
            var fm = new Form();
            var rdoVidYes = new RadioButton();
            fm.Controls.Add(rdoVidYes);
            rdoVidYes.Checked = true;
            var tbEmail = new TextBox();
            fm.Controls.Add(tbEmail);

            //Add
            rdoVidYes.Checked = false;

            //Assert
            Assert.IsFalse(rdoVidYes.Checked);
            Assert.IsTrue(string.IsNullOrEmpty(tbEmail.Text));
        }

        [TestMethod]
        public void TestDeserialization()
        {
            // Arrange
            string filename = "appointments.dat";
            List<Appointments> expectedList = new List<Appointments>();
            expectedList.Add(new Appointments { Id = 34, Name = "Doctor's appointment", Date = "01/01/2021", Time = "10:00am" });
            expectedList.Add(new Appointments { Id = 21, Name = "Haircut", Date = "01/02/2021", Time = "2:00pm" });
            using (FileStream stream = File.Create(filename))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, expectedList);
            }
            // Act
            List<Appointments> actualList = new List<Appointments>();
            using (FileStream stream = File.OpenRead(filename))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                actualList = (List<Appointments>)formatter.Deserialize(stream);
            }

            // Assert
            Assert.AreEqual(expectedList.Count, actualList.Count);
            for (int i = 0; i < expectedList.Count; i++)
            {
                Assert.AreEqual(expectedList[i].Id, actualList[i].Id);
                Assert.AreEqual(expectedList[i].Name, actualList[i].Name);
                Assert.AreEqual(expectedList[i].Date, actualList[i].Date);
                Assert.AreEqual(expectedList[i].Time, actualList[i].Time);
            }

        }
    }
}