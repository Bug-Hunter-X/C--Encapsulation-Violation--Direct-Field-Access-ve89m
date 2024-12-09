# C# Encapsulation Violation: Direct Field Access

This repository demonstrates a common C# coding error: directly accessing a private field instead of using its associated property.  This violates the principle of encapsulation, potentially leading to unexpected behavior and making code harder to maintain and debug.

**The Problem:**

Directly accessing the `_myField` violates encapsulation.  Changes to how `_myField` is managed (e.g., adding validation or logic in the setter) won't be reflected in code that accesses the field directly.

**The Solution:**

Always access class fields through their public properties.  This maintains encapsulation, improving code reliability and maintainability.

**How to Use:**

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Run the `bug.cs` file to see the encapsulation violation in action.
4. Compare it to the corrected code in `bugSolution.cs` to see the solution and its best practices.
