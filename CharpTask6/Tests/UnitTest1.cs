using static Task_6.Program;
using NUnit.Framework;
using NUnit.Framework.Legacy;


namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestFermatValidCase()
        {
            
            ClassicAssert.IsFalse(CheckFermat(3, 4, 5, 3));
        }

        [Test]
        public void TestFermatInvalidCase()
        {
           
            ClassicAssert.IsFalse(CheckFermat(1, 2, 3, 2));
        }

        [Test]
        public void TestFermatEdgeCase()
        {
            
            ClassicAssert.IsTrue(CheckFermat(1, 2, 3, 1));
        }

        [Test]
        public void TestFermatWithZero()
        {
            
            ClassicAssert.IsFalse(CheckFermat(0, 0, 0, 2));
        }
    }
}