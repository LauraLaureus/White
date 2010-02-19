using NUnit.Framework;
using White.Core.CustomCommands;
using White.CustomControls.Automation;

namespace White.NonCoreTests.CustomCommands
{
    [TestFixture]
    public class CustomCommandDeserializerTest
    {
        [Test]
        public void Deserialize()
        {
            var s = CustomCommandSerializer.ToString("White.NonCoreTests.CustomCommands.dll", "IBazCommand", "Foo", new object[] { "bar", 1 });
            ICustomCommand customCommand = new CustomCommandDeserializer().GetCommand(s);
            Assert.AreEqual("White.NonCoreTests.CustomCommands.dll", customCommand.AssemblyFile);
            Assert.AreEqual("IBazCommand", customCommand.TypeName);
            Assert.AreEqual("Foo", customCommand.MethodName);
        }
    }
}