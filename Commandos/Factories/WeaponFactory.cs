using Commandos.Entities;

namespace Commandos.Factories;

internal class WeaponFactory
{
    public List<Weapon> Weapons { get; private set; } = [];

    public Weapon CreateWeapon(string name, string manufacturer, int bullets)
    {
        Weapon weapon = new(name, manufacturer, bullets);
        Weapons.Add(weapon);
        return weapon;
    }
}
