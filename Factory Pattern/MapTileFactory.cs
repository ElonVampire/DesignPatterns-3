using System;
using System.Collections.Generic;
using System.Reflection;

namespace Factory_Pattern
{
    public class MapTileFactory
    {
        Dictionary<string, Type> mapTiles;

        public MapTileFactory()
        {
            LoadTypesICanReturn();
        }

        private void LoadTypesICanReturn()
        {
            mapTiles = new Dictionary<string, Type>();

            Type[] typesInAssembly = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type type in typesInAssembly)
            {
                if(type.GetInterface(typeof(IWorldTile).ToString()) != null)
                {
                    mapTiles.Add(type.Name.ToLower(), type);
                }
            }

        }

        public IWorldTile CreateInstance(string command)
        {
            Type myType = GetTypeToCreate(command);
            if(myType == null)
            {
                return new NullTile();
            }
            return Activator.CreateInstance(myType) as IWorldTile;
        }

        private Type GetTypeToCreate(string command)
        {
            foreach (var tile in mapTiles)
            {
                if (tile.Key.Contains(command))
                {
                    return mapTiles[tile.Key];
                }
            }
            return null;
        }


    }
}