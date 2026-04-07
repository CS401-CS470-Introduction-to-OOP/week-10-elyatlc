namespace week10;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class Party: IEnumerable<Character>
{
    private List<Character> party = new List<Character>();
    
    public IEnumerator <Character> GetEnumerator() => party.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => party.GetEnumerator();
    public void Add(Character character)
    {
        party.Add(character);
    }
    public IEnumerable<Character> GetAllCharacters()
    {
        foreach (var character in party)
        {
            yield return character;
        }
    }
    
    public IEnumerable<Character> GetActiveCharacters()
    {
        foreach (var character in party)
        {
            if (character.State == CharacterState.Alive || character.State == CharacterState.Injured)
            {
                yield return character;
            }
        }
    }

    public IEnumerable<Character> GetCharactersWithHP(double hp)
    {
        foreach (var character in party)
        {
            if (character.Health < hp)
            {
                yield return character;
            }
        }
    }

    public IEnumerable<Character> GetActiveCharactersWithLv(int level)
    {
        var orderedLv = party.Where(ch => ch.Level > level).ToList();
        foreach (var character in orderedLv)
        {
            yield return character;
        }
    }

    public IEnumerable<Character> SortByHp()
    {
        return party.OrderBy(ch => ch.Health);
    }

    public List<string> GetNames()
    {
        var characterNames = party.Select(c => c.Name).ToList();
        return characterNames;
    }
    

}