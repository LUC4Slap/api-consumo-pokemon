using Microsoft.AspNetCore.Mvc;

namespace apiPoke.Controllers;

[ApiController]
[Route("[controller]")]
public class TesteController: ControllerBase {
    
    [HttpGet(Name = "Teste")]
    public static string Teste()
    {
        return "TESTE FUNCIONANDO";
    }
}