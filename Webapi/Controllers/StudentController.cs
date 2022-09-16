using Microsoft.AspNetCore.Mvc;
using Infrastructure.Services;
using Domain.Entities;

namespace Webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly StudentServices _service;

    public StudentController()
    {
        _service = new StudentServices();
    }
    [HttpPost]
    public string Create(Students student)
    {
        return _service.AddStudent(student);
    }

    [HttpGet]
    public List<Students> Get()

    {
        return _service.GetStudents();
    }
    [HttpPut]
    public int Put(Students student)

    {
        return _service.UpdateStudent(student);
    }
    [HttpDelete]
    public int Delete(int id)

    {
        return _service.DeleteStudent(id);
    }
















}
