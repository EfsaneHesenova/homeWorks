using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Class2Task
{
    internal class Student
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        private string _gender;
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                if (value == "male" || value == "female")
                {
                    _gender = value;
                }
                else
                {
                    Console.WriteLine("invalid gender");
                }
            }
        }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }

        private int _limit = 24;
        public int Limit
        {
            get
            {
                return _limit; 
            }
            set
            {
                if (value == 0 )
                {
                    Console.WriteLine("siz kesilmisiz");
                }
                else 
                {
                    _limit = value;
                }
            }
        }

        private string _studentGroup;
        public string StudentGroup 
        { 
            get
            {
                return _studentGroup;
            }
            set
            {
                for (int i = 0; i < Group.AllGroups.Length; i++)
                {
                    if (Group.AllGroups[i] == value)
                    {
                        _studentGroup = value;
                        return;
                    }
                }

                Console.WriteLine("Invalid Group");
            }
        }

        public Student(string name, string surname, string gender, int age, int phonenumber, string studentGroup)
        {
            Name = name;
            SurName = surname;
            Gender = gender;
            Age = age;
            PhoneNumber = phonenumber;
            StudentGroup = studentGroup;
        }

        
    }
}
