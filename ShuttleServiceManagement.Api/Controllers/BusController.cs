﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShuttleServiceManagement.Api.Requests;
using ShuttleServiceManagement.Application.Commands.BusCommands.CreateBus;
using ShuttleServiceManagement.Domain.Shared;

namespace ShuttleServiceManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly ISender _sender;

        public BusController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateBus(CreateBusRequest request, CancellationToken cancellationToken)
        {
            var command = new CreateBusCommand(request.DriverName, request.Capacity);
            Result<Guid> result = await _sender.Send(command, cancellationToken);
            if (result.IsSuccess)
                return Ok(result.Value);
            return BadRequest(result.Error.Message);
        }
    }
}
