class Character
{
    private string _uname;
    private int _tHealth;
    private int _cHealth;
    private int _attack;
    private int _defense;

    public Character(string uname, int tHealth, int cHealth, int attack, int defense)
    {
        this._uname = uname;
        this._tHealth = tHealth;
        this._cHealth = cHealth;
        this._attack = attack;
        this._defense = defense;
    }

    // public void Display()
    // {
    //     Console.WriteLine($"{uname}");
    // }
}