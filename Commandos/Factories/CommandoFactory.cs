using Commandos.Entities;

namespace Commandos.Factories;

internal class CommandoFactory
{
    private readonly Dictionary<string, Func<string, string, Commando>> CommandoRegistry = [];
    public List<Commando> Commandos { get; private set; } = [];

    public void RegisterCommando(string name, Func<string, string, Commando> register)
    {
        CommandoRegistry.Add(name, register);
    }

    public Commando CreateCommando(string name, string codeName, string type = "Commando")
    {
        Commando commando = CommandoRegistry[type](name, codeName);
        Commandos.Add(commando);
        return commando;
    }
}
