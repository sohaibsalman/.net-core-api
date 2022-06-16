using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ICrudService<Student> _crudService;

        public StudentController(ICrudService<Student> crudService)
        {
            this._crudService = crudService;
        }

        [HttpGet]
        public async Task<IEnumerable<Student>> Get()
        {
            return await _crudService.List();
        }

        [HttpGet("{id}")]
        public async Task<Student> Get(Guid id)
        {
            return await _crudService.GetById(id);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            await _crudService.Create(student);
            return Created("Student", student);
        }

        [HttpPut("{id}")]
        public async Task<Student> Update(Guid id, Student student)
        {
            return await this._crudService.Update(id, student);
        }

        [HttpDelete("{id}")]
        public async Task<Student> Delete(Guid id)
        {
            return await this._crudService.Delete(id);
        }
    }
}
