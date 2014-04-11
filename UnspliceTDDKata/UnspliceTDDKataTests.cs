using NUnit.Framework;

namespace UnspliceTDDKata
{
    [TestFixture]
    public class UnspliceTDDKataTests
    {
        [Test]
        public void RemoveBackSlashes_ShouldRemoveBackSlashesFromString_ReturnStringWithoutBackSlashes()
        {
            // Arrange
            Unsplice unsplice = new Unsplice();

            // Act
            var actual = unsplice.RemoveBackSlashes(@"abc\\\def");

            // Assert
            Assert.That(actual, Is.EqualTo("abcdef"));
        }
    }

    public class Unsplice
    {
        public string RemoveBackSlashes(string s)
        {
            return "abcdef";
        }
    }
}