using Balta.ContentContext.Enums;

namespace Balta.ContentContext{
    class Course : Content{
        public string tag { get; set; }
        public IList<Modulo> modulos {get; set; }
        public int dururationInMinutes { get; set; }
        public EContentLevel level { get; set; }

        public Course (string Title, string Url) : base(Title, Url){
            modulos = new List<Modulo>();
        }
    }
}