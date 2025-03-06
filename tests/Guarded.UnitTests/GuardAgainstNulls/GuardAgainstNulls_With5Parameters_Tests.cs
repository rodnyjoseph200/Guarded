using Guarded.Guards;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Guarded.UnitTests.GuardAgainstNulls;

[TestClass]
public class GuardAgainstNulls_With5Parameters_Tests
{
    [TestMethod]
    // All inputs provided:
    [DataRow("value1", "value2", "value3", "value4", "value5", "", "arg1, arg2, arg3, arg4, arg5")]

    // Exactly one input missing:
    [DataRow(null, "value2", "value3", "value4", "value5", "arg1", "arg2, arg3, arg4, arg5")]
    [DataRow("value1", null, "value3", "value4", "value5", "arg2", "arg1, arg3, arg4, arg5")]
    [DataRow("value1", "value2", null, "value4", "value5", "arg3", "arg1, arg2, arg4, arg5")]
    [DataRow("value1", "value2", "value3", null, "value5", "arg4", "arg1, arg2, arg3, arg5")]
    [DataRow("value1", "value2", "value3", "value4", null, "arg5", "arg1, arg2, arg3, arg4")]

    // Exactly two inputs missing:
    [DataRow(null, null, "value3", "value4", "value5", "arg1, arg2", "arg3, arg4, arg5")]
    [DataRow(null, "value2", null, "value4", "value5", "arg1, arg3", "arg2, arg4, arg5")]
    [DataRow(null, "value2", "value3", null, "value5", "arg1, arg4", "arg2, arg3, arg5")]
    [DataRow(null, "value2", "value3", "value4", null, "arg1, arg5", "arg2, arg3, arg4")]
    [DataRow("value1", null, null, "value4", "value5", "arg2, arg3", "arg1, arg4, arg5")]
    [DataRow("value1", null, "value3", null, "value5", "arg2, arg4", "arg1, arg3, arg5")]
    [DataRow("value1", null, "value3", "value4", null, "arg2, arg5", "arg1, arg3, arg4")]
    [DataRow("value1", "value2", null, null, "value5", "arg3, arg4", "arg1, arg2, arg5")]
    [DataRow("value1", "value2", null, "value4", null, "arg3, arg5", "arg1, arg2, arg4")]
    [DataRow("value1", "value2", "value3", null, null, "arg4, arg5", "arg1, arg2, arg3")]

    // Exactly three inputs missing:
    [DataRow(null, null, null, "value4", "value5", "arg1, arg2, arg3", "arg4, arg5")]
    [DataRow(null, null, "value3", null, "value5", "arg1, arg2, arg4", "arg3, arg5")]
    [DataRow(null, null, "value3", "value4", null, "arg1, arg2, arg5", "arg3, arg4")]
    [DataRow(null, "value2", null, null, "value5", "arg1, arg3, arg4", "arg2, arg5")]
    [DataRow(null, "value2", null, "value4", null, "arg1, arg3, arg5", "arg2, arg4")]
    [DataRow(null, "value2", "value3", null, null, "arg1, arg4, arg5", "arg2, arg3")]
    [DataRow("value1", null, null, null, "value5", "arg2, arg3, arg4", "arg1, arg5")]
    [DataRow("value1", null, null, "value4", null, "arg2, arg3, arg5", "arg1, arg4")]
    [DataRow("value1", null, "value3", null, null, "arg2, arg4, arg5", "arg1, arg3")]
    [DataRow("value1", "value2", null, null, null, "arg3, arg4, arg5", "arg1, arg2")]

    // Exactly four inputs missing (only one provided):
    // Provided at position 1:
    [DataRow("value1", null, null, null, null, "arg2, arg3, arg4, arg5", "arg1")]
    // Provided at position 2:
    [DataRow(null, "value2", null, null, null, "arg1, arg3, arg4, arg5", "arg2")]
    // Provided at position 3:
    [DataRow(null, null, "value3", null, null, "arg1, arg2, arg4, arg5", "arg3")]
    // Provided at position 4:
    [DataRow(null, null, null, "value4", null, "arg1, arg2, arg3, arg5", "arg4")]
    // Provided at position 5:
    [DataRow(null, null, null, null, "value5", "arg1, arg2, arg3, arg4", "arg5")]

    // All inputs missing:
    [DataRow(null, null, null, null, null, "arg1, arg2, arg3, arg4, arg5", "")]
    public void AgainstNulls_With5Parameters_AllPossibleNullablePaths(object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, string contains, string notContains)
    {
        var containsList = contains.Split([", "], StringSplitOptions.RemoveEmptyEntries);
        var notContainsList = notContains.Split([", "], StringSplitOptions.RemoveEmptyEntries);

        void act() => Guard.AgainstNulls(arg1, arg2, arg3, arg4, arg5, throws: true);
        GuardAgainstNullsConstants.TestWithPossibleException(act, containsList, notContainsList);

        var result = Guard.AgainstNulls(arg1, arg2, arg3, arg4, arg5, throws: false);
        GuardAgainstNullsConstants.TestWithPossibleErrorMessage(result, containsList, notContainsList);
    }
}