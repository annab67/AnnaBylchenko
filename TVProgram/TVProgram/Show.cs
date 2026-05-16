using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVProgram
{
    public class Show : IComparable<Show>
    {
        public string Title {get; set;}           // Название
        public string Host {get; set;}            // Ведущий
        public string Description {get; set;}     // Описание
        public ShowPeriodicity Periodicity {get; set;} 
        public DateTime AirTime {get; set;}      

        public Show(string title, string host, string description, ShowPeriodicity periodicity, string airTime)
        {
            Title = title;
            Host = host;
            Description = description;
            Periodicity = periodicity;

            if (!DateTime.TryParse(airTime, out DateTime parsedTime))
            {
                throw new ArgumentException("Неверный формат даты и времени. Используйте ДД.ММ.ГГГГ ЧЧ:ММ");
            }
            AirTime = parsedTime;
        }

        public virtual string[] GetInfo()
        {
            var info = new string[2];
            info[0] = $"{Title} (Ведущий: {Host})";
            info[1] = $"Выход: {AirTime:f}. Тип: {Periodicity}.";
            return info;
        }
        public int CompareTo(Show other)
        {
            if (other == null) return 1;
            return AirTime.CompareTo(other.AirTime);
        }
    }
}