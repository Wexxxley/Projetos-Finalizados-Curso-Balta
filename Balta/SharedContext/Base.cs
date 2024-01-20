using Balta.NotificationContext;

namespace Balta.SharedContext{
    public abstract class Base : Notifiable{
        public Guid Id { get; set; }
        public Base()
        {
            this.Id = Guid.NewGuid();
        }
    }
}