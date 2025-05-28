namespace Commandos.Interfaces;

internal interface IShootable
{
    public int BulletCount { get; set; }
    public void Shoot();
}
