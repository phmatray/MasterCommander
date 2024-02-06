// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core.Exceptions;

/// <summary>
/// Represents an exception that occurs when the home directory cannot be determined.
/// </summary>
public class HomeDirectoryNotFoundException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HomeDirectoryNotFoundException"/> class with a default error message.
    /// </summary>
    public HomeDirectoryNotFoundException()
        : base("Could not find the home directory. Ensure that environment variables for the home directory are properly set.")
    {
    }

    internal HomeDirectoryNotFoundException(string? message)
        : base(message)
    {
    }

    internal HomeDirectoryNotFoundException(string? message, Exception? innerException)
        : base(message, innerException)
    {
    }
}
