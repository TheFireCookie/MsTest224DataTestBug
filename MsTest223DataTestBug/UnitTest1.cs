using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace MsTest223DataTestBug
{
  public class MyStringContainer
  {
    public string MyString { get; set; }
  }

  [TestClass]
  public class UnitTest1
  {
    public static IEnumerable<MyStringContainer[]> GetStrings
    {
      get
      {
        return new List<MyStringContainer>
        {
          new() { MyString = "super string "}
        }.Select(t => new[] { t });
      }
    }

    [DataTestMethod]
    [DynamicData(nameof(GetStrings))]
    public void TestMethod1(MyStringContainer myStringContainer)
    {
    }
  }
}
