namespace apiPoke.Entities;

public class PokemonEntiti {
    public string Name { get; set; }
    public string Url { get; set; }
    
    public PokemonEntiti(string name, string url)
    {
        Name = name;
        Url = url;
    }
}