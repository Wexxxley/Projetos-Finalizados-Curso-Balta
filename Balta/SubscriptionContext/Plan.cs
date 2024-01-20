using Balta.SharedContext;

namespace Balta.SubscriptionContext{
    public class Plan : Base{
        public string title { get; set; }
        public int days { get; set; }
        public decimal price { get; set; }
    }
}