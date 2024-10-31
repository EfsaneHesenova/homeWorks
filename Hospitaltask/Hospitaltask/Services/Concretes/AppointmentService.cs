using Hospitaltask.Models;
using Hospitaltask.Services.Interfaces;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitaltask.Services.Concretes
{
    internal class AppointmentService : IAppointmentServices
    {
        public static List<Appointment> appointments;

        public AppointmentService()
        {
            appointments = new List<Appointment>();
        }
        public void AddAppointment(Appointment appointment)
        {
            appointments.Add(appointment);
        }


        public void EndAppointment(int id)
        {
            foreach (Appointment item in appointments)
            {
                if (item.Id == id)
                {
                    item.EndDate = DateTime.Now;                            
                }

            }
            
        }

        public List<Appointment> GetAllAppointments()
        {
            if (appointments != null)
            {
                return appointments;
            }
            throw new Exception("Appointments are Zero");
        }

        public List<Appointment> GetAllContinuingAppointments()
        {
            List<Appointment> continueAppointments = new List<Appointment>();
            foreach (Appointment item in appointments)
            {
                if (item.EndDate == null)
                {
                    continueAppointments.Add(item);
                    

                }
            }
            return continueAppointments;
        }

        public Appointment GetAppointment(int id)
        {
            foreach (Appointment item in appointments)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            throw new Exception("Appointment can't find");
        }

        public List<Appointment> GetTodaysAppointments()
        {
            DateTime Today = DateTime.Today;
            List<Appointment> todayeAppointments = new List<Appointment>();
            foreach (Appointment item in appointments)
            {
                if (item.StartDate == Today)
                {
                    todayeAppointments.Add(item);
                }
            }
            return todayeAppointments;
        }

        public List<Appointment> GetWeeklyAppointments()
        {
            List<Appointment> weeklyAppointments = new List<Appointment>();
            DateTime Today = DateTime.Today;
            DateTime Old = DateTime.Today.AddDays(-7);
            foreach (Appointment item in appointments)
            {
                if (item.StartDate >= Old && item.StartDate <= Today)
                {
                    weeklyAppointments.Add(item);
                }
            }
            return weeklyAppointments;


        }
    }
}
