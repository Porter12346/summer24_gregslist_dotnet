

namespace gregslist_dotnet.Repositories;

public class HousesRepository
{
    private readonly IDbConnection _db;

    public HousesRepository(IDbConnection db)
    {
        _db = db;
    }

    public List<House> GetHouses()
    {
        string sql = "SELECT * FROM houses";


        List<House> houses = _db.Query<House>(sql).ToList();
        return houses;
    }

    internal House CreateHouse(House houseData)
    {
        string sql = @"
        INSERT INTO 
        houses (year, price, color, sqft, stories, imgURL, creatorId)
        VALUES (@year, @price, @color, @sqft, @stories, @imgURL, @creatorId);
        
        SELECT
        houses.*,
        accounts.*
        FROM houses
        JOIN accounts ON accounts.id = houses.creatorId
        WHERE houses.id = LAST_INSERT_ID();";

        House house = _db.Query<House, Profile, House>(sql, (house, account) =>
        {
            house.Creator = account;
            return house;
        }, houseData).FirstOrDefault();
        return house;
    }

    internal House GetHouseById(int houseId)
    {
        string sql = "SELECT * FROM houses WHERE id = @houseId;";

        House house = _db.Query<House>(sql, new { houseId }).FirstOrDefault();
        return house;
    }
}