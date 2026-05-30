using System;
using System.Collections;
using System.Collections.Generic;

namespace TVProgram
{
    public class Program : IEnumerable<Show>
    {
        public DateTime ProgramDate { get; set; }
        public int Count => _shows.Count; 

        private List<Show> _shows = new List<Show>();

        public Program(DateTime date, IEnumerable<Show> allShows)
        {
            ProgramDate = date.Date;

            foreach (var show in allShows)
            {
                if (show.AirTime.Date == ProgramDate)
                {
                    _shows.Add(show);
                }
            }

            _shows.Sort();
        }

        public IEnumerator<Show> GetEnumerator()
        {
            return _shows.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
