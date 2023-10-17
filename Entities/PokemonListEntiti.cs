using System.Collections.Generic;
using System;

namespace apiPoke.Entities;
public class PokemonList
{
    public int Count { get; set; }
    public Uri Next { get; set; }
    public Uri Previous { get; set; }
    public List<PokemonListItem> Results { get; set; }
}

public class PokemonListItem
{
    public string Name { get; set; }
    public Uri Url { get; set; }
}
