
using Microsoft.AspNetCore.Mvc;

namespace sayHello.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{

    public SayHelloController()
    {

    }

    [HttpPost]
    [Route("AddName/{inputName}")]
    public string AddName(string inputName)
    {
        
        return $"Hello! It is very lovely to meet you {inputName}! Have a great day!";

    }

}
