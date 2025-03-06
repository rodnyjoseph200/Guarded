using Guarded.Guards;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Guarded.UnitTests.GuardAgainstNulls;

[TestClass]
public class GuardAgainstNulls_With2Parameters_Tests
{
    [TestMethod]
    [DataRow(null, "", "arg1", "arg2")]
    [DataRow("", null, "arg2", "arg1")]
    [DataRow(null, null, "arg1, arg2", "")]
    public void AgainstNulls_With2Parameters_AllPossibleNullablePaths(object? arg1, object? arg2, string contains, string notContains)
    {
        var containsList = contains.Split([", "], StringSplitOptions.RemoveEmptyEntries);
        var notContainsList = notContains.Split([", "], StringSplitOptions.RemoveEmptyEntries);

        void act() => Guard.AgainstNulls(arg1, arg2, throws: true);
        GuardAgainstNullsConstants.TestWithPossibleException(act, containsList, notContainsList);

        var result = Guard.AgainstNulls(arg1, arg2, throws: false);
        GuardAgainstNullsConstants.TestWithPossibleErrorMessage(result, containsList, notContainsList);
    }
}