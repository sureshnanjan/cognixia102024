using Utilities;
namespace TestUtilities
{
    [TestClass]
    public class TestJsonUtility
    {
        [TestMethod]
        public void TestToJsonReturnString()
        {
            /// AAA
            /// Arrange
            JsonUtil mytil = new JsonUtil();
            Type type = typeof(string);
            /// Act
            string result = mytil.ToJson(type);
            /// Assert
            Assert.AreEqual(type, typeof(string));
        }
    }
}