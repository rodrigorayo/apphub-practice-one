using System;

namespace AppHub.Application.Providers
{
    public class DateProvider
    {
        // Método para obtener la fecha y hora en formato UTC (universal).
        public DateTime GetCurrentDateUtc()
        {
            return DateTime.UtcNow;
        }

        // Método para obtener la fecha y hora en formato local.
        public DateTime GetCurrentDateLocal()
        {
            return DateTime.Now;
        }
    }
}
