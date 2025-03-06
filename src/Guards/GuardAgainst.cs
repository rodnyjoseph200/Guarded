using System.Runtime.CompilerServices;

namespace Guarded.Guards;

public static partial class Guard
{
    public static string? Against<T>(
    object? arg1,
    bool throws = true,
    [CallerArgumentExpression(Arg1Name)] string arg1Name = null!) where T : Enum
    {
        return (GuardType)Enum.Parse(typeof(T), typeof(T).Name) switch
        {
            GuardType.Null => AgainstNulls(arg1, throws, arg1Name),
            GuardType.NullOrWhitespace => AgainstNullsAndWhitespaces(arg1, throws, arg1Name),
            GuardType.NullOrEmpty => AgainstNullsAndEmpties(arg1, throws, arg1Name),
            GuardType.Default => AgainstDefaults(arg1, throws, arg1Name),
            _ => HandleGuardTypeNotSupported()
        };
    }

    public static string? Against<T>(
        object? arg1,
        object? arg2,
        bool throws = true,
        [CallerArgumentExpression(Arg1Name)] string arg1Name = null!,
        [CallerArgumentExpression(Arg2Name)] string arg2Name = null!) where T : Enum
    {
        return (GuardType)Enum.Parse(typeof(T), typeof(T).Name) switch
        {
            GuardType.Null => AgainstNulls(arg1, arg2, throws, arg1Name, arg2Name),
            GuardType.NullOrWhitespace => AgainstNullsAndWhitespaces(arg1, arg2, throws, arg1Name, arg2Name),
            GuardType.NullOrEmpty => AgainstNullsAndEmpties(arg1, arg2, throws, arg1Name, arg2Name),
            GuardType.Default => AgainstDefaults(arg1, arg2, throws, arg1Name, arg2Name),
            _ => HandleGuardTypeNotSupported(),
        };
    }

    public static string? Against<T>(
        object? arg1,
        object? arg2,
        object? arg3,
        bool throws = true,
        [CallerArgumentExpression(Arg1Name)] string arg1Name = null!,
        [CallerArgumentExpression(Arg2Name)] string arg2Name = null!,
        [CallerArgumentExpression(Arg3Name)] string arg3Name = null!) where T : Enum
    {
        return (GuardType)Enum.Parse(typeof(T), typeof(T).Name) switch
        {
            GuardType.Null => AgainstNulls(arg1, arg2, arg3, throws, arg1Name, arg2Name, arg3Name),
            GuardType.NullOrWhitespace => AgainstNullsAndWhitespaces(arg1, arg2, arg3, throws, arg1Name, arg2Name, arg3Name),
            GuardType.NullOrEmpty => AgainstNullsAndEmpties(arg1, arg2, arg3, throws, arg1Name, arg2Name, arg3Name),
            GuardType.Default => AgainstDefaults(arg1, arg2, arg3, throws, arg1Name, arg2Name, arg3Name),
            _ => HandleGuardTypeNotSupported(),
        };
    }

    public static string? Against<T>(
        object? arg1,
        object? arg2,
        object? arg3,
        object? arg4,
        bool throws = true,
        [CallerArgumentExpression(Arg1Name)] string arg1Name = null!,
        [CallerArgumentExpression(Arg2Name)] string arg2Name = null!,
        [CallerArgumentExpression(Arg3Name)] string arg3Name = null!,
        [CallerArgumentExpression(Arg4Name)] string arg4Name = null!) where T : Enum
    {
        return (GuardType)Enum.Parse(typeof(T), typeof(T).Name) switch
        {
            GuardType.Null => AgainstNulls(arg1, arg2, arg3, arg4, throws, arg1Name, arg2Name, arg3Name, arg4Name),
            GuardType.NullOrWhitespace => AgainstNullsAndWhitespaces(arg1, arg2, arg3, arg4, throws, arg1Name, arg2Name, arg3Name, arg4Name),
            GuardType.NullOrEmpty => AgainstNullsAndEmpties(arg1, arg2, arg3, arg4, throws, arg1Name, arg2Name, arg3Name, arg4Name),
            GuardType.Default => AgainstDefaults(arg1, arg2, arg3, arg4, throws, arg1Name, arg2Name, arg3Name, arg4Name),
            _ => HandleGuardTypeNotSupported(),
        };
    }

