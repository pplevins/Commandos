using Commandos.Interfaces;

namespace Commandos.Entities;

internal class Knife: IWeapon, IBreakable
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public bool IsIron { get; set; }
    public int Weight { get; set; }
    public string Color { get; set; } = string.Empty;
    public bool IsBroken { get; set; }
    public int StrikeCapacity { get; set; }
    public int NumOfStrikes { get; set; }

    public Knife(string name, string manufacturer)
    {
        Name = name;
        Manufacturer = manufacturer;
        IsBroken = false;
    }
}
