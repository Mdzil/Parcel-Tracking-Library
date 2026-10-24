public class TrackingEvent
{
    public ParcelStatus Status { get; set; }
    public string Location { get; set; }
    public DateTime Timestamp { get; set; }
    public string Description { get; set; }

    public TrackingEvent(ParcelStatus status, string location, DateTime timestamp, string description)
    {

    }
}