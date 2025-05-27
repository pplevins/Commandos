using Commandos.Entities;

namespace Commandos;

internal class Program
{
    static void Main(string[] args)
    {
        Commando commando = new("Alex", "Night Wolf");
        Weapon weapon = new("Gun", "H&C", 100);
        commando.Hide();
        commando.Walk();
        commando.Attack();
        weapon.Shoot();
        Console.WriteLine(commando.CodeName);
        commando.CodeName = "007";
        Console.WriteLine(commando.CodeName);
        Console.WriteLine(commando.SayName(UserRank.Commando));
        Console.WriteLine(commando.SayName(UserRank.Colonel));
        Console.WriteLine(commando.SayName(UserRank.General));


        Commando[] commandos = 
            [
            commando, 
            new AirCommando("Shimi", "Eagle"), 
            new SeaCommando("John", "Baby Shark")
            ];

        foreach (var command in commandos)
        {
            command.Attack();
        }
    }
}
