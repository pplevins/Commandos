namespace Commandos.Entities;

internal class Enemy
{
    public string Name { get; set; } = "";
    public int Lives { get; set; } = 100;
    bool IsAlive { get; set; }
    public void Shout()
    {
        Console.WriteLine("I am the ENEMY!!!");
    }
}
