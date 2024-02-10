// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core.Exceptions;

/// <summary>
/// Represents an exception for general CLI operation failures, including an inner exception that represents the cause of the current exception.
/// </summary>
public class CliOperationException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CliOperationException"/> class.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    public CliOperationException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    internal CliOperationException()
    {
    }

    internal CliOperationException(string? message)
        : base(message)
    {
    }
}
