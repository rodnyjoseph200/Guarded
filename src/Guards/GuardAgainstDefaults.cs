﻿using System.Runtime.CompilerServices;

namespace Guarded.Guards;

public static partial class Guard
{
    public static string? AgainstDefaults(
        object? arg1,
        bool throws = true,
        [CallerArgumentExpression(Arg1Name)] string arg1Name = null!)
    {
        var nullArgs = GetDefaultArgsParamNames((arg1Name, arg1));
        return HandleDefaultArgs(nullArgs, throws);
    }

    public static string? AgainstDefaults(
        object? arg1,
        object? arg2,
        bool throws = true,
        [CallerArgumentExpression(Arg1Name)] string arg1Name = null!,
        [CallerArgumentExpression(Arg2Name)] string arg2Name = null!)
    {
        var nullArgs = GetDefaultArgsParamNames(
            (arg1Name, arg1),
            (arg2Name, arg2));
        return HandleDefaultArgs(nullArgs, throws);
    }

    public static string? AgainstDefaults(
        object? arg1,
        object? arg2,
        object? arg3,
        bool throws = true,
        [CallerArgumentExpression(Arg1Name)] string arg1Name = null!,
        [CallerArgumentExpression(Arg2Name)] string arg2Name = null!,
        [CallerArgumentExpression(Arg3Name)] string arg3Name = null!)
    {
        var nullArgs = GetDefaultArgsParamNames(
            (arg1Name, arg1),
            (arg2Name, arg2),
            (arg3Name, arg3));
        return HandleDefaultArgs(nullArgs, throws);
    }

    public static string? AgainstDefaults(
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
        var nullArgs = GetDefaultArgsParamNames(
            (arg1Name, arg1),
            (arg2Name, arg2),
            (arg3Name, arg3),
            (arg4Name, arg4));
        return HandleDefaultArgs(nullArgs, throws);
    }

    public static string? AgainstDefaults(
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
        var nullArgs = GetDefaultArgsParamNames(
            (arg1Name, arg1),
            (arg2Name, arg2),
            (arg3Name, arg3),
            (arg4Name, arg4),
            (arg5Name, arg5));
        return HandleDefaultArgs(nullArgs, throws);
    }

    public static string? AgainstDefaults(
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
        var nullArgs = GetDefaultArgsParamNames(
            (arg1Name, arg1),
            (arg2Name, arg2),
            (arg3Name, arg3),
            (arg4Name, arg4),
            (arg5Name, arg5),
            (arg6Name, arg6));
        return HandleDefaultArgs(nullArgs, throws);
    }

    public static string? AgainstDefaults(
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
        var nullArgs = GetDefaultArgsParamNames(
            (arg1Name, arg1),
            (arg2Name, arg2),
            (arg3Name, arg3),
            (arg4Name, arg4),
            (arg5Name, arg5),
            (arg6Name, arg6),
            (arg7Name, arg7));
        return HandleDefaultArgs(nullArgs, throws);
    }

    public static string? AgainstDefaults(
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
        var nullArgs = GetDefaultArgsParamNames(
            (arg1Name, arg1),
            (arg2Name, arg2),
            (arg3Name, arg3),
            (arg4Name, arg4),
            (arg5Name, arg5),
            (arg6Name, arg6),
            (arg7Name, arg7),
            (arg8Name, arg8));
        return HandleDefaultArgs(nullArgs, throws);
    }

    public static string? AgainstDefaults(
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
        var nullArgs = GetDefaultArgsParamNames(
            (arg1Name, arg1),
            (arg2Name, arg2),
            (arg3Name, arg3),
            (arg4Name, arg4),
            (arg5Name, arg5),
            (arg6Name, arg6),
            (arg7Name, arg7),
            (arg8Name, arg8),
            (arg9Name, arg9));
        return HandleDefaultArgs(nullArgs, throws);
    }

    public static string? AgainstDefaults(
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
        var nullArgs = GetDefaultArgsParamNames(
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
        return HandleDefaultArgs(nullArgs, throws);
    }

    private static List<string> GetDefaultArgsParamNames(params (string paramName, object? value)[] args)
    {
        var defaultArgsParamNames = new List<string>();

        foreach (var (paramName, value) in args)
        {
            switch (value)
            {
                case null:
                    // Reference types: default is null.
                    defaultArgsParamNames.Add(paramName);
                    break;
                case int i when i == default:
                    defaultArgsParamNames.Add(paramName);
                    break;
                case long l when l == default:
                    defaultArgsParamNames.Add(paramName);
                    break;
                case float f when f == default:
                    defaultArgsParamNames.Add(paramName);
                    break;
                case double d when d == default:
                    defaultArgsParamNames.Add(paramName);
                    break;
                case decimal m when m == default:
                    defaultArgsParamNames.Add(paramName);
                    break;
                case bool b when b == default:
                    defaultArgsParamNames.Add(paramName);
                    break;
                case char c when c == default:
                    defaultArgsParamNames.Add(paramName);
                    break;
                case string s when s == default:
                    defaultArgsParamNames.Add(paramName);
                    break;
                case DateTime dt when dt == default:
                    defaultArgsParamNames.Add(paramName);
                    break;
                case DateTimeOffset dto when dto == default:
                    defaultArgsParamNames.Add(paramName);
                    break;
                case Guid g when g == default:
                    defaultArgsParamNames.Add(paramName);
                    break;
                case Enum e when e == default:
                    defaultArgsParamNames.Add(paramName);
                    break;
                default:
                    // For any other value types, use reflection to determine the default value.
                    if (value != null && value.GetType().IsValueType)
                    {
                        var defaultValue = Activator.CreateInstance(value.GetType());
                        if (value.Equals(defaultValue))
                        {
                            defaultArgsParamNames.Add(paramName);
                        }
                    }

                    break;
            }
        }

        return defaultArgsParamNames;
    }

    private static string? HandleDefaultArgs(List<string> args, bool throws) =>
        HandleArgs(args, "Args cannot be defaults", throws);
}