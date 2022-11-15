using StudentServiceLib;
using System.Drawing;

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

        [TestMethod]
        public void WhenScore35_TheLetter_D()
        {
            Student s = new Student();
            s.Score = 3.5;
            char letter = s.getLetterScore();

            Assert.AreEqual('D', letter);
        }

        public void WhenScoreBelow35_TheLetter_E()
        {
            Student s = new Student();
            s.Score = 2;
            char letter = s.getLetterScore();

            Assert.AreEqual('D', letter);
        }

        [TestMethod]
        public void scoreTest()
        {
            Student s = new Student();
            bool isCatch = false;
            try
            {
                s.Score = 19;
            }
            catch (Exception e)
            {
                isCatch = true;
            }

            Assert.IsTrue(isCatch);
        }

        [TestMethod]
        public void WhenAddTheSameId()
        {
            StudentService s = new StudentService();
            AddStudent(s);
            Assert.AreEqual(1,s.size());
        }

        public void AddStudent(StudentService s)
        {
            Student s1 = new Student();
            s1.Id = 1;
            s1.Name= "Phanh";
            s1.Age = 21;
            s1.Score = 7;
            Student s2 = new Student();
            s1.Id = 1;
            s2.Name = "Tan";
            s2.Age = 21;
            s2.Score = 6;
            s.addStudent(s1);
            s.addStudent(s2);
        }
    }
}