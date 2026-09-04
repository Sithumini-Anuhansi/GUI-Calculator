# GUI Calculator

A simple desktop calculator built with C# and Windows Forms (.NET 8).

## Features

* Basic arithmetic: addition, subtraction, multiplication, division
* Clear/reset button
* Simple, clean Windows Forms interface

## Tech Stack

* **Language:** C#
* **Framework:** .NET 8 (Windows Forms)
* **IDE:** Visual Studio 2022

## Project Structure

```
Calculator/
├── Calculator.sln              # Visual Studio solution file
└── Calculator/
    ├── Calculator.csproj       # Project file
    ├── Program.cs              # Application entry point
    ├── Form1.cs                # Calculator logic (button handlers, arithmetic)
    ├── Form1.Designer.cs       # Auto-generated UI layout code
    └── Form1.resx              # Form resources
```

## Getting Started

### Prerequisites

* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
* Windows (Windows Forms apps run on Windows)
* Visual Studio 2022 (recommended) or VS Code with the C# extension

### Run it

**Using Visual Studio:**

1. Open `Calculator.sln`
2. Press `F5` to build and run

**Using the .NET CLI:**

```bash
cd Calculator
dotnet run
```

### Build a release version

```bash
cd Calculator
dotnet build -c Release
```

## How It Works

The calculator captures digit input into a running string, stores the first operand and chosen operator when an operator button is pressed, then computes the result on `=` using `double.TryParse` and a `switch` on the operator. `Clear` resets all stored state.

## License

MIT (or update this section with your preferred license)

