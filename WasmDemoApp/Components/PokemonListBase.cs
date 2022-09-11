using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace WasmDemoApp.Components
{
    public class EventsTableBase : ComponentBase
    {
        
        protected PokemonAPIData APIData = new PokemonAPIData();
        HttpClient APIClient = new HttpClient();
        protected Dictionary<string, PokemonStats> PokeStats = new Dictionary<string, PokemonStats>();


        protected override async Task OnInitializedAsync()
        {
            APIData.results = new List<ListPokemon>();
            var response = await APIClient.GetAsync("https://pokeapi.co/api/v2/pokemon/?limit=1118&offset=0");
            Console.WriteLine("result fetcehd, status: " + response.StatusCode);

            try
            {
                var data = JsonConvert.DeserializeObject<PokemonAPIData>(response.Content.ReadAsStringAsync().Result);
                APIData = data; 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to parse API data, {0}", ex.ToString());
            }
        }


        protected async Task GetPokemonStats(string url, string name)
        {
            var response = await APIClient.GetAsync(url);

            try
            {
                var data = JsonConvert.DeserializeObject<PokemonStats>(response.Content.ReadAsStringAsync().Result);
                if(!PokeStats.ContainsKey(name))
                {
                    PokeStats.Add(name, data);
                }
                StateHasChanged();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to parse API data, {0}", ex.ToString());
            }


        }

        protected (Double, Double) Calculate(List<ListPokemon> PokemonList) {
            Double averageLength = 0.0;
            Double numberOfA = 0.0;

            Int32 length = PokemonList.Count;
            foreach (ListPokemon pokemon in PokemonList)
            {
                averageLength += pokemon.name.Length;
                numberOfA += pokemon.name.Split('a').Length - 1;

            }

            return (averageLength / length, numberOfA);
        }

        protected void Test(List<ListPokemon> PokemonList)
        {

            long startmilliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            for (int i = 0; i < 10; i++) {
                
                (Double averageLength, Double numberOfA) = Calculate(PokemonList);
                
                Console.WriteLine(averageLength.ToString() + ", " + numberOfA.ToString());
            }

            long endmilliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Console.WriteLine("time is: ");
            Console.WriteLine(endmilliseconds - startmilliseconds);
            Console.WriteLine("ms");

        }

    }

    
}
