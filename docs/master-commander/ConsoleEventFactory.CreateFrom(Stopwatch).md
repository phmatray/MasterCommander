#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander.Core.Display](MasterCommander.Core.Display.md 'MasterCommander.Core.Display').[ConsoleEventFactory](ConsoleEventFactory.md 'MasterCommander.Core.Display.ConsoleEventFactory')

## ConsoleEventFactory.CreateFrom(Stopwatch) Method

Creates a console event based on the elapsed time from a stopwatch.

```csharp
public static MasterCommander.Core.ConsoleEvents.ConsoleEvent CreateFrom(System.Diagnostics.Stopwatch stopWatch);
```
#### Parameters

<a name='MasterCommander.Core.Display.ConsoleEventFactory.CreateFrom(System.Diagnostics.Stopwatch).stopWatch'></a>

`stopWatch` [System.Diagnostics.Stopwatch](https://docs.microsoft.com/en-us/dotnet/api/System.Diagnostics.Stopwatch 'System.Diagnostics.Stopwatch')

The stopwatch used to measure the elapsed time.

#### Returns
[ConsoleEvent](ConsoleEvent.md 'MasterCommander.Core.ConsoleEvents.ConsoleEvent')  
A console event representing the execution time.