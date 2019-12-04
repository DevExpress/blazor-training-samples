# DevExpress Blazor Training Course - Sample Code

The DevExpress Training Course for [Microsoft Blazor](https://docs.microsoft.com/en-us/aspnet/core/client-side/spa/blazor/?view=aspnetcore-3.0) is available here: https://www.devexpress.com/support/training/blazor

This repository contains the source code of the samples shown in the video course, in the folder `WebAssembly`. An additional set of samples for Server-Side Blazor is included in the folder `Server`.

## Blazor WebAssembly

These are the dependency versions for the WebAssembly samples:

- Microsoft .NET Core SDK 3.1.100 (x64) `3.1.100.014727` (as shown in the Windows _Apps & features_ list)

  - Blazor assemblies show version `3.1.0-preview4.19579.2`

## Server-Side Blazor

The `Server` folder contains a set of sample projects similar to the ones presented in the video course. They target the release version of .NET Core 3.1. Other than structural aspects of the server-side projects, these are the implementation differences:

- Instead of the WebAssembly `HttpClient`, the interface `IHttpClientFactory` is injected for access to web services. JSON deserialization is performed by `System.Text.Json.JsonSerializer`, as described in [Microsoft documentation](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-3.0).
- Synchronous `invokeMethod` is not supported for JS interop in server-side Blazor, so all calls use `invokeMethodAsync`.
