
# Getting Started with Petstore & Books API

## Introduction

The Books API provides information about book reviews and The New York Times Best Sellers lists.

### Best Sellers Lists Services

#### List Names

The lists/names service returns a list of all the NYT Best Sellers Lists.  Some lists are published weekly and others monthly.  The response includes when each list was first published and last published.

```
/lists/names.json
```

#### List Data

The lists/{date}/{name} service returns the books on the best sellers list for the specified date and list name.

```
/lists/2019-01-20/hardcover-fiction.json
```

Use "current" for {date} to get the latest list.

```
/lists/current/hardcover-fiction.json
```

### Book Reviews Services

The book reviews service lets you get NYT book review by author, ISBN, or title.

```
/reviews.json?author=Michelle+Obama
```

```
/reviews.json?isbn=9781524763138
```

```
/reviews.json?title=Becoming
```

### Example Calls

```
https://api.nytimes.com/svc/books/v3/lists/current/hardcover-fiction.json?api-key=yourkey
```

```
https://api.nytimes.com/svc/books/v3/reviews.json?author=Stephen+King&api-key=yourkey
```

Find out more about Swagger: [http://swagger.io](http://swagger.io)

## Building

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore is enabled, these dependencies will be installed automatically. Therefore, you will need internet access for build.

* Open the solution (PetstoreBooksAPI.sln) file.

Invoke the build process using Ctrl + Shift + B shortcut key or using the Build menu as shown below.

The build process generates a portable class library, which can be used like a normal class library. More information on how to use can be found at the MSDN Portable Class Libraries documentation.

The supported version is **.NET Standard 2.0**. For checking compatibility of your .NET implementation with the generated library, [click here](https://dotnet.microsoft.com/en-us/platform/dotnet-standard#versions).

## Installation

The following section explains how to use the PetstoreBooksAPI.Standard library in a new project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the solution explorer and choose `Add -> New Project`.

![Add a new project in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Petstore%20%26%20Books%20API-CSharp&workspaceName=PetstoreBooksAPI&projectName=PetstoreBooksAPI.Standard&rootNamespace=PetstoreBooksAPI.Standard&step=addProject)

Next, choose `Console Application`, provide `TestConsoleProject` as the project name and click OK.

![Create a new Console Application in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=Petstore%20%26%20Books%20API-CSharp&workspaceName=PetstoreBooksAPI&projectName=PetstoreBooksAPI.Standard&rootNamespace=PetstoreBooksAPI.Standard&step=createProject)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the `TestConsoleProject` as the start-up project. To do this, right-click on the `TestConsoleProject` and choose `Set as StartUp Project` form the context menu.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Petstore%20%26%20Books%20API-CSharp&workspaceName=PetstoreBooksAPI&projectName=PetstoreBooksAPI.Standard&rootNamespace=PetstoreBooksAPI.Standard&step=setStartup)

### 3. Add reference of the library project

In order to use the `PetstoreBooksAPI.Standard` library in the new project, first we must add a project reference to the `TestConsoleProject`. First, right click on the `References` node in the solution explorer and click `Add Reference...`

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Petstore%20%26%20Books%20API-CSharp&workspaceName=PetstoreBooksAPI&projectName=PetstoreBooksAPI.Standard&rootNamespace=PetstoreBooksAPI.Standard&step=addReference)

Next, a window will be displayed where we must set the `checkbox` on `PetstoreBooksAPI.Standard` and click `OK`. By doing this, we have added a reference of the `PetstoreBooksAPI.Standard` project into the new `TestConsoleProject`.

![Creating a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Petstore%20%26%20Books%20API-CSharp&workspaceName=PetstoreBooksAPI&projectName=PetstoreBooksAPI.Standard&rootNamespace=PetstoreBooksAPI.Standard&step=createReference)

### 4. Write sample code

Once the `TestConsoleProject` is created, a file named `Program.cs` will be visible in the solution explorer with an empty `Main` method. This is the entry point for the execution of the entire solution. Here, you can add code to initialize the client library and acquire the instance of a Controller class. Sample code to initialize the client library and using Controller methods is given in the subsequent sections.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=Petstore%20%26%20Books%20API-CSharp&workspaceName=PetstoreBooksAPI&projectName=PetstoreBooksAPI.Standard&rootNamespace=PetstoreBooksAPI.Standard&step=addCode)

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | Environment | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `ApiKey` | `string` | *Default*: `"S36VNES3R5jDxeBwfdVeWvqKUQoWem8l"` |

The API client can be initialized as follows:

```csharp
PetstoreBooksAPI.Standard.PetstoreBooksAPIClient client = new PetstoreBooksAPI.Standard.PetstoreBooksAPIClient.Builder()
    .CustomQueryAuthenticationCredentials("S36VNES3R5jDxeBwfdVeWvqKUQoWem8l")
    .Environment(PetstoreBooksAPI.Standard.Environment.Production)
    .HttpClientConfig(config => config.NumberOfRetries(0))
    .Build();
```

## Authorization

This API uses `Custom Query Parameter`.

## List of APIs

* [API](doc/controllers/api.md)
* [Pet](doc/controllers/pet.md)
* [Store](doc/controllers/store.md)
* [User](doc/controllers/user.md)

## Classes Documentation

* [Utility Classes](doc/utility-classes.md)
* [HttpRequest](doc/http-request.md)
* [HttpResponse](doc/http-response.md)
* [HttpStringResponse](doc/http-string-response.md)
* [HttpContext](doc/http-context.md)
* [HttpClientConfiguration](doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](doc/http-client-configuration-builder.md)
* [IAuthManager](doc/i-auth-manager.md)
* [ApiException](doc/api-exception.md)

