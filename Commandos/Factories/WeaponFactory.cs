using Commandos.Entities;
using Commandos.Interfaces;

namespace Commandos.Factories;

internal class WeaponFactory
{
    private readonly Dictionary<string, Func<string, string, IWeapon>> WeaponRegistry = [];
    public List<IWeapon> Weapons { get; } = [];

    public void RegisterWeapon(string name, Func<string, string, IWeapon> register)
    {
        WeaponRegistry.Add(name, register);
    }

    public IWeapon CreateWeapon(string weaponType, string name, string manufacturer)
    {
        IWeapon weapon = WeaponRegistry[weaponType](name, manufacturer);
        Weapons.Add(weapon);
        return weapon;
    }
}
