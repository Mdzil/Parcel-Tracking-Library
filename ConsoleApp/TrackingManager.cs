using System;
using Status;

public class TrackingManager
{
    public void AddTrackingEvent(Parcel parcel, TrackingEvent trackingEvent)
    {

    }

    public Status.ParcelStatus GetCurrentStatus(Parcel parcel)
    {
        return Status.ParcelStatus.Registered;
    }
}