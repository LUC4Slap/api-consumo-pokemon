using System;
using System.Collections.Generic;

namespace apiPoke.Entities;

public class PokemonEntiti {
    public string Name { get; set; }
    public List<PokemonsMovieEntiti> Moves { get; set; }
    public List<PokemonAbilityItemEntiti> Abilities { get; set; }
    public PokemonSpritesEntiti Sprites { get; set; }
    public PokemonSpeciesEntiti Species { get; set; }
    public List<PokemonStatesEntiti> Stats { get; set; }
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
    public string back_default { get; set; }
    public string back_female { get; set; }
    public string back_shiny { get; set; }
    public string back_shiny_female { get; set; }
    public string front_default { get; set; }
    public string front_female { get; set; }
    public string front_shiny { get; set; }
    public string front_shiny_female { get; set; }
}

public class PokemonSpeciesEntiti
{
    public string Name { get; set; }
    public Uri Url { get; set; }
}

public class PokemonStatesEntiti
{
    public int base_stat { get; set; }
    public int effort { get; set; }
    public PokemonStatesItemEntiti Stat { get; set; }
}

public class PokemonStatesItemEntiti
{
    public string Name { get; set; }
    public Uri Url { get; set; }
}