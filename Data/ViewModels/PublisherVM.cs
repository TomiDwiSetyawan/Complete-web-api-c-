using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Data.ViewModels
{
    public class PublisherVM
    {
        public string Name { get; set; }
    }

    public class PublisherwithBooksAndAuthorsVM
    {
        public string Name { get; set; }

        public List<BookAuthorVM> BookAuthors { get; set; }
    }

    public class BookAuthorVM
    {
        public string Bookname { get; set; }

        public List<string> BookAuthors { get; set; }
    }
}
