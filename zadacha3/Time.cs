using System;
using System.Collections.Generic;
using System.Text;

namespace zadacha3
{
    internal class Time
    {
        private int hour;
        private int minute;
        private int second;


        public Time()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }
        public Time(int hour, int minute, int second)
        {
            if (hour < 0 || minute < 0 || second < 0)
            {
                throw new ArgumentException(
                    "Часът, минутата и секундата не могат да бъдат отрицателни!"
                );
            }

            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public void DisplayTime()
        {
            Console.WriteLine(
                $"{hour:D2}:{minute:D2}:{second:D2}"
            );
        }
    }
}
