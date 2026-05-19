using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLibrary
{
    public struct Time
    {
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }

        public int TotalSeconds => Hours * 3600 + Minutes * 60 + Seconds;

        public Time(int hours, int minutes, int seconds)
        {
            if (hours < 0 || hours > 23)
                throw new ArgumentException("Часы должны быть от 0 до 23.");
            if (minutes < 0 || minutes > 59)
                throw new ArgumentException("Минуты должны быть от 0 до 59.");
            if (seconds < 0 || seconds > 59)
                throw new ArgumentException("Секунды должны быть от 0 до 59.");

            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Time)) return false;
            Time other = (Time)obj;
            return this.TotalSeconds == other.TotalSeconds;
        }

        public override int GetHashCode()
        {
            return TotalSeconds.GetHashCode();
        }

        public static Time operator +(Time t1, Time t2)
        {
            int total = t1.TotalSeconds + t2.TotalSeconds;
            total %= 86400;

            int h = total / 3600;
            int m = (total % 3600) / 60;
            int s = total % 60;

            return new Time(h, m, s);
        }

        public static Time operator -(Time t1, Time t2)
        {
            int total = t1.TotalSeconds - t2.TotalSeconds;
            if (total < 0) total += 86400;

            int h = total / 3600;
            int m = (total % 3600) / 60;
            int s = total % 60;

            return new Time(h, m, s);
        }

        public static bool operator ==(Time t1, Time t2) => t1.Equals(t2);
        public static bool operator !=(Time t1, Time t2) => !t1.Equals(t2);
        public static bool operator <(Time t1, Time t2) => t1.TotalSeconds < t2.TotalSeconds;
        public static bool operator >(Time t1, Time t2) => t1.TotalSeconds > t2.TotalSeconds;
        public static bool operator <=(Time t1, Time t2) => t1.TotalSeconds <= t2.TotalSeconds;
        public static bool operator >=(Time t1, Time t2) => t1.TotalSeconds >= t2.TotalSeconds;
    }
}