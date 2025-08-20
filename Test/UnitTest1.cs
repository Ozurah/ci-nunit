using AppToTest;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestAdd_1()
        {
            int result = new App().CalcAdd(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void TestAdd_2()
        {
            int result = new App().CalcAdd(1, 2);
            Assert.That(result, Is.EqualTo(666));
        }
    }
}
