// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core.Exceptions;

/// <summary>
/// Represents an exception that occurs when a CLI operation is canceled.
/// </summary>
public class CliOperationCanceledException : OperationCanceledException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CliOperationCanceledException"/> class.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    public CliOperationCanceledException(string message)
        : base(message)
    {
    }

    internal CliOperationCanceledException()
    {
    }

    internal CliOperationCanceledException(string? message, Exception? innerException)
        : base(message, innerException)
    {
    }

    internal CliOperationCanceledException(string? message, Exception? innerException, CancellationToken token)
        : base(message, innerException, token)
    {
    }

    internal CliOperationCanceledException(string? message, CancellationToken token)
        : base(message, token)
    {
    }

    internal CliOperationCanceledException(CancellationToken token)
        : base(token)
    {
    }
}
