using System;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class BuggyController : BaseApiController
{
    [HttpGet("auth")]
    public ActionResult GetAuth()
    {
        return Unauthorized("You are not authorized");
    }

    [HttpGet("not-found")]
    public ActionResult GetNotFound()
    {
        return NotFound("Resource not found");
    }

    [HttpGet("server-error")]
    public ActionResult GetServerError()
    {
        throw new Exception("This is a server error");
    }

    [HttpGet("bad-request")]
    public ActionResult GetBadRequest()
    {
        return BadRequest("This was not a good request");
    }
}
