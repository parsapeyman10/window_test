# Window Test

A polished Windows 10 desktop assessment application built with C# and WPF on .NET 8. It follows a modern, strategy-aware design inspired by the structure and patterns used in the `ichimoko` repository: clean separation between models, view models, services, and UI flow.

## Stack

- C#
- .NET 8
- WPF
- XAML
- MVVM-style ViewModel

## Features

- Multiple-choice quiz flow
- Strategy selector with several profiles
- Real-time score tracking
- Completion summary with percentage result
- Responsive, modern Windows desktop UI
- Clean architecture for future extension

## Run on Windows

1. Install Visual Studio 2022 with the .NET desktop development workload.
2. Open `WindowTest.sln`.
3. Restore NuGet packages.
4. Press `F5` to run.

## Project structure

- `WindowTest.sln` — solution file
- `WindowTest/WindowTest.csproj` — project configuration
- `WindowTest/App.xaml` — app bootstrap
- `WindowTest/MainWindow.xaml` — UI shell
- `WindowTest/MainWindow.xaml.cs` — window logic
- `WindowTest/ViewModels/QuizViewModel.cs` — state and behavior
- `WindowTest/Models/` — domain models
- `WindowTest/Services/` — test catalog and strategy rules

## Notes

This version is designed as a final, production-style starter for a Windows 10 testing application and is ready to be expanded with:

- custom question sets
- persistence to JSON/SQLite
- admin panel
- result export
- login and user management
- company branding and theming
