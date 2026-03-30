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
    }
}