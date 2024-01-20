using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.ContentContext{
    class CareerItem : Base{
        public CareerItem(int order, string title, string description, Course course)
        {
            if(course == null){
                addNotification(new Notification("Course", "course is null"));
            }
            Order = order;
            Title = title;
            Description = description;
            this.course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public String Description { get; set; }
        public Course course { get; set; }
    }
}