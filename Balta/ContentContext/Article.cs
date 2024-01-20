namespace Balta.ContentContext{
    class Article : Content{
        public Article(string Title, string Url) : base(Title, Url){

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}