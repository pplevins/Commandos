using Commandos.Entities;
using Commandos.Factories;

namespace Commandos;

internal static class Game
{
    public static CommandoFactory CFactory { get; } = new CommandoFactory();
    public static EnemyFactory EFactory { get; } = new EnemyFactory();
    public static WeaponFactory WFactory { get; } = new WeaponFactory();

    public static void Play()
    {
        Commando commando = CFactory.CreateCommando("Alex", "Night Wolf");
        Weapon weapon = WFactory.CreateWeapon("Gun", "H&C", 100);
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

        AirCommando airCommando = (AirCommando)CFactory.CreateCommando("Shimi", "Eagle", "Air");
        SeaCommando seaCommando = (SeaCommando)CFactory.CreateCommando("John", "Baby Shark", "Sea");
        
        foreach (var command in CFactory.Commandos)
        {
            command.Attack();
        }
    }
}
