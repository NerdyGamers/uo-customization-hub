# AGENTS Instructions

These guidelines apply to the entire repository.

## Code Style
- Target .NET 8 and follow existing C# conventions.
- Use four spaces for indentation.
- Use braces on new lines for namespaces, types, and members.
- Name public types and members with PascalCase.
- Name local variables with camelCase; prefix private fields with an underscore.

## Build, Format, and Test
- Run `dotnet format` to automatically format C# code.
- Build the solution with `dotnet build UOCustomizationHub.sln`.
- Run `dotnet test` when test projects exist; there are currently no tests.
- When changes affect only documentation or comments, tests and formatting aren't required.

## Commit Guidelines
- Use conventional commit messages such as `feat:`, `fix:`, `docs:`, or `chore:`.
- Keep messages concise and in the imperative mood.

## Project Structure
- Main application: `src/CustomizationHub.App` (Windows Forms).
- Core library: `src/UltimaSDK`.
- Solution file: `UOCustomizationHub.sln`.

