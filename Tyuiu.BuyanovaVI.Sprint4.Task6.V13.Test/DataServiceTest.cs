using Tyuiu.BuyanovaVI.Sprint4.Task6.V13.Lib;

namespace Tyuiu.BuyanovaVI.Sprint4.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] carmark = { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };
            Assert.AreEqual(4, ds.Calculate(carmark));
        }
    }   
}