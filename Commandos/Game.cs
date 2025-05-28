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
        WFactory.RegisterWeapon("Weapon", (name, manufacturer) => new Weapon(name, manufacturer));
        WFactory.RegisterWeapon("Rock", (name, manufacturer) => new Rock(name, manufacturer));
        WFactory.RegisterWeapon("Knife", (name, manufacturer) => new Knife(name, manufacturer));
        CFactory.RegisterCommando("Commando", (name, codeName) => new Commando(name, codeName));
        CFactory.RegisterCommando("AirCommando", (name, codeName) => new AirCommando(name, codeName));
        CFactory.RegisterCommando("SeaCommando", (name, codeName) => new SeaCommando(name, codeName));

        Commando commando = CFactory.CreateCommando("Alex", "Night Wolf");
        commando.Hide();
        commando.Walk();
        commando.Attack();
        Console.WriteLine(commando.CodeName);
        commando.CodeName = "007";
        Console.WriteLine(commando.CodeName);
        Console.WriteLine(commando.SayName(UserRank.Commando));
        Console.WriteLine(commando.SayName(UserRank.Colonel));
        Console.WriteLine(commando.SayName(UserRank.General));

        AirCommando airCommando = (AirCommando)CFactory.CreateCommando("Shimi", "Eagle", "AirCommando");
        SeaCommando seaCommando = (SeaCommando)CFactory.CreateCommando("John", "Baby Shark", "SeaCommando");
        
        
        Weapon M16 = (Weapon)WFactory.CreateWeapon("Weapon", "M16", "COLT");
        M16.BulletCount = 29;
        M16.Shoot();
        Weapon AK47 = (Weapon)WFactory.CreateWeapon("Weapon", "AK47", "KALASHNIKOV");
        M16.Shoot();
        AK47.BulletCount = 30;
        Knife knife = (Knife)WFactory.CreateWeapon("Knife", "Excalibur", "King Arthur");
        Rock rock = (Rock)WFactory.CreateWeapon("Rock", "simple rock", "Hakabah");

        foreach (var command in CFactory.Commandos)
        {
            command.Attack();
        }
    }
}
