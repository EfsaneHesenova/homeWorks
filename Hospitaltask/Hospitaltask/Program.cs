using Hospitaltask.Models;
using Hospitaltask.Services.Concretes;

namespace Hospitaltask

{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            string choose;
            string dName;
            string pName;
            int userId;
            DateTime userStart;
            DateTime userEnd;

            AppointmentService service = new AppointmentService();

            while (running)
            {
                Console.WriteLine("""
                    1. Appointment yarat
                    2. Appointment-i bitir
                    3. Bütün appointment-lərə bax
                    4. Bu həftəki appointment-lərə bax
                    5. Bugünki appointment-lərə bax
                    6. Bitməmiş appointmentlərə bax
                    7. Araliqdaki appointmentlere bax
                    8. Menudan çıx
                    """);
                Console.Write("select option: ");
                choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        Console.Write("patient name: ");
                        pName = Console.ReadLine();
                        Console.Write("doctor name: ");
                        dName = Console.ReadLine();
                        Appointment obj = new Appointment(pName, dName);
                        service.AddAppointment(obj);
                        break;
                    case "2":
                        Console.Write("enter id: ");
                        userId = int.Parse(Console.ReadLine());
                        service.EndAppointment(userId);
                        break;
                    case "3":
                        List<Appointment> allAppointments = service.GetAllAppointments();
                        foreach (Appointment item in allAppointments)
                        {
                            Console.WriteLine($"id: {item.Id} \nPatient: {item.PatientName} \nDoctor: {item.DoctorName} \nStart Date: {item.StartDate} \nEnd Date: {item.EndDate} ");
                        }
                        break;
                    case "4":
                        List<Appointment> allWeeklyAppointments = service.GetWeeklyAppointments();
                        foreach (Appointment item in allWeeklyAppointments)
                        {
                            Console.WriteLine($"id: {item.Id} \nPatient: {item.PatientName} \nDoctor: {item.DoctorName} \nStart Date: {item.StartDate} \nEnd Date: {item.EndDate} ");
                        }
                        break;
                    case "5":
                        List<Appointment> todayAppointments = service.GetTodaysAppointments();
                        foreach (Appointment item in todayAppointments)
                        {
                            Console.WriteLine($"id: {item.Id} \nPatient: {item.PatientName} \nDoctor: {item.DoctorName} \nStart Date: {item.StartDate} \nEnd Date: {item.EndDate} ");
                        }
                        break;
                    case "6":
                        List<Appointment> conAppointments = service.GetAllContinuingAppointments();
                        foreach (Appointment item in conAppointments)
                        {
                            Console.WriteLine($"id: {item.Id} \nPatient: {item.PatientName} \nDoctor: {item.DoctorName} \nStart Date: {item.StartDate} \nEnd Date: {item.EndDate} ");
                        }
                        break;
                    case "7":
                        Console.Write("baslangic tarix: ");
                        userStart = DateTime.Parse(Console.ReadLine());
                        Console.Write("son tarix: ");
                        userEnd = DateTime.Parse(Console.ReadLine());
                        List<Appointment> filterAppointments = service.FilterAppointment(userStart, userEnd);
                        foreach (var item in filterAppointments)
                        {
                            Console.WriteLine($"id: {item.Id} \nPatient: {item.PatientName} \nDoctor: {item.DoctorName} \nStart Date: {item.StartDate} \nEnd Date: {item.EndDate} ");
                        }

                        break;
                    case "8":
                        running = false;
                        break;
                }
               

            }


        }
    }
}
