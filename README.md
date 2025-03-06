# Guarded

> This library provides a convenient way to perform some checks, called "guards" in your code and throw exceptions (or return an error message) if the checks fail. 


> ### <pre> NuGet: https://www.nuget.org/packages/Guarded

<br/>

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Examples](#examples)
- [Contributing](#contributing)
- [License](#license)

---

## Overview

When writing robust C# applications, checking input parameters is a common task. This is also sometimes neccessary even when nullable reference types are enabled in your csproj file, as this annotation produces compile-time errors and not runtime errors. <br />

**Guarded** provides a simple, centralized way to handle those checks—sometimes referred to as guard clauses. Instead of sprinkling `if` statements throughout your methods, you can invoke a single guard method to throw an exception (or return an error message) when inputs aren’t valid.

> ### Guards:
> * Null
> * Empty or WhiteSpace
> * Defaults

## Features

- **Guard.AgainstDefaults**: Throws if a value is the default of its type.
- **Guard.AgainstNulls**: Throws if an object is `null`.
- **Guard.AgainstNullsAndEmpties**: Throws if an object is `null` or if a string is `null` or empty.
- **GuardAgainstNullsAndWhitespaces**: Throws if an object is `null` or if a string is `null`, empty, or consists of only whitespace.
- **Guard.Against**: An alternative way of invoking guard methods.

## Examples

Below are some typical examples of how you might use the guard methods:

``` csharp
using Guarded.Guards;

public class User
{
    public User(string firstname, string lastname, Address address, int age, DateTime birthdate)
    {
        Guard.AgainstNullsAndWhitespaces(firstname, lastname, address);

        Guard.AgainstDefaults(age, birthdate);

        // Continue with your code
    }
}
```

---

## Contributing

Contributions are welcome! If you’d like to contribute:

1. **Fork** the repository.
2. **Create a new branch** for your feature or bug fix.
3. **Make your changes** with clear, descriptive commits.
4. **Submit a pull request** describing your changes in detail.

---

## License

This project is licensed under the [MIT License](LICENSE). Feel free to use it in personal or commercial projects.

---

**Happy coding!** If you have any questions, suggestions, or issues, please open an [issue](../../issues) or submit a [pull request](../../pulls).

