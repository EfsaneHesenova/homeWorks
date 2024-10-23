using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntarfaceTask.Models
{
    internal interface IStudentInterface
    {
        Student GetStudentById(int id);
        Student[] GEtAllStudents();
        Student[] GetStudentsByName(string nam);
        void AddStudent(Student student);
        void UpdateStudent(int id);
        void RemoveStudent(int id, bool isSoftDelete);
    }
}
