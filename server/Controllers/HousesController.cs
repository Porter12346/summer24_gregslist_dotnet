namespace gregslist_dotnet.Controllers;

[ApiController]
[Route("api/[controller]")]

public class housesController : ControllerBase
{
    private readonly HouseService _housesService;

    private readonly Auth0Provider _auth0Provider;

    public HousesController(housesController housesController, Auth0Provider auth0Provider){
        _housesService = _housesService;
        _auth0Provider = auth0Provider;
    }

    [HttpGet]

    public ActionResult<List<House>>
}
