namespace TVProgram
{
    public class TVSeries : Show
    {
        public int SeasonNumber {get; set;}
        public int EpisodeNumber {get; set;}

        public TVSeries(string title, string host, string description, ShowPeriodicity periodicity,
                        string airTime, int seasonNumber, int episodeNumber)
            : base(title, host, description, periodicity, airTime)
        {
            SeasonNumber = seasonNumber;
            EpisodeNumber = episodeNumber;
        }

        public override string[] GetInfo()
        {
            var baseInfo = base.GetInfo();
            var fullInfo = new string[3];

            fullInfo[0] = baseInfo[0]; 
            fullInfo[1] = baseInfo[1];
            fullInfo[2] = $"Сезон: {SeasonNumber}, Серия: {EpisodeNumber}";

            return fullInfo;
        }
    }
}