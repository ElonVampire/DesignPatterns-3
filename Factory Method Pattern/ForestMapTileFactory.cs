using System;
using System.Collections.Generic;
using System.Reflection;

namespace Factory_Pattern
{
    public class ForestMapTileFactory : IMapTileFactory
    {
        public IWorldTile CreateWorldTile()
        {
            return new ForestTile();
        }
    }
}