using Commandos.Interfaces;

namespace Commandos.Entities;

internal class Weapon : IWeapon, IShootable
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public int BulletCount { get; set; }

    public Weapon(string name, string manufacturer) 
    {
        Name = name;
        Manufacturer = manufacturer;
        BulletCount = 0;
    }

    public void Shoot()
    {
        if (BulletCount > 0)
        {
            Console.WriteLine("BANG!");
            BulletCount--;
        }
    }
}
