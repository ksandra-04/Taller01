using System;
using System.Collections.Generic;
using System.Text;

namespace Taller01
{
    public class Time
    {
        private int hour;
        private int minute;
        private int second;
        private int millisecond;
       
        public Time() //sin parametros
        {
            hour = 0;
            minute = 0;
            second = 0;
            millisecond = 0;
        }
        // Solo hora
        public Time(int hour)
            : this(hour, 0, 0, 0) { }

        // Hora y minuto
        public Time(int hour, int minute)
            : this(hour, minute, 0, 0) { }

        // Hora, minuto y segundo
        public Time(int hour, int minute, int second)
            : this(hour, minute, second, 0) { }

        // Constructor completo
        public Time(int hour, int minute, int second, int millisecond)
        {
            if (hour < 0 || hour > 23)
                throw new Exception($"The hour: {hour}, is not valid.");

            if (minute < 0 || minute > 59)
                throw new Exception($"The minute: {minute}, is not valid.");

            if (second < 0 || second > 59)
                throw new Exception($"The second: {second}, is not valid.");

            if (millisecond < 0 || millisecond > 999)
                throw new Exception($"The millisecond: {millisecond}, is not valid.");

            this.hour = hour;
            this.minute = minute;
            this.second = second;
            this.millisecond = millisecond;
        }

        public long ToMilliseconds()
        {
            return (hour * 3600000L) +
                   (minute * 60000L) +
                   (second * 1000L) +
                   millisecond;
        }

        public long ToSeconds()
        {
            return ToMilliseconds() / 1000;
        }

        public long ToMinutes()
        {
            return ToSeconds() / 60;
        }

        public bool IsOtherDay(Time other)
        {
            int h = this.hour + other.hour;
            int m = this.minute + other.minute;
            int s = this.second + other.second;
            int ms = this.millisecond + other.millisecond;

            if (ms > 999)
            {
                s += ms / 1000;
                ms %= 1000;
            }

            if (s > 59)
            {
                m += s / 60;
                s %= 60;
            }

            if (m > 59)
            {
                h += m / 60;
                m %= 60;
            }

            if (h >= 24)
                return true;

            return false;
        }
        public Time Add(Time other)
        {
            int h = this.hour + other.hour;
            int m = this.minute + other.minute;
            int s = this.second + other.second;
            int ms = this.millisecond + other.millisecond;

            if (ms > 999)
            {
                s += ms / 1000;
                ms %= 1000;
            }

            if (s > 59)
            {
                m += s / 60;
                s %= 60;
            }

            if (m > 59)
            {
                h += m / 60;
                m %= 60;
            }

            if (h > 23)
            {
                h %= 24;
            }

            return new Time(h, m, s, ms);
        }
        public override string ToString()
        {
            int displayHour = hour % 12;
            if (displayHour == 0)
                displayHour = 12;

            string tt = hour < 12 ? "AM" : "PM";

            return $"{displayHour:00}:{minute:00}:{second:00}.{millisecond:000} {tt}";
        }



    }
}

