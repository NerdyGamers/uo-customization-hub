# AGENTS Instructions

These guidelines apply to the entire repository.

## Code Style
- Target .NET 8 and follow existing C# conventions.
- Use four spaces for indentation.
- Use braces on new lines for namespaces, types, and members.
- Name public types and members with PascalCase.
- Name local variables with camelCase; prefix private fields with an underscore.

## Commit Guidelines
- Use conventional commit messages such as `feat:`, `fix:`, `docs:`, or `chore:`.
- Keep messages concise and in the imperative mood.
- Update `changelog.md` with a brief summary of changes starting at 1.0.0 incrementally as you add them 

## Project Structure
- Main application: `src/CustomizationHub.App` (Windows Forms).
- Core library: `src/UltimaSDK`.
- Solution file: `UOCustomizationHub.sln`.
- Art asset tool: `src/ArtAssetStudio`.

