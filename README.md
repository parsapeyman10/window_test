# Window Test

This repository contains a Windows 10 desktop test-taking app inspired by the architecture and data model patterns in the `ichimoko` repository, especially:

- `Candle`-style time-series data modeling
- `SignalAction`-style evaluation results
- `AppSettings` and `BaseStrategyConfig` for configurable behavior
- `BitcoinStrategyModel`-style strategy metadata and playbooks

The app is a simple, polished Windows desktop test app with:

- multiple-choice questions
- configurable exam strategy profile
- result summary with score and confidence
- WPF UI optimized for Windows 10

## Run on Windows

1. Open the solution in Visual Studio 2022.
2. Restore NuGet packages.
3. Set `WindowTest` as the startup project.
4. Press `F5` to run.

## Project structure

- `WindowTest/` — WPF application
- `WindowTest/Models/` — domain models and strategy metadata
- `WindowTest/Services/` — catalog and evaluation logic

## Notes

This is a clean starter implementation that follows the same separation-of-concerns patterns as `ichimoko` while staying focused on a Windows test app.
