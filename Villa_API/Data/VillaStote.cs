using Villa_API.Models.Villa.DTO;

namespace Villa_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>()
        {
            new VillaDTO { Id = 1, Name = "Вилла 1", Occupancy = 4, Sqft = 100 },
            new VillaDTO { Id = 2, Name = "Вилла 2", Occupancy = 3, Sqft = 300 }
        };
    }
}
