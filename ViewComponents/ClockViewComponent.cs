using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;

namespace ERP.ViewComponents
{
   public class ClockViewComponent : ViewComponent
   {
      public IViewComponentResult Invoke()
      {
         DateTime utcTime = DateTime.UtcNow;
         TimeZoneInfo poznanZone;
         try { poznanZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time"); }
         catch { poznanZone = TimeZoneInfo.FindSystemTimeZoneById("Europe/Warsaw"); }

         DateTime poznanTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, poznanZone);

         var model = new
         {
            HoursMinutes = poznanTime.ToString("HH:mm"),     // Будет "19"
            // Minutes = poznanTime.ToString("mm"),   // Будет "25"
            DayNumber = poznanTime.ToString("dd"),
            MonthName = poznanTime.ToString("MMMM", new CultureInfo("pl-PL")),
            Year = poznanTime.ToString("yyyy")

         };

         return View(model);
      }
   }
}