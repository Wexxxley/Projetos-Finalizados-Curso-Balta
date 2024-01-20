namespace Balta.SubscriptionContext{
    public class Subscription{
        public Plan plan { get; set; }
        public DateTime? endDate { get; set; }
        public bool isInactive {get{return endDate <= DateTime.Now;}}
    }
}