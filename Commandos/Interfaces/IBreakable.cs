namespace Commandos.Interfaces;

internal interface IBreakable
{
    public bool IsBroken { get; set; }
    public int StrikeCapacity { get; set; }
    public int NumOfStrikes { get; set; }
}
