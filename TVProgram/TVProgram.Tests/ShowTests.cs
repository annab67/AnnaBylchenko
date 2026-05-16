using NUnit.Framework;
using TVProgram;

namespace TVProgram.Tests
{
    [TestFixture]
    public class ShowTests
    {
        [Test]
        public void ConstructorTest()
        {
            var testShow = new Show("Поле Чудес", "Якубович", "Капитал-шоу", ShowPeriodicity.Weekly, "25.10.2023 18:30");

            Assert.That(testShow.Title, Is.EqualTo("Поле Чудес"));
            Assert.That(testShow.Host, Is.EqualTo("Якубович"));
            Assert.That(testShow.Periodicity, Is.EqualTo(ShowPeriodicity.Weekly));
        }

        [Test]
        public void GetInfoTest()
        {
            var testShow = new Show("Новости", "Диктор", "Инфо", ShowPeriodicity.Daily, "25.10.2023 21:00");
            var info = testShow.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Does.Contain("Новости"));
        }

        [Test]
        public void TVSeries_GetInfo_ReturnsThreeLines()
        {
            var series = new TVSeries("Офис", "Стив Карелл", "Комедия", ShowPeriodicity.Weekly, "10.05.2026 20:00", 1, 5);

            var info = series.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[2], Does.Contain("Сезон: 1"));
        }

        [Test]
        public void EducationalShow_GetInfo_ReturnsThreeLines()
        {
            var eduShow = new EducationalShow("Наука 2.0", "Антон Войцеховский", "Про технологии", ShowPeriodicity.Monthly, "12.05.2026 15:00", "Физика");
            var info = eduShow.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[2], Does.Contain("Физика"));
        }

        [Test]
        public void Movie_GetInfo_ReturnsFourLines()
        {
            var movie = new Movie("Интерстеллар", "К. Нолан", "Научная фантастика", ShowPeriodicity.OneTime, "15.05.2026 21:00", "Драма", "Кристофер Нолан", "США", 2014);
            var info = movie.GetInfo();

            Assert.That(info.Length, Is.EqualTo(4));
            Assert.That(info[3], Does.Contain("2014г."));
        }
        [Test]
        public void Show_CompareTo_SortsByAirTime()
        {
            var morningShow = new Show("Утренние новости", "Ведущий 1", "Инфо", ShowPeriodicity.Daily, "20.05.2026 08:00");
            var eveningShow = new Show("Вечернее шоу", "Ведущий 2", "Развлечения", ShowPeriodicity.Daily, "20.05.2026 21:00");

            Assert.That(morningShow.CompareTo(eveningShow), Is.LessThan(0));
            Assert.That(eveningShow.CompareTo(morningShow), Is.GreaterThan(0));
        }

        [Test]
        public void Program_Constructor_FiltersAndSortsCorrectly()
        {
            var showToday1 = new Show("Вечернее шоу", "Диктор", "Инфо", ShowPeriodicity.Daily, "25.05.2026 20:00");
            var showToday2 = new Show("Утренний эфир", "Диктор", "Инфо", ShowPeriodicity.Daily, "25.05.2026 09:00");
            var showTomorrow = new Show("Завтрашний фильм", "Диктор", "Кино", ShowPeriodicity.OneTime, "26.05.2026 18:00");

            var allShows = new List<Show> { showToday1, showToday2, showTomorrow };

            var targetDate = new DateTime(2026, 5, 25);
            var program = new Program(targetDate, allShows);

            Assert.That(program.Count, Is.EqualTo(2));

            var sortedList = new List<Show>();
            foreach (var show in program)
            {
                sortedList.Add(show);
            }

            Assert.That(sortedList[0].Title, Is.EqualTo("Утренний эфир"));
            Assert.That(sortedList[1].Title, Is.EqualTo("Вечернее шоу"));
        }
    }
}