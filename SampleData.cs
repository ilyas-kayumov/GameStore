using System.Collections.Generic;
using GameStore.Models;

namespace GameStore
{
    public class SampleData
    {
        public static IEnumerable<Game> GetGames()
        {
            yield return new Game()
            {
                Name = "Red Dead Redemption 2",
                Year = 2018,
                Platform = "PlayStation 4",
                Genre = "Action",
                Developer = "Rockstar Studios",
                Publisher = "Rockstar Games",
                Price = 59
            };

            yield return new Game()
            {
                Name = "Resident Evil 2",
                Year = 2019,
                Platform = "Microsoft Windows",
                Genre = "Horror",
                Developer = "Capcom",
                Publisher = "Capcom",
                Price = 39
            };
        }
    }
}