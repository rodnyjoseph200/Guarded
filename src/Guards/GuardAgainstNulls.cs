using System.Runtime.CompilerServices;

namespace Guarded.Guards;

public static partial class Guard
{
    public static string? AgainstNulls(
    object? arg1,
    bool throws = true,
    [CallerArgumentExpression(Arg1Name)] string arg1Name = null!)
    {

        var nullArgs = GetNullArgsParamNames(
            (arg1Name, arg1));

        return HandleNullArgs(nullArgs, throws);
    }

    public static string? AgainstNulls(
        object? arg1,
        object? arg2,
        bool throws = true,
        [CallerArgumentExpression(Arg1Name)] string arg1Name = null!,
        [CallerArgumentExpression(Arg2Name)] string arg2Name = null!)
    {

        var nullArgs = GetNullArgsParamNames(
            (arg1Name, arg1),
            (arg2Name, arg2));

        return HandleNullArgs(nullArgs, throws);
    }

    public static string? AgainstNulls(
        object? arg1,
        object? arg2,
        object? arg3,
        bool throws = true,
        [CallerArgumentExpression(Arg1Name)] string arg1Name = null!,
        [CallerArgumentExpression(Arg2Name)] string arg2Name = null!,
        [CallerArgumentExpression(Arg3Name)] string arg3Name = null!)
    {
        var nullArgs = GetNullArgsParamNames(
            (arg1Name, arg1),
            (arg2Name, arg2),
            (arg3Name, arg3));

        return HandleNullArgs(nullArgs, throws);
    }

    public static string? AgainstNulls(
        object? arg1,
        object? arg2,
        object? arg3,
        object? arg4,
        bool throws = true,
        [CallerArgumentExpression(Arg1Name)] string arg1Name = null!,
        [CallerArgumentExpression(Arg2Name)] string arg2Name = null!,
        [CallerArgumentExpression(Arg3Name)] string arg3Name = null!,
        [CallerArgumentExpression(Arg4Name)] string arg4Name = null!)
    {
        var nullArgs = GetNullArgsParamNames(
                    (arg1Name, arg1),
                    (arg2Name, arg2),
                    (arg3Name, arg3),
                    (arg4Name, arg4));

        return HandleNullArgs(nullArgs, throws);
    }

    public static string? AgainstNulls(
        object? arg1,
        object? arg2,
        object? arg3,
        object? arg4,
        object? arg5,
        bool throws = true,
        [CallerArgumentExpression(Arg1Name)] string arg1Name = null!,
        [CallerArgumentExpression(Arg2Name)] string arg2Name = null!,
        [CallerArgumentExpression(Arg3Name)] string arg3Name = null!,
        [CallerArgumentExpression(Arg4Name)] string arg4Name = null!,
        [CallerArgumentExpression(Arg5Name)] string arg5Name = null!)
    {
        var nullArgs = GetNullArgsParamNames(
            (arg1Name, arg1),
            (arg2Name, arg2),
            (arg3Name, arg3),
            (arg4Name, arg4),
            (arg5Name, arg5));

        return HandleNullArgs(nullArgs, throws);
    }

    public static string? AgainstNulls(
        object? arg1,
        object? arg2,
        object? arg3,
        object? arg4,
        object? arg5,
        object? arg6,
        bool throws = true,
        [CallerArgumentExpression(Arg1Name)] string arg1Name = null!,
        [CallerArgumentExpression(Arg2Name)] string arg2Name = null!,
        [CallerArgumentExpression(Arg3Name)] string arg3Name = null!,
        [CallerArgumentExpression(Arg4Name)] string arg4Name = null!,
        [CallerArgumentExpression(Arg5Name)] string arg5Name = null!,
        [CallerArgumentExpression(Arg6Name)] string arg6Name = null!)
    {
        var nullArgs = GetNullArgsParamNames(
            (arg1Name, arg1),
            (arg2Name, arg2),
            (arg3Name, arg3),
            (arg4Name, arg4),
            (arg5Name, arg5),
            (arg6Name, arg6));

        return HandleNullArgs(nullArgs, throws);
    }

    public static string? AgainstNulls(
        object? arg1,
        object? arg2,
        object? arg3,
        object? arg4,
        object? arg5,
        object? arg6,
        object? arg7,
        bool throws = true,
        [CallerArgumentExpression(Arg1Name)] string arg1Name = null!,
        [CallerArgumentExpression(Arg2Name)] string arg2Name = null!,
        [CallerArgumentExpression(Arg3Name)] string arg3Name = null!,
        [CallerArgumentExpression(Arg4Name)] string arg4Name = null!,
        [CallerArgumentExpression(Arg5Name)] string arg5Name = null!,
        [CallerArgumentExpression(Arg6Name)] string arg6Name = null!,
        [CallerArgumentExpression(Arg7Name)] string arg7Name = null!)
    {
        var nullArgs = GetNullArgsParamNames(
            (arg1Name, arg1),
            (arg2Name, arg2),
            (arg3Name, arg3),
            (arg4Name, arg4),
            (arg5Name, arg5),
            (arg6Name, arg6),
            (arg7Name, arg7));

        return HandleNullArgs(nullArgs, throws);
    }

