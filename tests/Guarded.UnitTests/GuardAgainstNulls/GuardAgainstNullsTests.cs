using FluentAssertions;
using Guarded.Guards;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Guarded.UnitTests.GuardAgainstNulls;

[TestClass]
public class GuardAgainstNullsTests
{
    [TestMethod]
    public void AgainstNulls_WithAllArgumentsNonNull_ShouldReturnNull()
    {
        var testArg1 = new object();
        var testArg2 = new object();
        var testArg3 = new object();
        var testArg4 = new object();
        var testArg5 = new object();
        var testArg6 = new object();
        var testArg7 = new object();
        var testArg8 = new object();
        var testArg9 = new object();
        var testArg10 = new object();

        var result1 = Guard.AgainstNulls(testArg1);
        var result2 = Guard.AgainstNulls(testArg1, testArg2);
        var result3 = Guard.AgainstNulls(testArg1, testArg2, testArg3);
        var result4 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4);
        var result5 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5);
        var result6 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6);
        var result7 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7);
        var result8 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8);
        var result9 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9);
        var result10 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9, testArg10);

        _ = result1.Should().BeNull();
        _ = result2.Should().BeNull();
        _ = result3.Should().BeNull();
        _ = result4.Should().BeNull();
        _ = result5.Should().BeNull();
        _ = result6.Should().BeNull();
        _ = result7.Should().BeNull();
        _ = result8.Should().BeNull();
        _ = result9.Should().BeNull();
        _ = result10.Should().BeNull();
    }

    [TestMethod]
    public void AgainstNulls_WhenFirstArgumentIsNullAndThrowsTrue_ShouldThrowArgumentNullException()
    {
        object? testArg1 = null;
        var testArg2 = new object();
        var testArg3 = new object();
        var testArg4 = new object();
        var testArg5 = new object();
        var testArg6 = new object();
        var testArg7 = new object();
        var testArg8 = new object();
        var testArg9 = new object();
        var testArg10 = new object();

        Action act1 = () => Guard.AgainstNulls(testArg1, throws: true);
        Action act2 = () => Guard.AgainstNulls(testArg1, testArg2, throws: true);
        Action act3 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, throws: true);
        Action act4 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, throws: true);
        Action act5 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, throws: true);
        Action act6 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, throws: true);
        Action act7 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, throws: true);
        Action act8 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, throws: true);
        Action act9 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9, throws: true);
        Action act10 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9, testArg10, throws: true);

        _ = act1.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1));

        _ = act2.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2));

        _ = act3.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg3));

        _ = act4.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4));

        _ = act5.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5));

        _ = act6.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6));

        _ = act7.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7));

        _ = act8.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8));

        _ = act9.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8))
                    .And.NotContain(nameof(testArg9));

        _ = act10.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8))
                    .And.NotContain(nameof(testArg9))
                    .And.NotContain(nameof(testArg10));
    }

    [TestMethod]
    public void AgainstNulls_WhenFirstArgumentIsNullAndThrowsFalse_ShouldReturnErrorMessage()
    {
        object? testArg1 = null;
        var testArg2 = new object();
        var testArg3 = new object();
        var testArg4 = new object();
        var testArg5 = new object();
        var testArg6 = new object();
        var testArg7 = new object();
        var testArg8 = new object();
        var testArg9 = new object();
        var testArg10 = new object();

        var result1 = Guard.AgainstNulls(testArg1, throws: false);
        var result2 = Guard.AgainstNulls(testArg1, testArg2, throws: false);
        var result3 = Guard.AgainstNulls(testArg1, testArg2, testArg3, throws: false);
        var result4 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, throws: false);
        var result5 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, throws: false);
        var result6 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, throws: false);
        var result7 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, throws: false);
        var result8 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, throws: false);
        var result9 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9, throws: false);
        var result10 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9, testArg10, throws: false);

        _ = result1.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1));

        _ = result2.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2));

        _ = result3.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg3));

        _ = result4.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4));

        _ = result5.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5));

        _ = result6.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6));

        _ = result7.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7));

        _ = result8.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8));

        _ = result9.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8))
                    .And.NotContain(nameof(testArg9));

        _ = result10.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8))
                    .And.NotContain(nameof(testArg9))
                    .And.NotContain(nameof(testArg10));
    }

    [TestMethod]
    public void AgainstNulls_WhenSecondArgumentIsNullAndThrowsTrue_ShouldThrowArgumentNullException()
    {
        var testArg1 = new object();
        object? testArg2 = null;
        var testArg3 = new object();
        var testArg4 = new object();
        var testArg5 = new object();
        var testArg6 = new object();
        var testArg7 = new object();
        var testArg8 = new object();
        var testArg9 = new object();
        var testArg10 = new object();

        Action act2 = () => Guard.AgainstNulls(testArg1, testArg2, throws: true);
        Action act3 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, throws: true);
        Action act4 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, throws: true);
        Action act5 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, throws: true);
        Action act6 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, throws: true);
        Action act7 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, throws: true);
        Action act8 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, throws: true);
        Action act9 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9, throws: true);
        Action act10 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9, testArg10, throws: true);

        _ = act2.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1));

        _ = act3.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg3));

        _ = act4.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4));

        _ = act5.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5));

        _ = act6.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6));

        _ = act7.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7));

        _ = act8.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8));

        _ = act9.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8))
                    .And.NotContain(nameof(testArg9));

        _ = act10.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8))
                    .And.NotContain(nameof(testArg9))
                    .And.NotContain(nameof(testArg10));
    }

    [TestMethod]
    public void AgainstNulls_WhenSecondArgumentIsNullAndThrowsFalse_ShouldReturnErrorMessage()
    {
        var testArg1 = new object();
        object? testArg2 = null;
        var testArg3 = new object();
        var testArg4 = new object();
        var testArg5 = new object();
        var testArg6 = new object();
        var testArg7 = new object();
        var testArg8 = new object();
        var testArg9 = new object();
        var testArg10 = new object();

        var result2 = Guard.AgainstNulls(testArg1, testArg2, throws: false);
        var result3 = Guard.AgainstNulls(testArg1, testArg2, testArg3, throws: false);
        var result4 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, throws: false);
        var result5 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, throws: false);
        var result6 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, throws: false);
        var result7 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, throws: false);
        var result8 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, throws: false);
        var result9 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9, throws: false);
        var result10 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9, testArg10, throws: false);

        _ = result2.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1));

        _ = result3.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg3));

        _ = result4.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4));

        _ = result5.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5));

        _ = result6.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6));

        _ = result7.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7));

        _ = result8.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8));

        _ = result9.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8))
                    .And.NotContain(nameof(testArg9));

        _ = result10.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg2))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg3))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8))
                    .And.NotContain(nameof(testArg9))
                    .And.NotContain(nameof(testArg10));
    }

    [TestMethod]
    public void AgainstNulls_WhenThirdArgumentIsNullAndThrowsTrue_ShouldThrowArgumentNullException()
    {
        var testArg1 = new object();
        var testArg2 = new object();
        object? testArg3 = null;
        var testArg4 = new object();
        var testArg5 = new object();
        var testArg6 = new object();
        var testArg7 = new object();
        var testArg8 = new object();
        var testArg9 = new object();
        var testArg10 = new object();

        Action act3 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, throws: true);
        Action act4 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, throws: true);
        Action act5 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, throws: true);
        Action act6 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, throws: true);
        Action act7 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, throws: true);
        Action act8 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, throws: true);
        Action act9 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9, throws: true);
        Action act10 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9, testArg10, throws: true);

        _ = act3.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg3))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2));

        _ = act4.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg3))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg4));

        _ = act5.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg3))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5));

        _ = act6.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg3))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6));

        _ = act7.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg3))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7));

        _ = act8.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg3))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8));

        _ = act9.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg3))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8))
                    .And.NotContain(nameof(testArg9));

        _ = act10.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg3))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8))
                    .And.NotContain(nameof(testArg9))
                    .And.NotContain(nameof(testArg10));
    }

    [TestMethod]
    public void AgainstNulls_WhenThirdArgumentIsNullAndThrowsFalse_ShouldReturnErrorMessage()
    {
        var testArg1 = new object();
        var testArg2 = new object();
        object? testArg3 = null;
        var testArg4 = new object();
        var testArg5 = new object();
        var testArg6 = new object();
        var testArg7 = new object();
        var testArg8 = new object();
        var testArg9 = new object();
        var testArg10 = new object();

        var result3 = Guard.AgainstNulls(testArg1, testArg2, testArg3, throws: false);
        var result4 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, throws: false);
        var result5 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, throws: false);
        var result6 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, throws: false);
        var result7 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, throws: false);
        var result8 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, throws: false);
        var result9 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9, throws: false);
        var result10 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9, testArg10, throws: false);

        _ = result3.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg3))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2));

        _ = result4.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg3))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg4));

        _ = result5.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg3))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5));

        _ = result6.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg3))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6));

        _ = result7.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg3))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7));

        _ = result8.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg3))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8));

        _ = result9.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg3))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8))
                    .And.NotContain(nameof(testArg9));

        _ = result10.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg3))
                    .And.NotContain(nameof(testArg1))
                    .And.NotContain(nameof(testArg2))
                    .And.NotContain(nameof(testArg4))
                    .And.NotContain(nameof(testArg5))
                    .And.NotContain(nameof(testArg6))
                    .And.NotContain(nameof(testArg7))
                    .And.NotContain(nameof(testArg8))
                    .And.NotContain(nameof(testArg9))
                    .And.NotContain(nameof(testArg10));
    }

    [TestMethod]
    public void AgainstNulls_WhenAllArgumentsAreNullAndThrowsTrue_ShouldThrowArgumentNullException()
    {
        object? testArg1 = null;
        object? testArg2 = null;
        object? testArg3 = null;
        object? testArg4 = null;
        object? testArg5 = null;
        object? testArg6 = null;
        object? testArg7 = null;
        object? testArg8 = null;
        object? testArg9 = null;
        object? testArg10 = null;

        Action act1 = () => Guard.AgainstNulls(testArg1, throws: true);
        Action act2 = () => Guard.AgainstNulls(testArg1, testArg2, throws: true);
        Action act3 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, throws: true);
        Action act4 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, throws: true);
        Action act5 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, throws: true);
        Action act6 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, throws: true);
        Action act7 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, throws: true);
        Action act8 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, throws: true);
        Action act9 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9, throws: true);
        Action act10 = () => Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9, testArg10, throws: true);

        _ = act1.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1));

        _ = act2.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2));

        _ = act3.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2))
                    .And.Contain(nameof(testArg3));

        _ = act4.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2))
                    .And.Contain(nameof(testArg3))
                    .And.Contain(nameof(testArg4));

        _ = act5.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2))
                    .And.Contain(nameof(testArg3))
                    .And.Contain(nameof(testArg4))
                    .And.Contain(nameof(testArg5));

        _ = act6.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2))
                    .And.Contain(nameof(testArg3))
                    .And.Contain(nameof(testArg4))
                    .And.Contain(nameof(testArg5))
                    .And.Contain(nameof(testArg6));

        _ = act7.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2))
                    .And.Contain(nameof(testArg3))
                    .And.Contain(nameof(testArg4))
                    .And.Contain(nameof(testArg5))
                    .And.Contain(nameof(testArg6))
                    .And.Contain(nameof(testArg7));

        _ = act8.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2))
                    .And.Contain(nameof(testArg3))
                    .And.Contain(nameof(testArg4))
                    .And.Contain(nameof(testArg5))
                    .And.Contain(nameof(testArg6))
                    .And.Contain(nameof(testArg7))
                    .And.Contain(nameof(testArg8));

        _ = act9.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2))
                    .And.Contain(nameof(testArg3))
                    .And.Contain(nameof(testArg4))
                    .And.Contain(nameof(testArg5))
                    .And.Contain(nameof(testArg6))
                    .And.Contain(nameof(testArg7))
                    .And.Contain(nameof(testArg8))
                    .And.Contain(nameof(testArg9));

        _ = act10.Should().Throw<ArgumentNullException>()
                    .And.Message.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2))
                    .And.Contain(nameof(testArg3))
                    .And.Contain(nameof(testArg4))
                    .And.Contain(nameof(testArg5))
                    .And.Contain(nameof(testArg6))
                    .And.Contain(nameof(testArg7))
                    .And.Contain(nameof(testArg8))
                    .And.Contain(nameof(testArg9))
                    .And.Contain(nameof(testArg10));
    }

    [TestMethod]
    public void AgainstNulls_WhenAllArgumentsAreNullAndThrowsFalse_ShouldReturnErrorMessage()
    {
        object? testArg1 = null;
        object? testArg2 = null;
        object? testArg3 = null;
        object? testArg4 = null;
        object? testArg5 = null;
        object? testArg6 = null;
        object? testArg7 = null;
        object? testArg8 = null;
        object? testArg9 = null;
        object? testArg10 = null;

        var result1 = Guard.AgainstNulls(testArg1, throws: false);
        var result2 = Guard.AgainstNulls(testArg1, testArg2, throws: false);
        var result3 = Guard.AgainstNulls(testArg1, testArg2, testArg3, throws: false);
        var result4 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, throws: false);
        var result5 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, throws: false);
        var result6 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, throws: false);
        var result7 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, throws: false);
        var result8 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, throws: false);
        var result9 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9, throws: false);
        var result10 = Guard.AgainstNulls(testArg1, testArg2, testArg3, testArg4, testArg5, testArg6, testArg7, testArg8, testArg9, testArg10, throws: false);

        _ = result1.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1));

        _ = result2.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2));

        _ = result3.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2))
                    .And.Contain(nameof(testArg3));

        _ = result4.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2))
                    .And.Contain(nameof(testArg3))
                    .And.Contain(nameof(testArg4));

        _ = result5.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2))
                    .And.Contain(nameof(testArg3))
                    .And.Contain(nameof(testArg4))
                    .And.Contain(nameof(testArg5));

        _ = result6.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2))
                    .And.Contain(nameof(testArg3))
                    .And.Contain(nameof(testArg4))
                    .And.Contain(nameof(testArg5))
                    .And.Contain(nameof(testArg6));

        _ = result7.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2))
                    .And.Contain(nameof(testArg3))
                    .And.Contain(nameof(testArg4))
                    .And.Contain(nameof(testArg5))
                    .And.Contain(nameof(testArg6))
                    .And.Contain(nameof(testArg7));

        _ = result8.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2))
                    .And.Contain(nameof(testArg3))
                    .And.Contain(nameof(testArg4))
                    .And.Contain(nameof(testArg5))
                    .And.Contain(nameof(testArg6))
                    .And.Contain(nameof(testArg7))
                    .And.Contain(nameof(testArg8));

        _ = result9.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2))
                    .And.Contain(nameof(testArg3))
                    .And.Contain(nameof(testArg4))
                    .And.Contain(nameof(testArg5))
                    .And.Contain(nameof(testArg6))
                    .And.Contain(nameof(testArg7))
                    .And.Contain(nameof(testArg8))
                    .And.Contain(nameof(testArg9));

        _ = result10.Should().Contain(GuardAgainstNullsConstants.ErrorMessagePrefix)
                    .And.Contain(nameof(testArg1))
                    .And.Contain(nameof(testArg2))
                    .And.Contain(nameof(testArg3))
                    .And.Contain(nameof(testArg4))
                    .And.Contain(nameof(testArg5))
                    .And.Contain(nameof(testArg6))
                    .And.Contain(nameof(testArg7))
                    .And.Contain(nameof(testArg8))
                    .And.Contain(nameof(testArg9))
                    .And.Contain(nameof(testArg10));
    }
}