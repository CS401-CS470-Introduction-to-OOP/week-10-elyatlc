namespace week10;

public enum CharacterState
{
    Alive,
    Injured,
    Dead
}
public class Character
{
    public string Name { get; set; } 
    public string Class { get; set; }
    public int Level { get; set; }
    public double Health { get; set; }
    public int Gold { get; set; }
    public CharacterState State { get; set; }

    public Character(string name, string _class, int level, double health, int gold, CharacterState state)
    {
        Name = name;
        Class = _class;
        Level = level;
        Health = health;
        Gold = gold;
        State = state;
    }
    
}