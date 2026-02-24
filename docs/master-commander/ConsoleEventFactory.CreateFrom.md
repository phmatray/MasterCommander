#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Core\.Display](MasterCommander.md#MasterCommander.Core.Display 'MasterCommander\.Core\.Display').[ConsoleEventFactory](ConsoleEventFactory.md 'MasterCommander\.Core\.Display\.ConsoleEventFactory')

## ConsoleEventFactory\.CreateFrom Method

| Overloads | |
| :--- | :--- |
| [CreateFrom\(CommandEvent\)](ConsoleEventFactory.CreateFrom.md#MasterCommander.Core.Display.ConsoleEventFactory.CreateFrom(CliWrap.EventStream.CommandEvent) 'MasterCommander\.Core\.Display\.ConsoleEventFactory\.CreateFrom\(CliWrap\.EventStream\.CommandEvent\)') | Creates a specific type of console event based on the given command event\. |
| [CreateFrom\(Stopwatch\)](ConsoleEventFactory.CreateFrom.md#MasterCommander.Core.Display.ConsoleEventFactory.CreateFrom(System.Diagnostics.Stopwatch) 'MasterCommander\.Core\.Display\.ConsoleEventFactory\.CreateFrom\(System\.Diagnostics\.Stopwatch\)') | Creates a console event based on the elapsed time from a stopwatch\. |

<a name='MasterCommander.Core.Display.ConsoleEventFactory.CreateFrom(CliWrap.EventStream.CommandEvent)'></a>

## ConsoleEventFactory\.CreateFrom\(CommandEvent\) Method

Creates a specific type of console event based on the given command event\.

```csharp
public static MasterCommander.Core.ConsoleEvents.ConsoleEvent CreateFrom(CliWrap.EventStream.CommandEvent cmdEvent);
```
#### Parameters

<a name='MasterCommander.Core.Display.ConsoleEventFactory.CreateFrom(CliWrap.EventStream.CommandEvent).cmdEvent'></a>

`cmdEvent` [CliWrap\.EventStream\.CommandEvent](https://learn.microsoft.com/en-us/dotnet/api/cliwrap.eventstream.commandevent 'CliWrap\.EventStream\.CommandEvent')

The command event to create a console event from\.

#### Returns
[ConsoleEvent](ConsoleEvent.md 'MasterCommander\.Core\.ConsoleEvents\.ConsoleEvent')  
A console event corresponding to the specified command event\.

#### Exceptions

[System\.ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception 'System\.ArgumentException')  
Thrown when an unknown command event type is provided\.

<a name='MasterCommander.Core.Display.ConsoleEventFactory.CreateFrom(System.Diagnostics.Stopwatch)'></a>

## ConsoleEventFactory\.CreateFrom\(Stopwatch\) Method

Creates a console event based on the elapsed time from a stopwatch\.

```csharp
public static MasterCommander.Core.ConsoleEvents.ConsoleEvent CreateFrom(System.Diagnostics.Stopwatch stopWatch);
```
#### Parameters

<a name='MasterCommander.Core.Display.ConsoleEventFactory.CreateFrom(System.Diagnostics.Stopwatch).stopWatch'></a>

`stopWatch` [System\.Diagnostics\.Stopwatch](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch 'System\.Diagnostics\.Stopwatch')

The stopwatch used to measure the elapsed time\.

#### Returns
[ConsoleEvent](ConsoleEvent.md 'MasterCommander\.Core\.ConsoleEvents\.ConsoleEvent')  
A console event representing the execution time\.