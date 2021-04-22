namespace EFCore
{
    public class Article
    {
        public int id { get; set; }

        public string Title { get; set; }//文章標題
        public string Kind { get; set; }//文章類型
        public string Content { get; set; }//文章內容
        public string Author { get; set; }//文章作者

    }
}