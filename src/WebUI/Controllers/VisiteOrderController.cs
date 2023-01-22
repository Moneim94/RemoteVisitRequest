using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.Application.RemoteOrder.Commands.CreateRemoteOrder;
using Order.WebUI.Controllers;

namespace WebUI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class VisiteOrderController : ApiControllerBase
{
    [HttpGet]
    public async  Task<ActionResult<int>> CreateVisitOrder(CreateVisitOrderCommand createRemoteOrderCommand)
    {
       return await Mediator.Send(createRemoteOrderCommand);
    }
}
