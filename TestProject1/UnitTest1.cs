using StudentServiceLib;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenScore8_TheLetter_A()
        {
            Student s = new Student();
            s.Score = 8;
            char letter = s.getLetterScore();

            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void WhenScore9_TheLetter_A()
        {
            Student s = new Student();
            s.Score = 9;
            char letter = s.getLetterScore();

            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void WhenScore7_TheLetter_B()
        {
            Student s = new Student();
            s.Score = 7;
            char letter = s.getLetterScore();

            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void WhenScore78_TheLetter_B()
        {
            Student s = new Student();
            s.Score = 7.8;
            char letter = s.getLetterScore();

            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void WhenScore6_TheLetter_C()
        {
            Student s = new Student();
            s.Score = 6;
            char letter = s.getLetterScore();

            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void WhenScore5_TheLetter_C()
        {
            Student s = new Student();
            s.Score = 5;
            char letter = s.getLetterScore();

            Assert.AreEqual('C', letter);
        }
    }
}