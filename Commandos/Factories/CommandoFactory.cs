using Commandos.Entities;

namespace Commandos.Factories;

internal class CommandoFactory
{
    public List<Commando> Commandos { get; private set; } = [];

    public Commando CreateCommando(string name, string codeName, string type = "")
    {
        Commando commando = type.ToLower() switch
        {
            "sea" => new SeaCommando(name, codeName),
            "air" => new AirCommando(name, codeName),
            _ => new Commando(name, codeName),
        };
        Commandos.Add(commando);
        return commando;
    }
}
