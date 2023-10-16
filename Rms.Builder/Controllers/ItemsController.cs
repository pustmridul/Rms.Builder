using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Rms.Builder.Application.Command;
using Rms.Builder.Application.Model;
using Rms.Builder.Application.Queries;

namespace Rms.Builder.Controllers
{
    [ApiController]
    public class ItemsController : ApiControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Save(ItemReq model)
        {
            var result = await Mediator.Send(new CreateItemCommand { Model = model });
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAlleById(int id)
        {
            var result= await Mediator.Send(new GetItemByIdQuery() { Id = id });
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(int pageNo = 1, int pageSize = 1000)
        {
            var result= await Mediator.Send(new GetAllItemQuery()
            {
                PageNumber = pageNo,
                PageSize = pageSize
            });
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Remove(int id)
        {
            var result= await Mediator.Send(new DeleteItemCommand() { Id = id });

            return Ok(result);
        }
    }
}
