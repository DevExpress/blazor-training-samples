# DevExpress Blazor Training Course - Sample Code

The DevExpress Training Course for [Microsoft Blazor](https://docs.microsoft.com/en-us/aspnet/core/client-side/spa/blazor/?view=aspnetcore-3.0) is available here: https://www.devexpress.com/support/training/blazor

This repository contains the source code of all samples shown in the video course. 

If you would like to access the source code versions for the current published course recording, please [use this link for the Preview 3 branch](https://github.com/DevExpress/blazor-training-samples/tree/dotnetcore-3.0-preview3).

These are the dependency versions for the samples in the `master` branch:

- Microsoft .NET Core SDK 3.0.100 - preview8 (x64) `3.0.100.13656` (as shown in the Windows _Apps & features_ list)
  - Blazor assemblies show version `3.0.0-preview8.19405.7`

## Notes about Preview 8 Updates

1. The demo `ComponentStructure/final/ParentCoordinated` has not been converted for Preview 8 yet, due to a [bug](https://github.com/aspnet/AspNetCore/issues/13162)
2. The demo `JavaScriptInterop/final/ChartIntegration` uses an `@ref` parameter in `CountryChart.razor`. In Preview 8, Microsoft was going to [introduce automatic backing field generation for `@ref`](https://github.com/aspnet/AspNetCore/issues/11197), but [the feature didn't work](https://github.com/aspnet/AspNetCore/issues/13099) and [will be removed in Preview 9](https://github.com/aspnet/Announcements/issues/381). To make the demo work with Preview 8, the extra parameter `@ref:suppressField` is used at this time, but this will no longer be necessary (or supported) in Preview 9.