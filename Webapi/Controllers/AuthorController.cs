using Microsoft.AspNetCore.Mvc;
using Infrastructure.Services;
using Domain.Entities;

namespace Webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthorController : ControllerBase
{
    private readonly AuthorServices _service;

    public AuthorController()
    {
        _service = new AuthorServices();
    }
    [HttpPost]
    public string Create(Authors author)
    {
        return _service.AddAuthor(author);
    }

    [HttpGet]
    public List<Authors> Get()

    {
        return _service.GetAuthors();
    }
    [HttpPut]
    public int Put(Authors author)

    {
        return _service.UpdateAuthor(author);
    }
    [HttpDelete]
    public int Delete(int id)

    {
        return _service.DeleteAuthor(id);
    }
















}
