# DevExpress Blazor Training Course - Sample Code

The DevExpress Training Course for [Microsoft Blazor](https://docs.microsoft.com/en-us/aspnet/core/client-side/spa/blazor/?view=aspnetcore-3.0) is available here: https://www.devexpress.com/support/training/blazor

This repository contains the source code of the samples shown in the video course, in the folder `WebAssembly`. An additional set of samples for Server-Side Blazor is included in the folder `Server`.

## Blazor WebAssembly

These are the dependency versions for the WebAssembly samples:

- Microsoft .NET Core SDK 3.0.100 - preview9 (x64) `3.0.100.14004` (as shown in the Windows _Apps & features_ list)
  - Blazor assemblies show version `3.0.0-preview9.19424.4`

### What about later prerelease versions of .NET Core 3.1?

We have tested all WebAssembly samples with .NET Core 3.1 previews released later than the published video course. They work correctly and without code changes, using the latest upgraded versions from NuGet. The last version tested is this:

- Microsoft .NET Core SDK 3.1.100 - preview2 (x64) `3.1.100.014569` (as shown in the Windows _Apps & features_ list)
  - Blazor assemblies show version `3.1.0-preview2.19528.8`

We will release new versions of the WebAssembly samples if Microsoft introduces breaking changes, or when Blazor WebAssembly is released with .NET Core 3.1.

## Server-Side Blazor

The `Server` folder contains a set of sample projects similar to the ones presented in the video course. They target the release version of .NET Core 3.0. Other than structural aspects of the server-side projects, these are the implementation differences:

- Instead of the WebAssembly `HttpClient`, the interface `IHttpClientFactory` is injected for access to web services. JSON deserialization is performed by `System.Text.Json.JsonSerializer`, as described in [Microsoft documentation](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-requests?view=aspnetcore-3.0).
- Synchronous `invokeMethod` is not supported in server-side Blazor, so all calls use `invokeMethodAsync`.
