namespace Balta.ContentContext{
    class Career : Content{
        public IList<CareerItem> items { get; set; }
        public int TotalCourses { get{return items.Count;} }

        public Career(string Title, string Url) : base(Title, Url){
            items = new List<CareerItem>();
        }

        public override string ToString()
        {
            return base.ToString() + $"Total courses: {TotalCourses}";
            
        }
    }
}