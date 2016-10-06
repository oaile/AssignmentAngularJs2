using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using News.API.Models;

namespace News.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class NewsController : ApiController
    {
        public IEnumerable<NewsModel> Get()
        {
            var news = new List<NewsModel>()
            {
                new NewsModel()
                {
                    newsTitle = "Test Title 1",
                    newsAuthor = "Oai Le",
                    postDate = new DateTime(2016, 10, 3),
                    newsImageUrl = "https://cdn3.tgdd.vn/Products/Images/42/72373/samsung-galaxy-note-5-14-200x200.jpg",
                    newsSummary =
                        "Không phải vô cớ mà BlackBerry lao dốc ngay sau khi bị vượt mặt ngay trên lĩnh vực mà hãng này đã làm chủ cho đến tận 2 năm sau khi iPhone ra đời.",
                    newsContent =
                        "Trong tuần vừa qua, BlackBerry đã chính thức tuyên bố sẽ từ bỏ thị trường phần cứng smartphone. 8 năm trước, khi thành công của iPhone đã được chứng minh, vẫn chẳng có ai nghĩ BlackBerry/RIM sẽ có ngày thảm hại như thế này cả. Thực tế, năm 2008 lại là một năm rất huy hoàng của BlackBerry khi cả 2 vị CEO của RIM là Mike Lazaridis và Jim Balsillie đều được tờ báo tài chính Barron's bầu vào danh sách 100 CEO tiêu biểu của thế giới. Dĩ nhiên, Steve Jobs cũng nằm trong danh sách này. Vào năm 2008, Android vẫn còn chưa trưởng thành vì Google còn đang phải gấp rút từ bỏ tầm nhìn sử dụng bàn phím vật lý ban đầu để chạy theo tầm nhìn cảm ứng toàn bộ sau thành công của iPhone. Trên thị trường smartphone Mỹ lúc này, iPhone là sản phẩm hot nhất với thị phần từ 0% vọt lên 17% chỉ sau một năm, nhưng BlackBerry vẫn là vua với thị phần cao gấp 2,5 lần Apple."
                },
                new NewsModel()
                {
                    newsTitle = "Test Title 2",
                    newsAuthor = "Oai Le",
                    postDate = new DateTime(2016, 10, 2),
                    newsImageUrl = "https://cdn3.tgdd.vn/Products/Images/42/72373/samsung-galaxy-note-5-14-200x200.jpg",
                    newsSummary =
                        "Không phải vô cớ mà BlackBerry lao dốc ngay sau khi bị vượt mặt ngay trên lĩnh vực mà hãng này đã làm chủ cho đến tận 2 năm sau khi iPhone ra đời.",
                    newsContent =
                        "Trong tuần vừa qua, BlackBerry đã chính thức tuyên bố sẽ từ bỏ thị trường phần cứng smartphone. 8 năm trước, khi thành công của iPhone đã được chứng minh, vẫn chẳng có ai nghĩ BlackBerry/RIM sẽ có ngày thảm hại như thế này cả. Thực tế, năm 2008 lại là một năm rất huy hoàng của BlackBerry khi cả 2 vị CEO của RIM là Mike Lazaridis và Jim Balsillie đều được tờ báo tài chính Barron's bầu vào danh sách 100 CEO tiêu biểu của thế giới. Dĩ nhiên, Steve Jobs cũng nằm trong danh sách này. Vào năm 2008, Android vẫn còn chưa trưởng thành vì Google còn đang phải gấp rút từ bỏ tầm nhìn sử dụng bàn phím vật lý ban đầu để chạy theo tầm nhìn cảm ứng toàn bộ sau thành công của iPhone. Trên thị trường smartphone Mỹ lúc này, iPhone là sản phẩm hot nhất với thị phần từ 0% vọt lên 17% chỉ sau một năm, nhưng BlackBerry vẫn là vua với thị phần cao gấp 2,5 lần Apple."
                }
            };

            return news;
        }
    }
}