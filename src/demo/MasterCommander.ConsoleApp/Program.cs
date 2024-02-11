// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

using MasterCommander;
using MasterCommander.Core.Services;
using Microsoft.Extensions.DependencyInjection;

// create a new .NET solution and console application
await MainExtensions
    .CreateMasterCommanderServices()
    .BuildServiceProvider()
    .GetRequiredService<IProjectInitializationService>()
    .InitializeConsoleProjectAsync();
