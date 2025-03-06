using FluentAssertions;
using Guarded.Guards;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Guarded.UnitTests.GuardAgainstNulls;

[TestClass]
public class GuardAgainstNulls_With1Parameter_Tests
{
    [TestMethod]
    [DataRow(null, "arg1")]
    public void AgainstNulls_With1Parameter_AllPossibleNullablePaths(object? arg1, string contains)
    {
        Action act = () => Guard.AgainstNulls(arg1, throws: true);
        var result = Guard.AgainstNulls(arg1, throws: false);

        _ = act.Should().Throw<ArgumentNullException>()
            .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
            .And.Contain(contains);

        _ = result.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(contains);
    }
}