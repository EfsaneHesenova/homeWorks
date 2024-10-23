using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntarfaceTask.Models
{
    internal class StudentService : Student, IStudentService
    {
        public StudentService()
        {
            
        }
        public StudentService(string firstName, string lastName, string email, string phoneNumber, double gpa, string status, string major) : base(firstName, lastName, email, phoneNumber, gpa, status, major)
        {
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            Student newStudent = new Student(FirstName, LastName, Email, PhoneNumber, GPA, Status, Major);
            students[students.Length - 1] = newStudent;
        }

        public Student[] GEtAllStudents()
        {
            return students;
        }

        public Student GetStudentById(int id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Id == id)
                {
                    return students[i];
                }
            }
            return null;
        }

        public Student[] GetStudentsByName(string name)
        {
            int index = 0;
            Student[] rawArr = new Student[students.Length];
            string lowInput = name.ToLower();
            foreach (Student student in students)
            {
                if (name == FirstName.ToLower() || name == LastName.ToLower() )
                {
                    rawArr[index++] = student;
                }
            }
            if(index == 0)
            {
                return null;
            }

            return rawArr;  

        }

        public void RemoveStudent(int id, bool isSoftDelete)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Id == id)
                {
                    if (isSoftDelete)
                    {
                        students[i].Status = "Removed";
                    }
                    else
                    {
                        students[i] = null;
                    }
                }
            }
        }

        public void UpdateStudent(int id)
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Id = id;
                Console.WriteLine("""
                1.Firstname
                2.Lastname
                3.Email
                4.Phonenumber
                5.GPA
                6.Status
                7.Major
                """);
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        string newFirstName = Console.ReadLine();
                        newFirstName = FirstName;
                        break;
                    case 2:
                        string newLastName = Console.ReadLine();
                        newLastName = LastName;
                        break;
                    case 3:
                        string newEmail = Console.ReadLine();
                        newEmail = Email;
                        break;
                    case 4:
                        string newPhone = Console.ReadLine();
                        newPhone = PhoneNumber;
                        break;
                    case 5:
                        double newGPA = double.Parse(Console.ReadLine());
                        newGPA = GPA;
                        break;
                    case 6:
                        string newStatus = Console.ReadLine();
                        newStatus = Status;
                        break;
                    case 7:
                        string newMajor = Console.ReadLine();
                        newMajor = Major;
                        break;
                }
            }
        }
    }
}
