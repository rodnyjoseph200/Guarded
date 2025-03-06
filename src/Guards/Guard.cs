namespace Guarded.Guards;

public enum GuardType
{
    Null,
    NullOrEmpty,
    NullOrWhitespace,
    Default
}

public static partial class Guard
{
    public const string Arg1Name = "arg1";
    public const string Arg2Name = "arg2";
    public const string Arg3Name = "arg3";
    public const string Arg4Name = "arg4";
    public const string Arg5Name = "arg5";
    public const string Arg6Name = "arg6";
    public const string Arg7Name = "arg7";
    public const string Arg8Name = "arg8";
    public const string Arg9Name = "arg9";
    public const string Arg10Name = "arg10";

    private static string? HandleArgs(List<string> args, string message, bool throws)
    {
        if (args.Count is 0)
            return null;

        var errorMessage = CreateHandleArgsStringMessage(args, message);

        return throws ? throw new ArgumentException(errorMessage) :
            errorMessage;
    }

    private static string CreateHandleArgsStringMessage(List<string> nullArgs, string message) =>
        $"{message} [{string.Join(", ", nullArgs)}]";

    // todo - allows user to update the default error message
    // todo - user can do this at application startup
    private static void UpdateGlobalDefaultErrorMessage()
    {

    }
}