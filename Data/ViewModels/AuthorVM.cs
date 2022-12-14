using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Data.ViewModels
{
    public class AuthorVM
    {
        public string FullName { get; set; }
    }

    public class AuthorWithBoooksVM
    {
        public string FullName { get; set; }
        public List<string> BookTitles { get; set; }
    }
}
