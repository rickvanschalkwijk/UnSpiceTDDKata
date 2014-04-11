using System;
using System.Linq;

using NUnit.Framework;

namespace UnspliceTDDKata
{
    [TestFixture]
    public class UnspliceTDDKataTests
    {
        [Test]
        public void RemoveBackSlashes_ShouldRemoveSingleBackSlashesFromString_ReturnStringWithoutBackSlashes()
        {
            // Arrange
            Unsplice unsplice = new Unsplice();

            // Act
            var actual = unsplice.RemoveBackSlashes(@"abc\\\ndef");

            // Assert
            Assert.That(actual, Is.EqualTo("abcdef"));
        }

        [Test]
        public void RemoveBackSlashes_ShouldRemoveDoubleBackSlashesFromString_ReturnStringWithoutBackSlashes()
        {
            // Arrange
            Unsplice unsplice = new Unsplice();

            // Act
            var actual = unsplice.RemoveBackSlashes(@"abc\\\nde\\\nf");

            // Assert
            Assert.That(actual, Is.EqualTo("abcdef"));
        }
    }

    public class Unsplice
    {
        public string RemoveBackSlashes(string s)
        {
            var splittedArray = s.Split(new string[] { "\\\\\\n" }, StringSplitOptions.None);
            return string.Join("",splittedArray);
        }
    }
}