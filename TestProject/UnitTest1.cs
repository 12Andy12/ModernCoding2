using ClassLibrary;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFun1()
        {
            Assert.AreEqual(Class1.fun1(2, 1), 2);

            Assert.AreEqual(Class1.fun1(1, 2), 2);

            Assert.AreEqual(Class1.fun1(2, 2), 2);
        }

        [TestMethod]
        public void TestFun2()
        {
            int[][] mas = {
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3 }
            };

            Assert.AreEqual(Class1.fun2(mas), 6);
        }

        [TestMethod]
        public void TestFun3()
        {
            int[][] mas = {
                new int[] { 0, 2, 3 },
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3 }
            };

            Assert.AreEqual(Class1.fun3(mas), 0);
        }

    }
}