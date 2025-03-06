using Guarded.Guards;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Guarded.UnitTests.GuardAgainstNulls;

[TestClass]
public class GuardAgainstNulls_With7Parameters_Tests
{
    // This method generates all 128 combinations for 7 inputs.
    // Because 7 input values yield 2⁷ = 128 possible combinations,
    // it’s impractical to list 128 individual [DataRow] attributes manually.
    // Instead, these will be generated dynamically

    // For each input position i:
    //   - If the input is provided (non-null), its fallback "argi" is appended to fallback2.
    //   - If the input is missing (null), its fallback "argi" is appended to fallback1.
    public static IEnumerable<object[]> GetTestData()
    {
        // Provided values for each input.
        string[] providedValues = { "value1", "value2", "value3", "value4", "value5", "value6", "value7" };
        // Corresponding fallback arguments.
        string[] fallbackArgs = { Guard.Arg1Name, Guard.Arg2Name, Guard.Arg3Name, Guard.Arg4Name, Guard.Arg5Name, Guard.Arg6Name, Guard.Arg7Name };

        // Total combinations: 2^7 = 128.
        var total = 1 << 7;
        for (var mask = 0; mask < total; mask++)
        {
            // Arrays to hold inputs and lists for contains and notContains.
            var inputs = new string[7];
            var containsList = new List<string>();
            var notContainsList = new List<string>();

            // Check each bit of the mask to decide if the corresponding input is provided.
            for (var i = 0; i < 7; i++)
            {
                var provided = (mask & (1 << i)) != 0;
                if (provided)
                {
                    inputs[i] = providedValues[i];
                    notContainsList.Add(fallbackArgs[i]);
                }
                else
                {
                    inputs[i] = null;
                    containsList.Add(fallbackArgs[i]);
                }
            }

            var contains = string.Join(", ", containsList);
            var notContains = string.Join(", ", notContainsList);

            yield return new object[]
            {
                inputs[0], inputs[1], inputs[2],
                inputs[3], inputs[4], inputs[5],
                inputs[6],
                contains,
                notContains
            };
        }
    }

    [DataTestMethod]
    [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
    public void AgainstNulls_With7Parameters_AllPossibleNullablePaths(object? arg1, object? arg2, object? arg3, object? arg4, object? arg5, object? arg6, object? arg7, string contains, string notContains, bool throws = true)
    {
        var containsList = contains.Split([", "], StringSplitOptions.RemoveEmptyEntries);
        var notContainsList = notContains.Split([", "], StringSplitOptions.RemoveEmptyEntries);

        void act() => Guard.AgainstNulls(arg1, arg2, arg3, arg4, arg5, arg6, arg7, throws: true);
        GuardAgainstNullsConstants.TestWithPossibleException(act, containsList, notContainsList);

        var result = Guard.AgainstNulls(arg1, arg2, arg3, arg4, arg5, arg6, arg7, throws: false);
        GuardAgainstNullsConstants.TestWithPossibleErrorMessage(result, containsList, notContainsList);
    }
}