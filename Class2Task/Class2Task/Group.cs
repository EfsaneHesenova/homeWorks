using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2Task
{
    internal class Group
    {
        private string _groupName;

        public string GroupName
        {
            get
            {
                return _groupName;
            }
            set
            {
                _groupName = value;
                Array.Resize(ref AllGroups, AllGroups.Length + 1);
                AllGroups[AllGroups.Length - 1] = _groupName;
            }
        }
        public string Shift { get; set; }
        public static string[] AllGroups = new string[0];
        public Student[] Students = new Student[0];

        public Group(string groupName, string shift)
        {
            GroupName = groupName;
            Shift = shift;
        }
        public void AddStudent(string name, string surname, string gender, int age, int phonenumber, string group)
        {
            Student student = new Student(name, surname, gender, age, phonenumber, group);
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public bool FindStudent(string name)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public void AbSent(string name)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Name == name)
                {
                    Students[i].Limit --;
                    break;
                }
            }
        }
    }
}
