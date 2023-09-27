using ClassLibrary1;

namespace TestProject2
{
    [TestClass]
    public class CalculTest
    {
        [TestMethod]
        public void Sum_10and20_result30()
        {
            //arrange - 
            int x = 10; int y = 20;
            int result_test = 30;

            //act -
            Calcul calcul = new Calcul();
            int actual = calcul.Sum(x, y);

            //assert -
            Assert.AreEqual(result_test, actual);
        }
    }
}