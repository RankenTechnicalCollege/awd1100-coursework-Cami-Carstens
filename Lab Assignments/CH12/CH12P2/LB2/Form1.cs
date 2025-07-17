using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        Conference[] conferenceName = new Conference[20];
        int conferenceCount = 5;
        public Form1()
        {
            InitializeComponent();
            conferenceName[0] = new Conference
            {
                GroupName = "Future Leaders of Tech",
                StartingDate = new DateTime(2025, 10, 1),
  
                Attendees = 100,
                Room = Room.ROOM_101
            };
            conferenceName[1] = new Conference
            {
                GroupName = "Manifest your dreams now",
                StartingDate = new DateTime(2028, 11, 5),
                
                Attendees = 50,
                Room = Room.ROOM_102
            };
            conferenceName[2] = new Conference
            {
                GroupName = "Education is Power",
                StartingDate = new DateTime(2026, 12, 10),
                
                Attendees = 75,
                Room = Room.ROOM_201
            };
            conferenceName[3] = new Conference
            {
                GroupName = "Business-Taking you to the next level",
                StartingDate = new DateTime(2025, 1, 15),
                
                Attendees = 120,
                Room = Room.ROOM_202
            };
            conferenceName[4] = new Conference
            {
                GroupName = "Astrophysicist for everyday people",
                StartingDate = new DateTime(2027, 2, 20),
                
                Attendees = 80,
                Room = Room.ROOM_301
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            if (conferenceCount >= 20)
            {
                lblResult.Visible = true;
                lblResult.Text = "Maximum number of conferences reached.";
                return;
            }

            string groupName = txtGroupName.Text;
            string StartingDate = txtStartingDate.Text;
            string endingDate = txtEndSearch.Text;
            string room = txtRoom.Text;

            if (string.IsNullOrEmpty(groupName)
                || string.IsNullOrEmpty(StartingDate)
                || string.IsNullOrEmpty(room))
            {
                lblResult.Visible = true;
                lblResult2.Text = "";
                lblResult3.Text = "";
                lblResult.Text = "Please fill in all fields.";
                return;
            }

            //Attendees validation

            if (!int.TryParse(txtAttendees.Text, out int attendees))
            {
                lblResult.Visible = true;
                lblResult.Text = "Invalid number of attendees.";
                return;

            }

            //StartingDate validation
            if (!DateTime.TryParse(txtStartingDate.Text, out DateTime startingDate))
            {
                lblResult.Visible = true;
                lblResult.Text = "Invalid starting date format.";
                return;
            }

            //ROOM enum validation
            Room aRoom;

            switch (room.ToLower())
            {
                case "101":
                    aRoom = Room.ROOM_101;
                    break;
                case "102":
                    aRoom = Room.ROOM_102;
                    break;
                case "201":
                    aRoom = Room.ROOM_201;
                    break;
                case "202":
                    aRoom = Room.ROOM_202;
                    break;
                case "301":
                    aRoom = Room.ROOM_301;
                    break;
                case "302":
                    aRoom = Room.ROOM_302;
                    break;
                default:
                    lblResult.Visible = true;
                    lblResult.Text = "Invalid room.";
                    return;
            }

            //after validation, create a new conference object
            Conference newConference = new Conference
            {
                GroupName = groupName,
                StartingDate = startingDate,
               
                Attendees = attendees,
                Room = aRoom
            };


            conferenceName[conferenceCount] = newConference;
            conferenceCount++;

            lblResult.Visible = true;
            lblResult3.Text = $"Total Conferences: {conferenceCount}/20 \n"+
             $"Total Attendees: {CalculateTotalAttendees()}";
            lblResult2.Visible = true;
            lblResult2.Text = "Conference added successfully!";


            txtGroupName.Clear();
            txtStartingDate.Clear();
            txtAttendees.Clear();
            txtRoom.Clear();


            txtGroupName.Focus();

            


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblBeginEndSearch.Text = string.Empty;


            bool foundBeginDate = DateTime.TryParse(txtBeginSearch.Text, out DateTime beginSearch);
            bool foundEndDate = DateTime.TryParse(txtEndSearch.Text, out DateTime endSearch);

            if (!foundBeginDate || !foundEndDate)
            {
                lblBeginEndSearch.Visible = true;
                lblBeginEndSearch.Text = "Invalid dates.";
                return;
            }
            bool found = false;
            int matchingConferences = 0;
            for (int i = 0; i < conferenceCount; i++)
            {
                Conference conf = conferenceName[i];

                // check if the date matches
                if (conf.StartingDate >= beginSearch.Date
                    && conf.StartingDate <= endSearch.Date)
                   
                {

                    lblBeginEndSearch.Visible = true;
                    lblBeginEndSearch.Text += conf.Display() + "\n";
                    matchingConferences += conf.Attendees;
                    found = true;
                }

            }
            if (!found)
            {
                lblBeginEndSearch.Visible = true;
                lblBeginEndSearch.Text = "No conference found with that name or date.";
            }


        }

        //get total attendees using a method
        private int CalculateTotalAttendees()
        {
            int totalAttendees = 0;
            for (int i = 0; i < conferenceCount; i++)
            {
                totalAttendees += conferenceName[i].Attendees;
            }
            return totalAttendees;
        }
    }
}
    
