Forutsetninger
=======

[.NET Core SDK](https://www.microsoft.com/net/core).

Hvis du vil bruke Visual Studio må du ha VS2015 Update 2 + .NET Core SDK.
Workshopen er laget for Windows, men hvis du vil gjøre den på Linux, OS X eller i Docker skal det gå helt fint.


# Del 1 - donet klienten
## 1a - Core App
* Gå inn i mappen 1a og lag en ny .NET-applikasjon med `dotnet new`
* Last ned dependencies fra nuget med `dotnet restore`
* Kjør programmet med `dotnet run`
* Publisér løsnigen med `dotnet publish -o .corepublish`. Dette publiserer appen til mappa `.publish`. Ta en titt på de forskjellige filene som havner der.
* Kjør den publiserte dll'en med `dotnet run .publish/1a.dll'


## 1b .NET Framework App
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