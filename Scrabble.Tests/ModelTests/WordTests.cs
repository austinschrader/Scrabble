using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      
      Word newWord = new Word("axel");
      Assert.AreEqual(typeof(Word), newWord.GetType());

    }
  }
}






















