namespace Unit_Test;
public class Tests
    {
        private BasicProgramForPractise basic;
        [SetUp]
        public void Setup()
        {
            basic = new BasicProgramForPractise();
        }

        [Test]
        public void SumOfNum()
        {

            //AAA
            //arrange
            int a = 10;
            int b = 20;
            int sum = 30;

            //act
            var result = basic.Add(a, b);
            //assert

           Assert.AreEqual(sum, result);
        }
    [Test]
    public void CheckOdd()
    {
        //AAA
        //arrange
        int a = 5;
        bool expected = false;

        //act
        bool actual = basic.OddEven(a);

        //assert

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CheckEven()
    {
        int a = 10;
        bool expected = true;

        bool actual = basic.OddEven(a);

        Assert.AreEqual(expected, actual);
    }
    }