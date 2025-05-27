using Commandos.Entities;

namespace Commandos.Factories;

internal class EnemyFactory
{
    public List<Enemy> Enemies { get; private set; } = [];

    public Enemy CreateEnemy()
    {
        Enemy enemy = new();
        Enemies.Add(enemy);
        return enemy;
    }
}
