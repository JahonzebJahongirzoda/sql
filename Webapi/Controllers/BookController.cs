using Microsoft.AspNetCore.Mvc;
using Infrastructure.Services;
using Domain.Entities;

namespace Webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private readonly BookServices _service;

    public BookController()
    {
        _service = new BookServices();
    }
    [HttpPost]
    public string Create(Books book)
    {
        return _service.AddBook(book);
    }

    [HttpGet]
    public List<Books> Get(int id)

    {
        return _service.GetBooks();
    }
    [HttpPut]
    public int Put(Books book)

    {
        return _service.UpdateBook(book);
    }
    [HttpDelete]
    public int Delete(int id)

    {
        return _service.DeleteBook(id);
    }
}

