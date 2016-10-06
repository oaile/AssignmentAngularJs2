using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News.API.Models
{
    public class NewsModel : BaseModel
    {
        public Guid newsId { get; set; }
        public string newsTitle { get; set; }
        public string newsAuthor { get; set; }
        public DateTime postDate { get; set; }
        public string newsImageUrl { get; set; }
        public string newsSummary { get; set; }
        public string newsContent { get; set; }
    }
}