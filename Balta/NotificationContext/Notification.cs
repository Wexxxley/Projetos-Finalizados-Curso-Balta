namespace Balta.NotificationContext{
    public sealed class Notification{

        //Construtor padrao
        public Notification()
        {
        }
        //Construtor com parametros
        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; set; }
        public string Message { get; set; }

    }
}