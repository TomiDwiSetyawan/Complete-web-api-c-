using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Data.Services;
using TestApi.Data.ViewModels;

namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksServices _booksServices;
        public BooksController(BooksServices booksServices)
        {
            _booksServices = booksServices;
        }

        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVM book)
        {
            _booksServices.AddBook(book);
            return Ok();
        }
    }
}
