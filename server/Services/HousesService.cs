

namespace gregslist_dotnet.Services;


public class HousesService
{
    private readonly HousesRepository _housesRepository;

    public HousesService(HousesRepository housesRepository)
    {
        _housesRepository = housesRepository;
    }

    public List<House> GetHouses()
    {
        List<House> houses = _housesRepository.GetHouses();
        return houses;
    }

    internal House CreateHouse(House houseData)
    {
        House house = _housesRepository.CreateHouse(houseData);
        return house;
    }

    internal House GetHouseById(int houseId)
    {
        House houses = _housesRepository.GetHouseById(houseId);
        return houses;
    }
}