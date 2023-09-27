using System;
using System.Collections.Generic;
using LlasusITELEC1CC.Models;
using LlasusITELEC1CC.Services;


namespace LlasusITELEC1CC.Services
{

    public class MyFakeDataService : IMyFakeDatasService
    {
        public List<Student> StudentList { get; }
        public MyFakeDataService() { //instructor
           
            StudentList = new List<Student>
            {

                new Student()
                {
                    Id= 1,FirstName = "Don",LastName = "Flaming", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.5, Email = "faxe1@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Beate",LastName = "Ronas", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1, Email = "z235yx@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Fetz",LastName = "Dogs", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "agerkiel@gmail.com"
                }
            };
        }

        }
    } 

