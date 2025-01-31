using EmployeeManagement.Application.DTOs.PerformanceReview;
using EmployeeManagement.Application.Features.PerformanceReview.Requests.Commands;
using EmployeeManagement.Application.Features.PerformanceReview.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerformanceReviewController : ControllerBase
    {
        private readonly ISender sender;

        public PerformanceReviewController(ISender sender) => this.sender = sender;

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var reviews = await sender.Send(new GetPerformanceReviewListRequest());
            return Ok(reviews);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var review = await sender.Send(new GetPerformanceReviewDetailRequest { Id = id });
            return Ok(review);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PerformanceReviewCreateDto value)
        {
            var result = await sender.Send(new CreatePerformanceReviewCommand { PerformanceReviewCreateDto = value });
            return Ok(result);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromBody] PerformanceReviewDto value)
        {
            var result = await sender.Send(new UpdatePerformanceReviewCommand { PerformanceReviewDto = value });
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await sender.Send(new DeletePerformanceReviewCommand { Id = id });
            return Ok();
        }
    }
}
