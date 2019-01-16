using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace DemoBlazor.JavascriptInterop
{
    public static class JavaScriptInterop
    {
        public static Task<bool> Confirm(string message)
        {
            return JSRuntime.Current.InvokeAsync<bool>("helperfunction.confirm", message);
        }
    }
}
