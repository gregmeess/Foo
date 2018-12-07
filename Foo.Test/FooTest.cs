using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Foo.Test
{
    [TestClass]
    public class FooTest
    {
        [TestMethod]
        public void Foo_ReturnTrue()
        {
            bool result = Lib.Foo.returnTrue();
            Assert.IsTrue(result);
        }
    }
}