    public static string? Against<T>(
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
        [CallerArgumentExpression(Arg5Name)] string arg5Name = null!) where T : Enum
    {
        return (GuardType)Enum.Parse(typeof(T), typeof(T).Name) switch
        {
            GuardType.Null => AgainstNulls(arg1, arg2, arg3, arg4, arg5, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name),
            GuardType.NullOrWhitespace => AgainstNullsAndWhitespaces(arg1, arg2, arg3, arg4, arg5, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name),
            GuardType.NullOrEmpty => AgainstNullsAndEmpties(arg1, arg2, arg3, arg4, arg5, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name),
            GuardType.Default => AgainstDefaults(arg1, arg2, arg3, arg4, arg5, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name),
            _ => HandleGuardTypeNotSupported(),
        };
    }

    public static string? Against<T>(
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
        [CallerArgumentExpression(Arg6Name)] string arg6Name = null!) where T : Enum
    {
        return (GuardType)Enum.Parse(typeof(T), typeof(T).Name) switch
        {
            GuardType.Null => AgainstNulls(arg1, arg2, arg3, arg4, arg5, arg6, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name),
            GuardType.NullOrWhitespace => AgainstNullsAndWhitespaces(arg1, arg2, arg3, arg4, arg5, arg6, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name),
            GuardType.NullOrEmpty => AgainstNullsAndEmpties(arg1, arg2, arg3, arg4, arg5, arg6, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name),
            GuardType.Default => AgainstDefaults(arg1, arg2, arg3, arg4, arg5, arg6, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name),
            _ => HandleGuardTypeNotSupported(),
        };
    }

    public static string? Against<T>(
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
        [CallerArgumentExpression(Arg7Name)] string arg7Name = null!) where T : Enum
    {
        return (GuardType)Enum.Parse(typeof(T), typeof(T).Name) switch
        {
            GuardType.Null => AgainstNulls(arg1, arg2, arg3, arg4, arg5, arg6, arg7, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name, arg7Name),
            GuardType.NullOrWhitespace => AgainstNullsAndWhitespaces(arg1, arg2, arg3, arg4, arg5, arg6, arg7, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name, arg7Name),
            GuardType.NullOrEmpty => AgainstNullsAndEmpties(arg1, arg2, arg3, arg4, arg5, arg6, arg7, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name, arg7Name),
            GuardType.Default => AgainstDefaults(arg1, arg2, arg3, arg4, arg5, arg6, arg7, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name, arg7Name),
            _ => HandleGuardTypeNotSupported(),
        };
    }

    public static string? Against<T>(
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
    [CallerArgumentExpression(Arg8Name)] string arg8Name = null!) where T : Enum
    {
        return (GuardType)Enum.Parse(typeof(T), typeof(T).Name) switch
        {
            GuardType.Null => AgainstNulls(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name, arg7Name, arg8Name),
            GuardType.NullOrWhitespace => AgainstNullsAndWhitespaces(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name, arg7Name, arg8Name),
            GuardType.NullOrEmpty => AgainstNullsAndEmpties(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name, arg7Name, arg8Name),
            GuardType.Default => AgainstDefaults(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name, arg7Name, arg8Name),
            _ => HandleGuardTypeNotSupported(),
        };
    }

    public static string? Against<T>(
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
        [CallerArgumentExpression(Arg9Name)] string arg9Name = null!) where T : Enum
    {
        return (GuardType)Enum.Parse(typeof(T), typeof(T).Name) switch
        {
            GuardType.Null => AgainstNulls(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name, arg7Name, arg8Name, arg9Name),
            GuardType.NullOrWhitespace => AgainstNullsAndWhitespaces(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name, arg7Name, arg8Name, arg9Name),
            GuardType.NullOrEmpty => AgainstNullsAndEmpties(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name, arg7Name, arg8Name, arg9Name),
            GuardType.Default => AgainstDefaults(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name, arg7Name, arg8Name, arg9Name),
            _ => HandleGuardTypeNotSupported(),
        };
    }

    public static string? Against<T>(
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
        [CallerArgumentExpression(Arg10Name)] string arg10Name = null!) where T : Enum
    {
        return (GuardType)Enum.Parse(typeof(T), typeof(T).Name) switch
        {
            GuardType.Null => AgainstNulls(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name, arg7Name, arg8Name, arg9Name, arg10Name),
            GuardType.NullOrWhitespace => AgainstNullsAndWhitespaces(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name, arg7Name, arg8Name, arg9Name, arg10Name),
            GuardType.NullOrEmpty => AgainstNullsAndEmpties(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name, arg7Name, arg8Name, arg9Name, arg10Name),
            GuardType.Default => AgainstDefaults(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, throws, arg1Name, arg2Name, arg3Name, arg4Name, arg5Name, arg6Name, arg7Name, arg8Name, arg9Name, arg10Name),
            _ => HandleGuardTypeNotSupported(),
        };
    }

    private static string? HandleGuardTypeNotSupported() =>
        throw new NotSupportedException("GuardType not supported");
}