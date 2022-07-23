using Client.Config;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using System;

namespace Client.Pages
{
  public partial class Index
    {
        public bool IsLoading = { get; set; }
        public const bool IsDebug =
            #if DEBUG
            true
            #else
            false
            #endif
            ;
        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                AppState.Reset();
            }
        }
    }
}
