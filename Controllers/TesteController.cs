using Microsoft.AspNetCore.Mvc;
using System;

[ApiController]
[Route("teste")]
public class TesteController : ControllerBase
{
    [HttpGet]
    public string Teste()
    {
        return "Olá Mundo";
    }

}
