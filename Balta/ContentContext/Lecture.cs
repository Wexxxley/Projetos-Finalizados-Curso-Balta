using Balta.SharedContext;

namespace Balta.ContentContext{
    class Lecture : Base{
        public int Order { get; set; }
        public string Title { get; set; }
        public int dururationInMinutes { get; set; }
    }
}