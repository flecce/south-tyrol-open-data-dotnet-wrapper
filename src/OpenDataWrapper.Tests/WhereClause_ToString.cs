using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OpenDataWrapper.Tests
{
    [TestClass]
    public class WhereClause_ToString
    {
        [TestMethod]
        public void Simple_Logical_And_Expression()
        {
            var where = new WhereClause(
                new AndElse(
                    new FilterTriple("scode", "eq", "BZ5"), 
                    new FilterTriple("scode", "eq", "BZ6")
                )
            );

            var expected = "and(scode.eq.BZ5,scode.eq.BZ6)";
            var result = where.ToString();

            Assert.IsTrue(!string.IsNullOrEmpty(result));
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Nested_Logical_Expression()
        {
            var where = new WhereClause(
                new AndElse(
                    new FilterTriple("scode", "eq", "BZ5"),
                    new OrElse(new FilterTriple("tname", "eq", "name1"), new FilterTriple("tname", "eq", "name2")))
                );

            var expected = "and(scode.eq.BZ5,or(tname.eq.name1,tname.eq.name2))";
            var result = where.ToString();

            Assert.IsTrue(!string.IsNullOrEmpty(result));
            Assert.AreEqual(expected, result);
        }
    }
}
