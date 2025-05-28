namespace Commandos.Entities;

internal class Commando
{
    private readonly string _name;
    public string CodeName { get; set; }

    private readonly string[] _tools = ["Hammer", "Chisel", "Rope", "Bag", "Water Bottle"];
    public string[] Tools => _tools;
    public CommandoStatus Status { get; set; }

    public Commando(string name, string codeName)
    {
        _name = name;
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

    public virtual void Attack() => Console.WriteLine($"Commando {CodeName} is attacking");

    public string SayName(UserRank rank)
    {
        return 
            rank switch
            {
                UserRank.Colonel => CodeName,
                UserRank.General => _name,
                _ => "Name is confidential",
            };
    }
}
