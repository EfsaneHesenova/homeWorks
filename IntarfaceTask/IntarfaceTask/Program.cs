using IntarfaceTask.Models;

namespace IntarfaceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StudentService obj = new StudentService();
            bool run = true;

            while (run)
            {
                Console.WriteLine("""
                1.addstudent
                2.updatestudent
                3.removestudent
                4.findallstudent
                5.findstudentbyid
                6.findstudentbyname
                7.exit

                Select an option:
                """);
                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        Console.WriteLine("firstname:");
                        string userName = Console.ReadLine();
                        Console.WriteLine("lastname:");
                        string userLastName = Console.ReadLine();
                        Console.WriteLine("email:");
                        string userEmail = Console.ReadLine();
                        Console.WriteLine("phone:");
                        string userPhone = Console.ReadLine();
                        Console.WriteLine("gpa:");
                        double userGpa = double.Parse(Console.ReadLine());
                        Console.WriteLine("status:");
                        string userStatus = Console.ReadLine();
                        Console.WriteLine("major:");
                        string userMajor = Console.ReadLine();
                        obj = new StudentService(userName, userLastName, userEmail, userPhone, userGpa, userStatus, userMajor);
                        obj.AddStudent(obj);
                        break;
                    case "2":
                        Console.WriteLine("Select Id: ");
                        int updateId = int.Parse(Console.ReadLine());
                        obj.UpdateStudent(updateId);
                        break;
                    case "3":
                        Console.WriteLine("Select id:");
                        int deleteId = int.Parse(Console.ReadLine());
                        Console.WriteLine("SoftDelete(true) / Delete(false)");
                        bool deleteStudent = bool.Parse(Console.ReadLine());
                        obj.UpdateStudent(deleteId);
                        break;
                    case "4":
                        Student[] students = obj.GEtAllStudents();
                        foreach (Student student1 in students)
                        {
                            Console.WriteLine($"ID: {student1.Id} \nFirstname: {student1.FirstName} \nLastname: {student1.LastName} \nemail: {student1.Email} \nphone: {student1.PhoneNumber} \ngpa: {student1.GPA} \nstatus: {student1.Status} \nmajor: {student1.Major}");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Select id:");
                        int selectId = int.Parse(Console.ReadLine());
                        Student student2 = obj.GetStudentById(selectId);
                        Console.WriteLine($"ID: {student2.Id} \nFirstname: {student2.FirstName} \nLastname: {student2.LastName} \nemail: {student2.Email} \nphone: {student2.PhoneNumber} \ngpa: {student2.GPA} \nstatus: {student2.Status} \nmajor: {student2.Major}");
                        break;
                    case "6":
                        Console.WriteLine("Select Name:");
                        string selectName = Console.ReadLine();
                        Student[] students3 = obj.GetStudentsByName(selectName);
                        foreach (Student student3 in students3)
                        { 
                        Console.WriteLine($"ID: {student3.Id}  \nFirstname:  {student3.FirstName}  \nLastname:  {student3.LastName}  \nemail:  {student3.Email}  \nphone:  {student3.PhoneNumber}  \ngpa:  {student3.GPA}  \nstatus:  {student3.Status}  \nmajor:  {student3.Major}");
                        }
                        break;
                    case "7":
                        run = false;
                        
                        break;





                }

            }
        }
    }
}
