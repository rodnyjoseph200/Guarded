using Guarded.Guards;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Guarded.UnitTests.GuardAgainstNulls;

[TestClass]
public class GuardAgainstNulls_With6Parameters_Tests
{
    [TestMethod]

    // All inputs provided (0 missing)
    [DataRow("value1", "value2", "value3", "value4", "value5", "value6", "", "arg1, arg2, arg3, arg4, arg5, arg6")]

    // Exactly one input missing (6 cases)
    [DataRow(null, "value2", "value3", "value4", "value5", "value6", "arg1", "arg2, arg3, arg4, arg5, arg6")]
    [DataRow("value1", null, "value3", "value4", "value5", "value6", "arg2", "arg1, arg3, arg4, arg5, arg6")]
    [DataRow("value1", "value2", null, "value4", "value5", "value6", "arg3", "arg1, arg2, arg4, arg5, arg6")]
    [DataRow("value1", "value2", "value3", null, "value5", "value6", "arg4", "arg1, arg2, arg3, arg5, arg6")]
    [DataRow("value1", "value2", "value3", "value4", null, "value6", "arg5", "arg1, arg2, arg3, arg4, arg6")]
    [DataRow("value1", "value2", "value3", "value4", "value5", null, "arg6", "arg1, arg2, arg3, arg4, arg5")]

    // Exactly two inputs missing (15 cases)
    [DataRow(null, null, "value3", "value4", "value5", "value6", "arg1, arg2", "arg3, arg4, arg5, arg6")]
    [DataRow(null, "value2", null, "value4", "value5", "value6", "arg1, arg3", "arg2, arg4, arg5, arg6")]
    [DataRow(null, "value2", "value3", null, "value5", "value6", "arg1, arg4", "arg2, arg3, arg5, arg6")]
    [DataRow(null, "value2", "value3", "value4", null, "value6", "arg1, arg5", "arg2, arg3, arg4, arg6")]
    [DataRow(null, "value2", "value3", "value4", "value5", null, "arg1, arg6", "arg2, arg3, arg4, arg5")]
    [DataRow("value1", null, null, "value4", "value5", "value6", "arg2, arg3", "arg1, arg4, arg5, arg6")]
    [DataRow("value1", null, "value3", null, "value5", "value6", "arg2, arg4", "arg1, arg3, arg5, arg6")]
    [DataRow("value1", null, "value3", "value4", null, "value6", "arg2, arg5", "arg1, arg3, arg4, arg6")]
    [DataRow("value1", null, "value3", "value4", "value5", null, "arg2, arg6", "arg1, arg3, arg4, arg5")]
    [DataRow("value1", "value2", null, null, "value5", "value6", "arg3, arg4", "arg1, arg2, arg5, arg6")]
    [DataRow("value1", "value2", null, "value4", null, "value6", "arg3, arg5", "arg1, arg2, arg4, arg6")]
    [DataRow("value1", "value2", null, "value4", "value5", null, "arg3, arg6", "arg1, arg2, arg4, arg5")]
    [DataRow("value1", "value2", "value3", null, null, "value6", "arg4, arg5", "arg1, arg2, arg3, arg6")]
    [DataRow("value1", "value2", "value3", null, "value5", null, "arg4, arg6", "arg1, arg2, arg3, arg5")]
    [DataRow("value1", "value2", "value3", "value4", null, null, "arg5, arg6", "arg1, arg2, arg3, arg4")]

    // Exactly three inputs missing (20 cases)
    [DataRow(null, null, null, "value4", "value5", "value6", "arg1, arg2, arg3", "arg4, arg5, arg6")]
    [DataRow(null, null, "value3", null, "value5", "value6", "arg1, arg2, arg4", "arg3, arg5, arg6")]
    [DataRow(null, null, "value3", "value4", null, "value6", "arg1, arg2, arg5", "arg3, arg4, arg6")]
    [DataRow(null, null, "value3", "value4", "value5", null, "arg1, arg2, arg6", "arg3, arg4, arg5")]
    [DataRow(null, "value2", null, null, "value5", "value6", "arg1, arg3, arg4", "arg2, arg5, arg6")]
    [DataRow(null, "value2", null, "value4", null, "value6", "arg1, arg3, arg5", "arg2, arg4, arg6")]
    [DataRow(null, "value2", null, "value4", "value5", null, "arg1, arg3, arg6", "arg2, arg4, arg5")]
    [DataRow(null, "value2", "value3", null, null, "value6", "arg1, arg4, arg5", "arg2, arg3, arg6")]
    [DataRow(null, "value2", "value3", null, "value5", null, "arg1, arg4, arg6", "arg2, arg3, arg5")]
    [DataRow(null, "value2", "value3", "value4", null, null, "arg1, arg5, arg6", "arg2, arg3, arg4")]
    [DataRow("value1", null, null, null, "value5", "value6", "arg2, arg3, arg4", "arg1, arg5, arg6")]
    [DataRow("value1", null, null, "value4", null, "value6", "arg2, arg3, arg5", "arg1, arg4, arg6")]
    [DataRow("value1", null, null, "value4", "value5", null, "arg2, arg3, arg6", "arg1, arg4, arg5")]
    [DataRow("value1", null, "value3", null, null, "value6", "arg2, arg4, arg5", "arg1, arg3, arg6")]
    [DataRow("value1", null, "value3", null, "value5", null, "arg2, arg4, arg6", "arg1, arg3, arg5")]
    [DataRow("value1", null, "value3", "value4", null, null, "arg2, arg5, arg6", "arg1, arg3, arg4")]
    [DataRow("value1", "value2", null, null, null, "value6", "arg3, arg4, arg5", "arg1, arg2, arg6")]
    [DataRow("value1", "value2", null, null, "value5", null, "arg3, arg4, arg6", "arg1, arg2, arg5")]
    [DataRow("value1", "value2", null, "value4", null, null, "arg3, arg5, arg6", "arg1, arg2, arg4")]
    [DataRow("value1", "value2", "value3", null, null, null, "arg4, arg5, arg6", "arg1, arg2, arg3")]

