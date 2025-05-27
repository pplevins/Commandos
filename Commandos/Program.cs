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
    }
}
