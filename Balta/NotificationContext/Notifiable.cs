namespace Balta.NotificationContext{
    public abstract class Notifiable{
        public List<Notification> Notifications { get; set; }
        public Notifiable()
        {
            Notifications = new List<Notification>();
        }
        public bool isInvalid { get{ return Notifications.Any();}}

        public void addNotification(Notification notification){
            Notifications.Add(notification);
        }

        public void addNotifications(IEnumerable<Notification> notes){
            Notifications.AddRange(notes);
        }
    }
}