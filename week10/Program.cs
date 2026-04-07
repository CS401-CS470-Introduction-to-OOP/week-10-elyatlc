namespace week10;

class Program
{
    static void Main(string[] args)
    {
        Party party = new Party();
        party.Add(new Character("Арагорн", "Warrior", 10, 100, 50, CharacterState.Alive));
        party.Add(new Character("Леголас", "Archer", 8, 80, 120, CharacterState.Alive));
        party.Add(new Character("Гімлі", "Warrior", 9, 45, 200, CharacterState.Injured));
        party.Add(new Character("Любко", "Warrior", 7, 0, 10, CharacterState.Dead));
        
        EventLog log = new EventLog();
        log.Add(new Event(1, "Початок подорожі", EventType.Exploration, "Нічого"));
        log.Add(new Event(3, "Засідка орків", EventType.Fight, "HP -20"));
        log.Add(new Event(2, "Знайдено скарб", EventType.Exploration, "Gold +50"));

        Console.WriteLine("Перебір через IEnumerable: ");
        foreach (var ch in party)
        {
            Console.WriteLine($"Персонаж: {ch.Name}, Рівень: {ch.Level}");
        }

        Console.WriteLine("\nАктивні персонажі: ");
        foreach (var ch in party.GetActiveCharacters())
        {
            Console.WriteLine($"Активний: {ch.Name} (Стан: {ch.State})");
        }

        Console.WriteLine("\n Останні дві події за хронологією: ");
        foreach (var ev in log.GetLastEvents(2))
        {
            Console.WriteLine($"Хід {ev.TurnNumber}: {ev.Description}");
        }
        
        var sortedByHp = party.SortByHp();
        foreach (var ch in sortedByHp)
        {
            Console.WriteLine($"Персонаж: {ch.Name} | HP: {ch.Health}");
        }
        
        var names = party.GetNames();
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        
        foreach (var c in party.GetAllCharacters()) 
        {
            Console.WriteLine($"- {c.Name} ({c.Class}), HP: {c.Health}");
        }
        
        var woundedOnes = party.GetCharactersWithHP(50);
        
        foreach (var c in woundedOnes)
        {
            Console.WriteLine($"- {c.Name}: поточне HP {c.Health}");
        }
        
        var active = party.GetActiveCharactersWithLv(8);
        Console.WriteLine("Персонажі з рівнем більше 8: ");
        foreach (var c in active)
        {
            Console.WriteLine(c.Name);
        }
    }
    
}