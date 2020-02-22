using NUnit.Framework;
using Problems;

namespace Problems.Tests
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
            
            
            string u = Program.Prefix("hello");
            Assert.AreEqual("5,1:hello",u);
            
        }

        [Test]
        public void Test2()
        {
            // Program p = new Program();
            string u = Program.Prefix("");
            Assert.AreEqual("0,0:",u);
        }

        [Test]
        public void Test3()
        {
            // Program p = new Program();
            string u = Program.Prefix("what   ...   did you say?? ");
            Assert.AreEqual("27,5:what   ...   did you say?? ",u);
        }
    }
}