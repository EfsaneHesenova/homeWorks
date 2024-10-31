using Hospitaltask.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitaltask.Services.Interfaces
{
    public interface IAppointmentServices
    {
        public void AddAppointment(Appointment appointment);
        public void EndAppointment(int id);
        Appointment GetAppointment(int id);
        List<Appointment> GetAllAppointments();
        List<Appointment> GetWeeklyAppointments();
        List<Appointment> GetTodaysAppointments();
        List<Appointment> GetAllContinuingAppointments();
    }
}
