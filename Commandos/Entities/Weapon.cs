namespace Commandos.Entities;

internal class Weapon
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    int BulletCount { get; set; }

    public Weapon(string name, string manufacturer, int bullets) 
    {
        Name = name;
        Manufacturer = manufacturer;
        BulletCount = bullets;
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
