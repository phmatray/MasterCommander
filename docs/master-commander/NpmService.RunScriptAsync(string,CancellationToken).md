#### [MasterCommander](MasterCommander.md 'MasterCommander')
### [MasterCommander\.Commanders\.Npm](MasterCommander.md#MasterCommander.Commanders.Npm 'MasterCommander\.Commanders\.Npm').[NpmService](NpmService.md 'MasterCommander\.Commanders\.Npm\.NpmService')

## NpmService\.RunScriptAsync\(string, CancellationToken\) Method

Runs a specified script defined in the project's package\.json file asynchronously\.

```csharp
public System.Threading.Tasks.Task RunScriptAsync(string scriptName, System.Threading.CancellationToken ct=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='MasterCommander.Commanders.Npm.NpmService.RunScriptAsync(string,System.Threading.CancellationToken).scriptName'></a>

`scriptName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the script to run\.

<a name='MasterCommander.Commanders.Npm.NpmService.RunScriptAsync(string,System.Threading.CancellationToken).ct'></a>

`ct` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

Optional cancellation token to cancel the operation\.

Implements [RunScriptAsync\(string, CancellationToken\)](INpmService.RunScriptAsync(string,CancellationToken).md 'MasterCommander\.Commanders\.Npm\.INpmService\.RunScriptAsync\(string, System\.Threading\.CancellationToken\)')

#### Returns
[System\.Threading\.Tasks\.Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task 'System\.Threading\.Tasks\.Task')  
A task representing the asynchronous operation of running the specified npm script\.