// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core.Exceptions;

/// <summary>
/// Represents an exception related to CLI command execution failures, including the associated exit code.
/// </summary>
/// <param name="message">The error message that explains the reason for the exception.</param>
/// <param name="exitCode">The exit code returned by the CLI command.</param>
public class CliCommandException(string message, int exitCode)
    : Exception(message)
{
    /// <summary>
    /// Gets the exit code associated with the CLI command failure.
    /// </summary>
    public int ExitCode { get; } = exitCode;
}
