// Copyright (c) 2020-2024 Atypical Consulting SRL. All rights reserved.
// Atypical Consulting SRL licenses this file to you under the GPL-3.0-or-later license.
// See the LICENSE file in the project root for full license information.

using System.Diagnostics;

namespace MasterCommander.Integrations.Processes;

/// <summary>
/// Provides a base class for handling the output of executed commands, displaying results and events to a console interface.
/// </summary>
/// <param name="console">The console interface where command output and events are written.</param>
public abstract class CommandOutputHandler(IConsole console)
{
    /// <summary>
    /// Listens for and processes command execution events asynchronously, writing output and events to the console.
    /// </summary>
    /// <param name="command">The command whose output is to be handled.</param>
    /// <param name="ct">A cancellation token that can be used to cancel the listening operation.</param>
    /// <returns>A task representing the asynchronous operation of listening to and handling command output and events.</returns>
    private protected async Task ListenCommandAsync(Command command, CancellationToken ct)
    {
        console.WriteCommand(command.ToString());
        var stopWatch = Stopwatch.StartNew();

        await foreach (var commandEvent in command.ListenAsync(ct))
        {
            console.WriteConsoleEvent(ConsoleEventFactory.CreateFrom(commandEvent));
        }

        stopWatch.Stop();
        console.WriteConsoleEvent(ConsoleEventFactory.CreateFrom(stopWatch));
    }
}
