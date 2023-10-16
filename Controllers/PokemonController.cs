using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using apiPoke.Entities;

namespace apiPoke.Controllers;

[ApiController]
[Route("V1/pokemons")]
public class PokemonsController: ControllerBase
{
    [HttpGet(Name = "getPokemons")]
    public static async Task<IResult> getPokemons()
    {
        var url = "https://pokeapi.co/api/v2/pokemon/";
        try
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            if (response.StatusCode == HttpStatusCode.BadRequest) return Results.BadRequest();
            var json = await response.Content.ReadAsStringAsync();
            var jsonObject = JsonConvert.DeserializeObject<PokemonEntiti>(json);
             if(jsonObject != null) {
                 return Results.Ok(jsonObject);
             } else
             {
                 return Results.NotFound();
             }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return Results.NotFound(e);
        }
    }
}