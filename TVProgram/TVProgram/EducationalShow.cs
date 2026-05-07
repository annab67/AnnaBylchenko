namespace TVProgram
{
    public class EducationalShow : Show
    {
        public string ScienceArea {get; set;}

        public EducationalShow(string title, string host, string description, ShowPeriodicity periodicity, string airTime, string scienceArea)
            : base(title, host, description, periodicity, airTime)
        {
            ScienceArea = scienceArea;
        }

        public override string[] GetInfo()
        {
            var baseInfo = base.GetInfo();

            var fullInfo = new string[3];
            fullInfo[0] = baseInfo[0];
            fullInfo[1] = baseInfo[1];
            fullInfo[2] = $"Область науки: {ScienceArea}";

            return fullInfo;
        }
    }
}