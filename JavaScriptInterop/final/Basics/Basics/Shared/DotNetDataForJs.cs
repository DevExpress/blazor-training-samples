using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basics.Shared
{
  public static class DotNetDataForJs
  {
    [JSInvokable]
    public static DateTime GetCurrentTime()
    {
      return DateTime.Now;
    }

    [JSInvokable]
    public static async Task<DateTime> GetCurrentTimeAsync()
    {
      return await Task.FromResult(DateTime.Now);
    }
  }
}
