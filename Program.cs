using System;
using System.Collections.Generic;
using ParcelTrack.Library;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create Sender and Recipient Contacts
        Contact sender = new Contact("Alice Johnson", "555-0101", "123 Sender St, NY");
        Contact recipient = new Contact("Bob Smith", "555-0202", "456 Recipient Ave, CA");

        // 2. Initialize a new Parcel and Register it
        Parcel parcel = new Parcel("TRK987654321", 4.5, sender, recipient);
        ParcelTracker tracker = new ParcelTracker();
        tracker.RegisterParcel(parcel);

        // 3. Calculate Shipping Costs
        DeliveryService expressService = new DeliveryService 
        { 
            ServiceName = "Express Air", 
            BaseFee = 15.00m, 
            RatePerKg = 5.50m 
        };
        ShippingCalculator calculator = new ShippingCalculator();
        decimal shippingFee = calculator.CalculateFee(parcel, expressService);

        // 4. Update Tracking Status
        TrackingManager trackingManager = new TrackingManager();
        TrackingEvent pickupEvent = new TrackingEvent(
            ParcelStatus.PickedUp, 
            "New York Hub", 
            DateTime.Now, 
            "Package received at facility"
        );
        
        trackingManager.AddTrackingEvent(parcel, pickupEvent);
        parcel.AddTrackingEvent(pickupEvent); 

        // 5. Query the System
        Parcel retrievedParcel = tracker.FindParcel("TRK987654321");
        ParcelStatus currentStatus = trackingManager.GetCurrentStatus(parcel);
        List<TrackingEvent> history = tracker.GetTrackingHistory("TRK987654321");
    }
}