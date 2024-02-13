# MasterCommander

Write code, not commands. MasterCommander provides a simple, consistent interface for common development tasks.

| ![Logo MasterCommander](https://raw.githubusercontent.com/phmatray/MasterCommander/main/logo.png) | MasterCommander is a versatile command-line utility designed to streamline the workflow for developers working with multiple technology stacks. By integrating common operations for Git, .NET, Docker, and npm into a single application, MasterCommander enhances productivity and simplifies project setup and management tasks. |
|---------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|

[![phmatray - MasterCommander](https://img.shields.io/static/v1?label=phmatray&message=MasterCommander&color=blue&logo=github)](https://github.com/phmatray/MasterCommander "Go to GitHub repo")
[![License: GPL-3.0-or-later](https://img.shields.io/badge/License-GPLv3.0--or--later-blue.svg)](https://www.gnu.org/licenses/gpl-3.0.html)
[![stars - MasterCommander](https://img.shields.io/github/stars/phmatray/MasterCommander?style=social)](https://github.com/phmatray/MasterCommander)
[![forks - MasterCommander](https://img.shields.io/github/forks/phmatray/MasterCommander?style=social)](https://github.com/phmatray/MasterCommander)

[![GitHub tag](https://img.shields.io/github/tag/phmatray/MasterCommander?include_prereleases=&sort=semver&color=blue)](https://github.com/phmatray/MasterCommander/releases/)
[![issues - MasterCommander](https://img.shields.io/github/issues/phmatray/MasterCommander)](https://github.com/phmatray/MasterCommander/issues)
[![GitHub pull requests](https://img.shields.io/github/issues-pr/phmatray/MasterCommander)](https://github.com/phmatray/MasterCommander/pulls)
[![GitHub contributors](https://img.shields.io/github/contributors/phmatray/MasterCommander)](https://github.com/phmatray/MasterCommander/graphs/contributors)
[![GitHub last commit](https://img.shields.io/github/last-commit/phmatray/MasterCommander)](https://github.com/phmatray/MasterCommander/commits/master)

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/bdd7b46c04534d8e958fda9dce1b0366)](https://app.codacy.com/gh/phmatray/MasterCommander/dashboard)
[![codecov](https://codecov.io/gh/phmatray/MasterCommander/branch/main/graph/badge.svg?token=041C4QKW6O)](https://app.codecov.io/gh/phmatray/MasterCommander/tree/main)

---

## 📝 Table of Contents

<!-- TOC -->
* [MasterCommander](#mastercommander)
  * [📝 Table of Contents](#-table-of-contents)
  * [🏁 Getting started](#-getting-started)
  * [📄 Documentation](#-documentation)
  * [📌 Features](#-features)
    * [Current Features](#current-features)
    * [Roadmap (next features)](#roadmap-next-features)
  * [📥 Installation](#-installation)
    * [📋 Prerequisites](#-prerequisites)
      * [We use the latest C# features](#we-use-the-latest-c-features)
    * [🚀 From Source](#-from-source)
    * [📦 NuGet Packages](#-nuget-packages)
  * [📊 Code Quality](#-code-quality)
    * [🧪 Tests Specifications](#-tests-specifications)
  * [🤝 Contributing](#-contributing)
    * [How to contribute?](#how-to-contribute)
    * [Contributors](#contributors)
  * [❓ Issues and Feature Requests](#-issues-and-feature-requests)
  * [✉️ Contact](#-contact)
  * [📜 License](#-license)
<!-- TOC -->

---

## 🏁 Getting started

Use your favorite CLI tools without leaving your code editor:

This example demonstrates how to use MasterCommander to create a new .NET solution and project, initialize a Git
repository, and build and run the project.
In addition, this code adds a .gitignore file, an .editorconfig file, and a global.json file to the project.

```csharp
private const string SdkVersion = "8.0.101";
private const string SolutionName = "AppDemo";
private const string ConsoleProjectName = $"{SolutionName}.Console";
private const string ConsoleProjectDirectory = $"src/{ConsoleProjectName}";
private const string ConsoleCsproj = $"{ConsoleProjectDirectory}/{ConsoleProjectName}.csproj";

await git.InitAsync();
await git.StatusAsync();
await dotnet.NewAsync(new DotnetNewGitignoreOptions());
await dotnet.NewAsync(new DotnetNewEditorConfigOptions());
await dotnet.NewAsync(new DotnetNewNuGetConfigOptions());
await dotnet.NewAsync(new DotnetNewGlobalJsonOptions { SdkVersion = SdkVersion });
await dotnet.NewAsync(new DotnetNewSolutionOptions { OutputName = SolutionName });
await dotnet.NewAsync(new DotnetNewConsoleOptions { OutputName = ConsoleProjectName, OutputDirectory = ConsoleProjectDirectory });
await dotnet.SlnAddAsync(ConsoleCsproj);
await dotnet.BuildAsync();
await dotnet.BuildAsync(new DotnetBuildOptions { Configuration = "Release" });
await dotnet.RunAsync(new DotnetRunOptions { Project = ConsoleCsproj, Configuration = "Release" });
```

You can standardize your development workflow by using MasterCommander to perform common tasks across multiple projects
and technology stacks.

Output from MasterCommander commands is displayed in a clean, readable format:
> ![MasterCommander Screenshot](https://raw.githubusercontent.com/phmatray/MasterCommander/main/assets/img/output-spectre.png)

## 📄 Documentation

**MasterCommander** provides
a [COMPLETE DOCUMENTATION](https://github.com/phmatray/MasterCommander/blob/main/docs/README.md) of the library.

All summaries are written in English. If you want to help us translate the documentation, please open an issue to
discuss it.
> **Note:** The documentation is generated using [Doraku/DefaultDocumentation]() tool. It is generated automatically
> when the project is built.

## 📌 Features

### Current Features

* [x] **Unified Interface**: MasterCommander provides a single interface for interacting with multiple development
  tools.
* [x] **Simple Commands**: Execute common development tasks with simple, intuitive commands.
* [x] **Cross-Platform**: MasterCommander is designed to work on Windows, macOS, and Linux.
* [x] **Customizable**: Add new commands and features to MasterCommander to suit your workflow.

### Roadmap (next features)

* [ ] **WIP =>** **.NET Projects**: Easily create new .NET solutions and projects.
* [ ] **WIP =>** **Git Integration**: Initialize new repositories, check status, and more with built-in Git commands.
* [ ] **WIP =>** **Docker Support**: Manage Docker containers and images through simple commands.
* [ ] **WIP =>** **npm Packages**: Handle npm packages and run npm scripts within your projects.
* [ ] Comprehensive API documentation that is easy to understand
* [ ] High-Level API for common use cases
* [ ] More tests
* [ ] More examples
* [ ] More features

## 📥 Installation

### 📋 Prerequisites

To use MasterCommander, ensure you have the following installed on your system:

* Git
* .NET 8.0 (supported versions: 8.0.101 or later)
* A C# IDE (Visual Studio, JetBrains Rider, etc.)
* A C# compiler (dotnet CLI, etc.)
* Docker (optional)
* Node.js and npm (optional)

#### We use the latest C# features

This library targets .NET 8.0 and uses the latest C# features. It is written in C# 12.0 and uses the new `init`
properties, `record` types, `switch` expressions, `using` declarations and more.

I invite you to read the [C# 12.0 documentation](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12) to
learn more about these features.

### 🚀 From Source

You can also build MasterCommander from source. Follow these steps to get started:

1. Clone the repository to your local machine.
2. Navigate to the cloned directory and build the project using the .NET CLI: `dotnet build`.
3. Run the application with `dotnet run` from within the source directory.
4. Or... open the project in Visual Studio (or JetBrains Rider) and run the application from the IDE.

### 📦 NuGet Packages

To install MasterCommander, you can use the NuGet package manager. Run the following command in your terminal:

```shell
dotnet add package MasterCommander
```

| Package Name    | NuGet Version Badge                                                                                            | NuGet Downloads Badge                                                                                           | Package Explorer                                       |
|-----------------|----------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------|--------------------------------------------------------|
| MasterCommander | [![NuGet](https://img.shields.io/nuget/v/MasterCommander.svg)](https://www.nuget.org/packages/MasterCommander) | [![NuGet](https://img.shields.io/nuget/dt/MasterCommander.svg)](https://www.nuget.org/packages/MasterCommander) | [Explore](https://nuget.info/packages/MasterCommander) |

This table is automatically updated regularly the latest developments and releases.

## 📊 Code Quality

We strive for the highest code quality in MasterCommander. To ensure this, we use the following tools:

* StyleCop
* .editorconfig

### 🧪 Tests Specifications

We use xUnit and FluentAssertions to write and run tests for MasterCommander. This ensures that the library is reliable
and performs as expected.

## 🤝 Contributing

### How to contribute?

Contributions to MasterCommander are welcome! Whether it's reporting bugs, discussing improvements, or submitting pull
requests, all contributions help make MasterCommander a better tool for developers.

Before submitting pull requests, please ensure you have discussed the proposed changes with the project maintainers.

A great way to contribute to MasterCommander is to add new commands. If you have a command you'd like to see added to
MasterCommander, please open an issue to discuss it.

### Contributors

[![Contributors](https://contrib.rocks/image?repo=phmatray/MasterCommander)](http://contrib.rocks)

## ❓ Issues and Feature Requests

For reporting bugs or suggesting new features, kindly submit these as an issue to
the [MasterCommander Repository](https://github.com/phmatray/MasterCommander/issues). We value your contributions, but
before submitting an issue, please ensure it is not a duplicate of an existing one.

## ✉️ Contact

You can contact us by opening an issue on this repository.

## 📜 License

GNU General Public License v3.0 or later.
