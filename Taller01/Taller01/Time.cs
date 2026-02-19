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
        public Time(int hour)
        {
            this.hour = hour;
            this.minute = 0;
            this.second = 0;
            this.millisecond = 0;
        }
        public Time(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = 0;
            this.millisecond = 0;
        }
        public Time(int hour, int minute, int second, int millisecond)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            this.millisecond = millisecond;
        }



    }
}

