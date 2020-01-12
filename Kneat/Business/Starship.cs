using Kneat.Model;
using Kneat.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kneat.Business
{
    class Starship
    {
        public static List<StarshipModel> GetStarshipsAsync() => SwapiService.GetStarshipsAsync().Result;
    }
}
