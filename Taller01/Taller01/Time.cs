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





    }
}

