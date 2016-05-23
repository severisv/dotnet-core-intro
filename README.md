into:
1:
-dotnet cli
-dotnet core vs .net framework

2:
-visual studio, xproj filer
-visual studio : dotnet run, dotnet restore skjer automatisk
-kestrel, iis osv





Forutsetninger
=======

[.NET Core SDK](https://www.microsoft.com/net/core).

Hvis du vil bruke Visual Studio må du ha VS2015 Update 2 + .NET Core SDK.
Workshopen er laget for Windows, men hvis du vil gjøre den på Linux, OS X eller i Docker skal det gå helt fint.


## Del 1 - donet klienten
Til disse oppgavene anbefales det å bruke en lettvekts-editor som feks Atmo, Visual Studio Code, e.l.

### 1a - Core App
**Bruk kommandolinjeverktøyet `dotnet` til å lage en ny console-applikasjon og kjør denne. Publiser den og kjør den publiserte DLL'en.**
* Gå inn i mappen 1a og lag en ny .NET-applikasjon med `dotnet new`
* Last ned dependencies fra nuget med `dotnet restore`
* Kjør programmet med `dotnet run`
* Publisér løsnigen med `dotnet publish -o .corepublish`. Dette publiserer appen til mappa `.publish`. Ta en titt på de forskjellige filene som havner der.
* Kjør den publiserte dll'en med `dotnet run .publish/1a.dll'


### 1b .NET Framework App
**Bruk `dotnet` til å lage en ny console-applikasjon. Gjør om denne til en .NET Framework-basert applikasjon. Publiser den, finn den resulterende .exe-fila og kjør den.**
* Gå inn i mappen 1b og lag en ny .NET-applikasjon med `dotnet new`
* Legg til `Console.Read();` i Program.cs
* Gjør om prosjektet slik at det kompilerer til en .NET Framework-modell i stedet. Dette kan gjøres ved å bytte ut `"netcoreapp1.0": {
      "imports": "dnxcore50"
    }` med
    `"net461": {
      "imports": "dnxcore50"
    }`
    i project.json.
    I tillegg må vi fjerne avhengigheten `"Microsoft.NETCore.App"` ettersom denne ikke er nødvendig/kompatibel med en .NET Framework-modell.
* Publiser applikasjonen i en mappe du velger selv
* Gå inn mappa og finn 1b.exe - kjør denne

### 1c Testprosjekt
**Lag et tesprosjekt. Bruk et testrammeverk, feks xUnit, til å lage en test. Kjør testen med `dotnet`**
* Gå inn i mappen 1c og opprett et nytt prosjekt med `dotnet new`
* Slett Program.cs og fjern "emitEntryPoint" fra project.json
* Legg til xUnit og xUnit Testrunner som dependencies/testrunner, i tillegg til "portable-net45+win8" under imports (xUnit krever dette) - [slik](https://github.com/severisv/dotnet-core-intro/blob/master/1c/project.json)
* Lag en ny klasse som heter HelloWorld.cs og inneholder en metode `Get()` som returnerer "Hello World!"
* Lag en testklasse som heter HelloWorldTests og importer xUnit `using Xunit;`
* Lag en testmetode som tester HelloWorld.cs og annoter denne med `[Fact]`
* Restore nuget-pakker
* Kjør testen med `dotnet test`


## Web app
Til disse oppgavene er det lettest å bruke Visual Studio

### 2a
**Bruk Kestrel til å lage en web app som svarer med "Hello World!"**
* Åpne Visual Studio og velg new -> project. Velg Console Application og legg det i mappa 2.
* Legg til Kestrel som en dependency i `project.json`