class Skeleton : Enemy
{
    public Skeleton() : base(5, 3, 2)
    {

    }

    public override void DisplayEnemyHp()
    {
        Console.WriteLine($"Skeleton HP: {_enemyHp}");
    }
}