namespace week10;

public enum EventType
{
    Fight,
    Exploration
}
public class Event
{
    public int TurnNumber { get; set; }
    public string Description { get; set; }
    public EventType EventType {get; set;}
    public string Changes { get; set; }

    public Event(int turnNumber, string description, EventType eventType, string changes)
    {
        TurnNumber = turnNumber;
        Description = description;
        EventType = eventType;
        Changes = changes;
    }
}