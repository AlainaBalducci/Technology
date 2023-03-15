using Technology;
namespace TechnologyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void TestDropPhone()
        {
            SmartPhone myPhone = new SmartPhone(64, 8, "Android");
            myPhone.DropPhone();
            Assert.IsFalse(myPhone.HasCamera);
        }

        [TestMethod]
        public void StuffingCheetosInLaptop() 
        {
            Laptop myLaptop = new Laptop(4, 64, 18, "Windows");
            myLaptop.stuffCheetos(2);
            Assert.AreEqual(2, myLaptop.NumOfUsb, .001);
        }
    }
}