    public static string? AgainstNulls(
        object? arg1,
        object? arg2,
        object? arg3,
        object? arg4,
        object? arg5,
        object? arg6,
        object? arg7,
        object? arg8,
        bool throws = true,
        [CallerArgumentExpression(Arg1Name)] string arg1Name = null!,
        [CallerArgumentExpression(Arg2Name)] string arg2Name = null!,
        [CallerArgumentExpression(Arg3Name)] string arg3Name = null!,
        [CallerArgumentExpression(Arg4Name)] string arg4Name = null!,
        [CallerArgumentExpression(Arg5Name)] string arg5Name = null!,
        [CallerArgumentExpression(Arg6Name)] string arg6Name = null!,
        [CallerArgumentExpression(Arg7Name)] string arg7Name = null!,
        [CallerArgumentExpression(Arg8Name)] string arg8Name = null!)
    {
        var nullArgs = GetNullArgsParamNames(
            (arg1Name, arg1),
            (arg2Name, arg2),
            (arg3Name, arg3),
            (arg4Name, arg4),
            (arg5Name, arg5),
            (arg6Name, arg6),
            (arg7Name, arg7),
            (arg8Name, arg8));

        return HandleNullArgs(nullArgs, throws);
    }

    public static string? AgainstNulls(
        object? arg1,
        object? arg2,
        object? arg3,
        object? arg4,
        object? arg5,
        object? arg6,
        object? arg7,
        object? arg8,
        object? arg9,
        bool throws = true,
        [CallerArgumentExpression(Arg1Name)] string arg1Name = null!,
        [CallerArgumentExpression(Arg2Name)] string arg2Name = null!,
        [CallerArgumentExpression(Arg3Name)] string arg3Name = null!,
        [CallerArgumentExpression(Arg4Name)] string arg4Name = null!,
        [CallerArgumentExpression(Arg5Name)] string arg5Name = null!,
        [CallerArgumentExpression(Arg6Name)] string arg6Name = null!,
        [CallerArgumentExpression(Arg7Name)] string arg7Name = null!,
        [CallerArgumentExpression(Arg8Name)] string arg8Name = null!,
        [CallerArgumentExpression(Arg9Name)] string arg9Name = null!)
    {
        var nullArgs = GetNullArgsParamNames(
            (arg1Name, arg1),
            (arg2Name, arg2),
            (arg3Name, arg3),
            (arg4Name, arg4),
            (arg5Name, arg5),
            (arg6Name, arg6),
            (arg7Name, arg7),
            (arg8Name, arg8),
            (arg9Name, arg9));

        return HandleNullArgs(nullArgs, throws);
    }

    public static string? AgainstNulls(
        object? arg1,
        object? arg2,
        object? arg3,
        object? arg4,
        object? arg5,
        object? arg6,
        object? arg7,
        object? arg8,
        object? arg9,
        object? arg10,
        bool throws = true,
        [CallerArgumentExpression(Arg1Name)] string arg1Name = null!,
        [CallerArgumentExpression(Arg2Name)] string arg2Name = null!,
        [CallerArgumentExpression(Arg3Name)] string arg3Name = null!,
        [CallerArgumentExpression(Arg4Name)] string arg4Name = null!,
        [CallerArgumentExpression(Arg5Name)] string arg5Name = null!,
        [CallerArgumentExpression(Arg6Name)] string arg6Name = null!,
        [CallerArgumentExpression(Arg7Name)] string arg7Name = null!,
        [CallerArgumentExpression(Arg8Name)] string arg8Name = null!,
        [CallerArgumentExpression(Arg9Name)] string arg9Name = null!,
        [CallerArgumentExpression(Arg10Name)] string arg10Name = null!)
    {
        var nullArgs = GetNullArgsParamNames(
            (arg1Name, arg1),
            (arg2Name, arg2),
            (arg3Name, arg3),
            (arg4Name, arg4),
            (arg5Name, arg5),
            (arg6Name, arg6),
            (arg7Name, arg7),
            (arg8Name, arg8),
            (arg9Name, arg9),
            (arg10Name, arg10));

        return HandleNullArgs(nullArgs, throws);
    }

    private static List<string> GetNullArgsParamNames(params (string paramName, object? value)[] args)
    {
        var nullArgs = new List<string>();
        foreach (var (paramName, value) in args)
        {
            if (value is null)
                nullArgs.Add(paramName);
        }

        return nullArgs;
    }

    private static string? HandleNullArgs(List<string> nullArgs, bool throws)
    {
        if (nullArgs.Count is 0)
            return null;

        var errorMessage = CreateHandleArgsStringMessage(nullArgs, "Args cannot be null");

        return throws ? throw new ArgumentNullException(errorMessage) :
            errorMessage;
    }
}