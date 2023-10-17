
using Microsoft.AspNetCore.Mvc;
using apiPoke.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace apiPoke.Controllers;

[ApiController]
[Route("v1/pokemons")]
public class PokemonController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var url = "https://pokeapi.co/api/v2/pokemon/?offset=1&limit=1292";
        try
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<PokemonList>(json);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                // Trate os diferentes códigos de status HTTP, se necessário.
                return StatusCode((int)response.StatusCode);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500); // Erro interno do servidor
        }
    }

    [HttpGet("{id}")]
    public async Task<IResult> getPokemons(int id)
    {
        var url = $"https://pokeapi.co/api/v2/pokemon/{id}";
        try
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            if (response.StatusCode == HttpStatusCode.BadRequest) return Results.BadRequest();
            var json = await response.Content.ReadAsStringAsync();
            var jsonObject = JsonConvert.DeserializeObject<PokemonEntiti>(json);
            if (jsonObject != null)
            {
                return Results.Ok(jsonObject);
            }
            else
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