using System;
using System.Collections.Generic;
using System.Text;
using demo.Models;
using Xamarin.Forms;

namespace demo.Services
{
    public class StatusService
    {
        public static Me GetMyInfo()
        {
            Me MyInfo = new Me
            {
                MeId = 1,
                Name = "Tahir",
                PhoneName = "05555555",
                ProfileImage = "Flora.jpg",
                Status = new Status
                {
                    StatusID = 1,
                    Description = "Xamarin Developerler",
                    Image = "hmo.jpg",
                    Pushdate = "30 deq evvel"
                }
            };
            return MyInfo;
        }

        public static List<Status> GetUpdates()
        {
            List<Status> Updates = new List<Status> {


            new Status
            {
                StatusID = 2,
                Description = "Java Developerler ",
                Image = "Flora.jpg",
                Pushdate = "30 deq evvel",
                Contact = new Contact
                {
                    ContactId = 2,
                    Name = "Tahir",
                    PhoneNumber = "5555555555555",
                    ProfileImage = "Flora.jpg"
                }
            },
            new Status
            {
                StatusID = 3,
                Description = "Java Developerler ",
                Image = "Flora.jpg",
                Pushdate = "30 deq evvel",
                Contact = new Contact
                {
                    ContactId = 3,
                    Name = "Tahir",
                    PhoneNumber = "5555555555555",
                    ProfileImage = "Flora.jpg"
                }
            },
            new Status
            {
                StatusID = 4,
                Description = "Java Developerler ",
                Image = "Flora.jpg",
                Pushdate = "30 deq evvel",
                Contact = new Contact
                {
                    ContactId = 4,
                    Name = "Tahir",
                    PhoneNumber = "5555555555555",
                    ProfileImage = "Flora.jpg"
                }
            }

        };
            return Updates;
    }
    }

                
    }

