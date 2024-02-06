// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

namespace MasterCommander.Core.Exceptions;

/// <summary>
/// Represents an exception that occurs when a CLI operation is canceled.
/// </summary>
/// <param name="message">The error message that explains the reason for the exception.</param>
public class CliOperationCanceledException(string message)
    : OperationCanceledException(message);
