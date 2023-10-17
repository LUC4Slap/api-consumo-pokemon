using System;
using System.Collections.Generic;

namespace apiPoke.Entities;

public class PokemonEntiti {
    public string Name { get; set; }
    public List<PokemonsMovieEntiti> Moves { get; set; }
    public List<PokemonAbilityItemEntiti> Abilities { get; set; }
    public PokemonSpritesEntiti Sprites { get; set; }
    public PokemonSpeciesEntiti Species { get; set; }
}


public class PokemonAbilityItemEntiti
{
    public PokenibItemAbilityEntiti Ability { get; set; }
}

public class PokenibItemAbilityEntiti
{
    public string Name { get; set; }
    public Uri Url { get; set; }
}

public class PokemonsMovieEntiti
{
    public MovieItemEntiti Move { get; set; }
}

public class MovieItemEntiti
{
    public string Name { get; set; }
    public Uri Url { get; set; }
}

public class PokemonSpritesEntiti
{
    public string front_default { get; set; }
}

public class PokemonSpeciesEntiti
{
    public string Name { get; set; }
    public Uri Url { get; set; }
}