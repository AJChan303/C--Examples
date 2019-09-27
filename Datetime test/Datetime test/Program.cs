using System;

namespace Datetime_test {
    class Program {
        static void Main(string[] args) {
            //DateTime dt = DateTime.Today;
            DateTime dt = new DateTime(2019, 12, 1);
            Console.WriteLine(dt.Day);
            //GetFirstDay(dt);
            DateTime d = new DateTime(dt.Year, dt.Month, DateTime.DaysInMonth(dt.Year, dt.Month));
            Console.WriteLine(d
                );
        }
        
        private static DateTime GetFirstDay(DateTime dt) {
          return dt.AddDays(-dt.Day + 1);
        }
    }
}