    // Exactly four inputs missing (15 cases)
    [DataRow(null, null, null, null, "value5", "value6", "arg1, arg2, arg3, arg4", "arg5, arg6")]
    [DataRow(null, null, null, "value4", null, "value6", "arg1, arg2, arg3, arg5", "arg4, arg6")]
    [DataRow(null, null, null, "value4", "value5", null, "arg1, arg2, arg3, arg6", "arg4, arg5")]
    [DataRow(null, null, "value3", null, null, "value6", "arg1, arg2, arg4, arg5", "arg3, arg6")]
    [DataRow(null, null, "value3", null, "value5", null, "arg1, arg2, arg4, arg6", "arg3, arg5")]
    [DataRow(null, null, "value3", "value4", null, null, "arg1, arg2, arg5, arg6", "arg3, arg4")]
    [DataRow(null, "value2", null, null, null, "value6", "arg1, arg3, arg4, arg5", "arg2, arg6")]
    [DataRow(null, "value2", null, null, "value5", null, "arg1, arg3, arg4, arg6", "arg2, arg5")]
    [DataRow(null, "value2", null, "value4", null, null, "arg1, arg3, arg5, arg6", "arg2, arg4")]
    [DataRow(null, "value2", "value3", null, null, null, "arg1, arg4, arg5, arg6", "arg2, arg3")]
    [DataRow("value1", null, null, null, null, "value6", "arg2, arg3, arg4, arg5", "arg1, arg6")]
    [DataRow("value1", null, null, null, "value5", null, "arg2, arg3, arg4, arg6", "arg1, arg5")]
    [DataRow("value1", null, null, "value4", null, null, "arg2, arg3, arg5, arg6", "arg1, arg4")]
    [DataRow("value1", null, "value3", null, null, null, "arg2, arg4, arg5, arg6", "arg1, arg3")]
    [DataRow("value1", "value2", null, null, null, null, "arg3, arg4, arg5, arg6", "arg1, arg2")]

    // Exactly five inputs missing (6 cases)
    [DataRow("value1", null, null, null, null, null, "arg2, arg3, arg4, arg5, arg6", "arg1")]
    [DataRow(null, "value2", null, null, null, null, "arg1, arg3, arg4, arg5, arg6", "arg2")]
    [DataRow(null, null, "value3", null, null, null, "arg1, arg2, arg4, arg5, arg6", "arg3")]
    [DataRow(null, null, null, "value4", null, null, "arg1, arg2, arg3, arg5, arg6", "arg4")]
    [DataRow(null, null, null, null, "value5", null, "arg1, arg2, arg3, arg4, arg6", "arg5")]
    [DataRow(null, null, null, null, null, "value6", "arg1, arg2, arg3, arg4, arg5", "arg6")]

    // All six missing (1 case)
    [DataRow(null, null, null, null, null, null, "arg1, arg2, arg3, arg4, arg5, arg6", "")]
    public void AgainstNulls_With4Parameters_AllPossibleNullablePaths(object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, string contains, string notContains, bool throws = true)
    {
        var containsList = contains.Split([", "], StringSplitOptions.RemoveEmptyEntries);
        var notContainsList = notContains.Split([", "], StringSplitOptions.RemoveEmptyEntries);

        void act() => Guard.AgainstNulls(arg1, arg2, arg3, arg4, arg5, arg6, throws: true);
        GuardAgainstNullsConstants.TestWithPossibleException(act, containsList, notContainsList);

        var result = Guard.AgainstNulls(arg1, arg2, arg3, arg4, arg5, arg6, throws: false);
        GuardAgainstNullsConstants.TestWithPossibleErrorMessage(result, containsList, notContainsList);
    }
}