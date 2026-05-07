namespace TVProgram
{
    public class Movie : Show
    {
        public string Genre {get; set;}
        public string Director {get; set;}
        public string Country {get; set;}
        public int Year {get; set;}

        public Movie(string title, string host, string description, ShowPeriodicity periodicity,
                     string airTime, string genre, string director, string country, int year)
            : base(title, host, description, periodicity, airTime)
        {
            Genre = genre;
            Director = director;
            Country = country;
            Year = year;
        }

        public override string[] GetInfo()
        {
            var baseInfo = base.GetInfo();
            var fullInfo = new string[4];

            fullInfo[0] = baseInfo[0];
            fullInfo[1] = baseInfo[1];
            fullInfo[2] = $"Фильм: {Genre}, Режиссер: {Director}";
            fullInfo[3] = $"Производство: {Country}, {Year}г.";

            return fullInfo;
        }
    }
}