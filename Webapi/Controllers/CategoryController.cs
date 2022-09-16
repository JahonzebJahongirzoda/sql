using Microsoft.AspNetCore.Mvc;
using Infrastructure.Services;
using Domain.Entities;

namespace Webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    private readonly CategoryServices _service;

    public CategoryController()
    {
        _service = new CategoryServices();
    }
    [HttpPost]
    public string Create(Categories category)
    {
        return _service.AddCategory(category);
    }

    [HttpGet]
    public List<Categories> Get()

    {
        return _service.GetCategory();
    }
    [HttpPut]
    public int Put(Categories category)

    {
        return _service.UpdateCategory(category);
    }
    [HttpDelete]
    public int Delete(int id)

    {
        return _service.DeleteCategory(id);
    }
















}
