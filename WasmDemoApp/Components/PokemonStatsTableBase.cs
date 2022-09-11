using System;
using Microsoft.AspNetCore.Components;

namespace WasmDemoApp.Components
{
    
    public class PokemonStatsTableBase : ComponentBase
    {
        [Parameter]
        public PokemonStats PokeStats { get; set; }

    }
}
