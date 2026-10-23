namespace ParcelTrack.Library
{
    public class Parcel
    {
        public string TrackingNumber { get; set; }
        public double WeightKg { get; set; }
        public ParcelStatus Status { get; set; }
        public Contact Sender { get; set; }
        public Contact Recipient { get; set; }
        public List<TrackingEvent> TrackingHistory { get; set; }

        public Parcel( string trackingNumber, double weightKg, Contact sender, Contact recipient)
        {
           
        }

        public void AddTrackingEvent(TrackingEvent trackingEvent)
        {
            
        }
    }
}