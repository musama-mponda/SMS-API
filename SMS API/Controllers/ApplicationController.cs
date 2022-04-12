using Microsoft.AspNetCore.Mvc;
using SMS_API.Interfaces;
using SMS_API.Models;

namespace SMS_API.Controllers;


[Route("api-controller")]
[ApiController]
public class ApplicationController : ControllerBase
{

    private readonly IMessageService _service;

    public ApplicationController(IMessageService service)
    {
        _service = service;
    }

  
    [HttpPost("send-single-message")]
    public async Task<ActionResult> SendSingleMessage(MessageDto messageDto)
    {
        return Ok(await _service.SingleMessageService(messageDto));
    }

    [HttpPost("send-multiple-messages")]
    public async Task<ActionResult> SendMultipleMessages(List<MessageDto> contacts)
    {
        return Ok(await _service.MultipleMessageService(contacts));
    }
}