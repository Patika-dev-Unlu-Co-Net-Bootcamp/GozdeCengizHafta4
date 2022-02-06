using System;

namespace NewsletterProject
{
    public class News
    {

        public int Id { get; set; }
        public int CategoryID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }

}
