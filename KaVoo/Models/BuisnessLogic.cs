﻿
using Itenso.TimePeriod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using KaVoo.Entity;

namespace KaVoo.Models
{
    public class BuisnessLogic
    {
        //Appointment Creation Helper Methods
        //Checking if InsideWorkingHours + Not Weekend
        public static bool IsInWorkingHours(DateTime start, DateTime end)
        {
            DataContext dbApp = new DataContext();
            // check Not Saturday or Sunday
            if (start.DayOfWeek == DayOfWeek.Saturday || start.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }

            TimeRange workingHours = new TimeRange(TimeTrim.Hour(start, int.Parse(dbApp.Administrations.Find(2).Value)), TimeTrim.Hour(start, int.Parse(dbApp.Administrations.Find(3).Value)));
            return workingHours.HasInside(new TimeRange(start, end));
        }

        public static bool IsInWorkingHours(TimeBlock block)
        {
            DataContext dbApp = new DataContext();
            // check Not Saturday or Sunday
            if (block.Start.DayOfWeek == DayOfWeek.Saturday || block.Start.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }
            TimeRange workingHours = new TimeRange(TimeTrim.Hour(block.Start.Date, int.Parse(dbApp.Administrations.Find(2).Value)), TimeTrim.Hour(block.Start.Date, int.Parse(dbApp.Administrations.Find(3).Value)));
            return workingHours.HasInside(block);
        }

        public static string ValidateNoAppoinmentClash(AppointmentModel appointment)
        {
            DataContext dbApp = new DataContext();
            var appointments = from a in dbApp.Appointments.Where(x => x.PsikologID == appointment.PsikologID)
                               select a;
            foreach (var item in appointments)
            {
                if (item.Time.ToShortTimeString() == appointment.Time.ToShortTimeString() && item.Date.ToShortDateString() == appointment.Date.ToShortDateString())
                {
                    string errorMessage = String.Format(
                        "{0} already has an appointment on {1} on {2}.",
                        item.Psikolog.Name,
                        item.Date.ToShortDateString(),
                        item.Time.ToShortTimeString());
                    return errorMessage;
                }
            }
            return String.Empty;

        }

        public static List<SelectListItem> AvailableAppointments(int docID, DateTime date)
        {
            DataContext dbApp = new DataContext();
            int A, S, E;
            A = int.Parse(dbApp.Administrations.Find(1).Value);
            S = int.Parse(dbApp.Administrations.Find(2).Value);
            E = int.Parse(dbApp.Administrations.Find(3).Value);
            TimeBlock timeBlock = new MyTimeBlockExtention
                (
                new DateTime(date.Year, date.Month, date.Day, S, 0, 0),
                new TimeSpan(0, A, 0)
                );
            List<SelectListItem> ItemsList = new List<SelectListItem>();
            while (timeBlock.Start.CompareTo(DateTime.Now) <= 0) // No Appointments for past!!
            {
                timeBlock.Move(new TimeSpan(0, A, 0));
                if (!IsInWorkingHours(timeBlock))
                    break;
            }
            var appointments = from a in dbApp.Appointments.Where(x => x.PsikologID == docID)
                               select a;
            bool overlaps = false;
            while (IsInWorkingHours(timeBlock))
            {
                foreach (var appointment in appointments)
                {
                    TimeBlock BookedTimeBlock = new MyTimeBlockExtention
                (
                (appointment.Date.Date.Add(appointment.Time.TimeOfDay)),
                new TimeSpan(0, A, 0)
                );
                    if (BookedTimeBlock.OverlapsWith(timeBlock))
                    {
                        overlaps = true;
                    }
                }
                if (!overlaps)
                {
                    ItemsList.Add(new SelectListItem() { Text = timeBlock.ToString(), Value = timeBlock.Start.ToString("HH:mm") });

                }
                overlaps = false;
                timeBlock.Move(new TimeSpan(0, A, 0));
            }
            if (ItemsList.Count != 0)
            {
                return ItemsList;
            }
            ItemsList.Add(new SelectListItem() { Text = "No Appointments Available", Value = "DONT" });
            return ItemsList;
        }
    }
}