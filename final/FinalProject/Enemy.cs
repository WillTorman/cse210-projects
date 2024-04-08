class Enemy
{

    private int _enemyHp;
    private int _attack;
    private int _defense;

    public Enemy(int enemyHp, int attack, int defense)
    {
        this._enemyHp = enemyHp;
        this._attack = attack;
        this._defense = defense;
    }

    // Getter for Enemy's Health
    public int GetEnemyHealth()
    {
        return _enemyHp;
    }

    // Setter for Enemy's Health
    public void SetEnemyHealth(int hp)
    {
        _enemyHp = hp;
    }

    // Method to display Enemy's Health
    public void DisplayEnemyHp()
    {
        Console.WriteLine($"Enemy HP: {_enemyHp}");
    }
}