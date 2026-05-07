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
    }
}