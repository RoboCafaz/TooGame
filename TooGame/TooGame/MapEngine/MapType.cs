using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TooGame.MapEngine
{
    class MapType
    {
        private String _name;
        private TileType _walkingTile;
        private TileType _commonHazard;
        private TileType _uncommonHazard;
        private TileType _rareHazard;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public TileType WalkingTile
        {
            get { return _walkingTile; }
            set { _walkingTile = value; }
        }

        public TileType CommonHazard
        {
            get { return _commonHazard; }
            set { _commonHazard = value; }
        }

        public TileType UncommonHazard
        {
            get { return _uncommonHazard; }
            set { _uncommonHazard = value; }
        }

        public TileType RareHazard
        {
            get { return _rareHazard; }
            set { _rareHazard = value; }
        }

        public MapType(string name, TileType walkingTile, TileType commonHazard, TileType uncommonHazard, TileType rareHazard)
        {
            _name = name;
            _walkingTile = walkingTile;
            _commonHazard = commonHazard;
            _uncommonHazard = uncommonHazard;
            _rareHazard = rareHazard;
        }

        private static Dictionary<String, MapType> _mapTypes = new Dictionary<string,MapType>();

        public static Dictionary<String, MapType> MapTypes
        {
            get { return MapType._mapTypes; }
            set { MapType._mapTypes = value; }
        }

        public static void Initialize()
        {
            MapTypes.Add("Grass", new MapType("Grass", TileType.GRASS, 0, 0, 0));
            MapTypes.Add("Snow", new MapType("Snow", TileType.SNOW, 0, 0, 0));
        }
    }
}
