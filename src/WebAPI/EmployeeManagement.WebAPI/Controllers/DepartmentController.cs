using EmployeeManagement.Application.DTOs.Department;
using EmployeeManagement.Application.Features.Department.Requests.Commands;
using EmployeeManagement.Application.Features.Department.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly ISender sender;

        public DepartmentController(ISender sender) => this.sender = sender;

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var department = await sender.Send(new GetDepartmentListRequest());
            return Ok(department);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var department = await sender.Send(new GetDepartmentDetailRequest { Id = id });
            return Ok(department);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DepartmentCreateDto value)
        {
            var result = await sender.Send(new CreateDepartmentCommand { DepartmentCreateDto = value });
            return Ok(result);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromBody] DepartmentDto value)
        {
            var result = await sender.Send(new UpdateDepartmentCommand { Department = value });
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await sender.Send(new DeleteDepartmentCommand { Id = id });
            return Ok();
        }
    }
}
