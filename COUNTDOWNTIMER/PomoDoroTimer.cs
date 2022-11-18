
using System;
using System.Collections.Generic;
using System.Timers;

namespace COUNTDOWNTIMER
{
    public class PomoDoroTimer
    {

        private int userWorkHour;
        private int userRestHour;
        private bool ContinueTiming;

        public void Start()
        {
            Console.WriteLine("Enter your Work hour in single digits");
            var userRestHourInInt = Console.ReadLine();
            Console.WriteLine("Enter work Minutes");
            var userWorkHourInInt = Console.ReadLine();
                try
                {
                    userWorkHour = Convert.ToInt32(userWorkHourInInt);
                    userRestHour = Convert.ToInt32(userRestHourInInt);
                    workHour();
                    restHour();
                Console.WriteLine($"Your work ended in {DateTime.Now}");
            }
                catch
                {
                    Console.WriteLine("Number is not valid");
                    Start();
                }
        }


        public void workHour()
        {
            var TimeDuration = new DateTime(2002, 5, 5, 1, userWorkHour, 0, 0);
            DateTime workStartTime = DateTime.Now;
            for (int hr = 0; hr < userWorkHour * 60; hr++)
            {
                Console.Write("Your work finishes in: {0}",TimeDuration.ToString("mm:ss"));
                TimeDuration = TimeDuration.AddSeconds(-1);
                Thread.Sleep(1000);
                Console.Beep();
                Console.Clear();

            }
            Console.WriteLine($"Your work has ended in: {workStartTime} ");

        }

        private void restHour()
        {
            var EndTimeDuration = new DateTime(2002, 5, 5, 1, userRestHour, 0, 0);
            DateTime workStartTime = DateTime.Now;
            for (int hr = 0; hr < userRestHour * 60; hr++)
            {
                Console.Write("Your work Continues in: {0}", EndTimeDuration.ToString("mm:ss"));
                EndTimeDuration = EndTimeDuration.AddSeconds(-1);
                Thread.Sleep(1000);
                Console.Beep();
              Console.Clear();

            }



        }
    }
}




