using Commandos.Interfaces;

namespace Commandos.Entities;

internal class SeaCommando : Commando, IDiver
{
    public SeaCommando(string name, string codeName) : base(name, codeName) { }

    public override void Attack() => Console.WriteLine($"Sea commando {CodeName} is attacking");

    public void Dive() => Console.WriteLine("Sea commando is scuba diving.");
}
