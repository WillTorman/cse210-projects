class Player
{
    //private string _uname;
    private int _tHealth;
    private int _cHealth;
    private int _attack;
    private int _defense;

    public Player(int tHealth, int attack, int defense)
    {
        //this._uname = uname;
        this._tHealth = tHealth;
        this._cHealth = tHealth;
        this._attack = attack;
        this._defense = defense;
    }

    // Getter for Current Health
    public int GetCurrentHealth()
    {
        return _cHealth;
    }

    // Setter for Current Health
    public void SetCurrentHealth(int hp)
    {
        _cHealth = hp;
    }

    public void DislayHp(){
        Console.WriteLine($"HP: {_cHealth} / {_tHealth}");
    }
}