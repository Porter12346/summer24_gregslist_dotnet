
namespace gregslist_dotnet.Models;

public class House
{
    public int? Id { get; set; }

    public int? price { get; set; }

    public int? year { get; set; }

    public string color { get; set; }

    public int? sqft { get; set; }

    public int? stories { get; set; }

    public string imgUrl { get; set; }

    public string CreatorId { get; set; }

    public Profile Creator { get; set; }
}