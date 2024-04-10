class Goblin : Enemy
{
    public Goblin() : base(5, 3, 2)
    {

    }

    public override void DisplayEnemyHp()
    {
        Console.WriteLine($"Goblin HP: {_enemyHp}");
    }
}