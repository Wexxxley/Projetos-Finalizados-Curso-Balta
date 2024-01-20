using Balta.SharedContext;

namespace Balta.ContentContext{
    class Content : Base {
        public String Title { get; set; }
        public string Url { get; set; }

        public Content(String Title, string Url){
            this.Title = Title;
            this.Url = Url;
        }
    }
}