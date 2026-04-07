namespace week10;

public class Character
{
    string Name { get; set; } 
    string Class { get; set; }
    int Level { get; set; }
    double Health { get; set; }
    int Gold { get; set; }
    string State { get; set; }

    public Character(string name, string _class, int level, double health, int gold, string state)
    {
        Name = name;
        Class = _class;
        Level = level;
        Health = health;
        Gold = gold;
        State = state;
    }
    
}