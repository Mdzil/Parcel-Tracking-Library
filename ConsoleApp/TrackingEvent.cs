using System;
using System.Collections.Generic;
using Status;


public class TrackingEvent
{
    // public Status.ParcelStatus Status { get; set; }
    public string Location { get; set; }
    public DateTime Timestamp { get; set; }
    public string Description { get; set; }

    public TrackingEvent(string location, DateTime timestamp, string description)
    {

    }
}