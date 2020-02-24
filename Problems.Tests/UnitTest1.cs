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

        [TestCase("hello","5,1:hello")]
        [TestCase("","0,0:")]
        [TestCase("what    ...  did you say?? ","27,5:what    ...  did you say?? ")]
        [TestCase("this is nice","12,3:this is nice")]
        [TestCase("     a       rose   65i","23,3:     a       rose   65i")]
        [TestCase("gfwudurj  yfiojrfhy u i dgdyb ","30,5:gfwudurj  yfiojrfhy u i dgdyb ")]
        public void Check_Prefix(string input, string result)
        {
            // Program p = new Program();
            string u = Program.Prefix(input);
            Assert.AreEqual(u, result);
        }
    }
}