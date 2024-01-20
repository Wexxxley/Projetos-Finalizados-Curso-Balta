using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.SubscriptionContext{
    public class Student : Base{
        public User user { get; set; }
        public string name { get; set; }
        public string Email { get; set; }
        public IList<Subscription> subscriptions { get; set; }
        public bool isPremiun { get{return subscriptions.Any(x=>x.isInactive);} }

        public void createSubscription(Subscription subscription){
            if(isPremiun){
                addNotification(new Notification("Premiun", "O aluno ja tem assinatura"));
            }
        }
    }
}