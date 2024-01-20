using Balta.SharedContext;

namespace Balta.ContentContext{
    class Modulo : Base{
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }

        public Modulo(){
            Lectures = new List<Lecture>();
        }
    }
}