using System.Collections.Generic;

public class EventService
{
    private List<Event> events = new List<Event>();

    public List<Event> GetAllEvents()
    {
        return events;
    }

    public void CreateEvent(Event newEvent)
    {
        if (events.Exists(e => e.Name == newEvent.Name))
        {
            throw new Exception("Event name must be unique.");
        }
        events.Add(newEvent);
    }

    public void EditEvent(Event updatedEvent)
    {
        var existingEvent = events.Find(e => e.Name == updatedEvent.Name);
        if (existingEvent == null)
        {
            throw new Exception("Event not found.");
        }
        existingEvent.Date = updatedEvent.Date;
        existingEvent.Details = updatedEvent.Details;
    }

    public void DeleteEvent(string eventName)
    {
        var eventToDelete = events.Find(e => e.Name == eventName);
        if (eventToDelete != null)
        {
            events.Remove(eventToDelete);
        }
        else
        {
            throw new Exception("Event not found.");
        }
    }
}