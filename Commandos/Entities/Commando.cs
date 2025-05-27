namespace Commandos.Entities;

internal class Commando
{
    public string Name { get; set; }
    public string CodeName { get; set; }

    private readonly string[] _tools = ["Hammer", "Chisel", "Rope", "Bag", "Water Bottle"];
    public string[] Tools => _tools;
    public CommandoStatus Status { get; set; }

    public Commando(string name, string codeName)
    {
        Name = name;
        CodeName = codeName;
    }

    public void Walk()
    {
        Status = CommandoStatus.Walking;
        Console.WriteLine("Commando is walking.");
    }

    public void Hide()
    {
        Status = CommandoStatus.Hiding;
        Console.WriteLine("Commando is hiding.");
    }

    public void Attack()
    {
        Console.WriteLine($"Commando {CodeName} is attacking");
    }
}
