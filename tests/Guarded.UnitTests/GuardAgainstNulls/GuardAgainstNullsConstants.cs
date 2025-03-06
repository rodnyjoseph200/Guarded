using FluentAssertions;

namespace Guarded.UnitTests.GuardAgainstNulls;

internal static class GuardAgainstNullsConstants
{
    internal const string ErrorMessagePrefix = "Args cannot be null";

    internal static void TestWithPossibleException(Action act, string[] contains, string[] notContains)
    {
        Exception ex;

        if (contains.Length != 0)
        {
            ex = act.Should().Throw<ArgumentNullException>().Which;

            _ = ex.Message.Should().Contain(ErrorMessagePrefix)
                .And.ContainAll(contains);

            if (notContains.Length != 0)
                _ = ex.Message.Should().NotContainAny(notContains);
        }
        else
            _ = act.Should().NotThrow<ArgumentNullException>();
    }

    internal static void TestWithPossibleErrorMessage(string? result, string[] contains, string[] notContains)
    {
        if (contains.Length != 0)
            _ = result.Should().Contain(ErrorMessagePrefix)
                .And.ContainAll(contains);
        else
            if (notContains.Length != 0)
            _ = result.Should().NotContainAll(notContains);
    }
}