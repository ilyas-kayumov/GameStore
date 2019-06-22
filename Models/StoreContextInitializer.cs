using System;
using System.Linq;
using GameStore.Models;
using Microsoft.Extensions.Logging;

namespace GameStore
{
    public class StoreContextInitializer
    {
        private readonly ILogger logger;
        private StoreContext context;

        private bool Initialized
        {
            get
            {
                return context.Games.Any();
            }
        }

        public StoreContextInitializer(ILogger logger)
        {
            this.logger = logger;
        }

        public void Initialize(StoreContext context)
        {
            this.context = context;

            try
            {
                if (!Initialized)
                {
                    AddSampleGames();
                }
            }
            catch (Exception e)
            {
                logger.LogError(e, "An error occurred while seeding the database.");
            }
        }

        private void AddSampleGames()
        {
            var games = SampleData.GetGames();
            context.Games.AddRange(games);
            context.SaveChanges();
        }
    }
}