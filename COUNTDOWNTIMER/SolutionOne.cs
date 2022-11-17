
using System;
using System.Collections.Generic;
using System.Timers;

namespace COUNTDOWNTIMER
{
    public class SolutionOne
    {

        public int userWorkHour;
        public int userRestHour;

        public void Start()
        {
            Console.WriteLine("Enter your Work hour in single digits");
            var userRestHourInInt = Console.ReadLine();
            Console.WriteLine("Enter work Minutes");
            var userWorkHourInInt = Console.ReadLine();
            try
            {
                userWorkHour = Convert.ToInt32(userRestHourInInt);
                userRestHour = Convert.ToInt32(userRestHourInInt);
                workHour();
            }
            catch
            {
                Console.WriteLine("Number is not valid");
                Start();
            }
        }


        private void workHour()
        {
            var TimeDuration = new DateTime(2002, 20, 5, 1, userWorkHour, 5, 0);
            DateTime workStartTime = DateTime.Now;
            for (int hr = 0; hr < userRestHour * 60; hr++)
            {
                Console.Write($"Your work finishes in {TimeDuration.ToString("mm:ss")}");
                TimeDuration = TimeDuration.AddSeconds(-1);
            }
            Console.WriteLine($"Your work hour will expire in {TimeDuration}");
            Console.WriteLine($"{4}");

        }

        private void restHour()
        {
            Console.WriteLine($"Your work hour will resume in");

        }
    }
}




