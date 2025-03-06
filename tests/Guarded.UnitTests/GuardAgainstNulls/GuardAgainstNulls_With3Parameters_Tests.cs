using Guarded.Guards;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Guarded.UnitTests.GuardAgainstNulls;

[TestClass]
public class GuardAgainstNulls_With3Parameters_Tests
{
    [TestMethod]
    [DataRow("value1", "value2", "value3", "", "arg1, arg2, arg3")]
    [DataRow(null, "value2", "value3", "arg1", "arg2, arg3")]
    [DataRow("value1", null, "value3", "arg2", "arg1, arg3")]
    [DataRow("value1", "value2", null, "arg3", "arg1, arg2")]
    [DataRow(null, null, "value3", "arg1, arg2", "arg3")]
    [DataRow(null, "value2", null, "arg1, arg3", "arg2")]
    [DataRow("value1", null, null, "arg2, arg3", "arg1")]
    [DataRow(null, null, null, "arg1, arg2, arg3", "")]
    public void AgainstNulls_With3Parameters_AllPossibleNullablePaths(object? arg1, object? arg2, object? arg3, string contains, string notContains)
    {
        var containsList = contains.Split([", "], StringSplitOptions.RemoveEmptyEntries);
        var notContainsList = notContains.Split([", "], StringSplitOptions.RemoveEmptyEntries);

        void act() => Guard.AgainstNulls(arg1, arg2, arg3, throws: true);
        GuardAgainstNullsConstants.TestWithPossibleException(act, containsList, notContainsList);

        var result = Guard.AgainstNulls(arg1, arg2, arg3, throws: false);
        GuardAgainstNullsConstants.TestWithPossibleErrorMessage(result, containsList, notContainsList);
    }
}