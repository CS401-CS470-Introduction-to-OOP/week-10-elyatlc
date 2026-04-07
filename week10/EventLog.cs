namespace week10;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class EventLog:  IEnumerable<Event>
{
    private List<Event> events = new List<Event>();
    
    public IEnumerator <Event> GetEnumerator() => events.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => events.GetEnumerator();
    public void Add(Event @event)
    {
        events.Add(@event);
    }
    public IEnumerable<Event> GetAllEvents()
    {
        var ordered = events.OrderBy(n => n.TurnNumber);
        
        foreach (var @event in ordered)
        {
            yield return  @event;
        }
    }
    public IEnumerable<Event> GetEventType( EventType eventType)
    {
        foreach (var @event in events)
        {
            if (@event.EventType == eventType)
            {
                yield return @event;
            }
        }
    }

    public IEnumerable<Event> GetLastEvents(int count)
    {
        var last = events.TakeLast(count).ToList();
        var orderedLast = last.OrderBy(n => n.TurnNumber);
        foreach (var @event in orderedLast)
        {
            yield return  @event;
        }
    }
}