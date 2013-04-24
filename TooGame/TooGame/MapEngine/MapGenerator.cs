using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace TooGame.MapEngine
{
    enum TileType
    {
        SPACE =0,
        OPEN = 1,
        GRASS = 2,
        WATER = 3,
        SAND = 4,
        SNOW = 5,
    }

    class MapGenerator
    {
        private static Random _random = new Random();

        private static TileType[,] _world;
        private static int _width;
        private static int _height;
        private static int _neighbors;
        private static bool _rigid;
        private static int _iterations;
        private static int _openCellProbability;
        private static MapType _mapType;

        public static TileType[,] CreateMap(int width, int height, MapType mapType, int neighbors, bool rigid, int iterations, int probability)
        {
            _width = width;
            _height = height;
            _neighbors = neighbors;
            _rigid = rigid;
            _iterations = iterations;
            _openCellProbability = probability;
            _mapType = mapType;

            Console.Out.WriteLine(" - Starting -");
            long startTime = Stopwatch.GetTimestamp();
            CreateRandomNoiseMap();
            PerformOperations();
            Console.Out.WriteLine("Done : " + (Stopwatch.GetTimestamp() - startTime));
            return GetMap();
        }

        public static void CreateRandomNoiseMap()
        {
            _world = new TileType[_width, _height];
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    TileType state = TileType.SPACE;
                    if(_random.Next(0,100) < _openCellProbability)
                    {
                        state = _mapType.WalkingTile;
                    }
                    _world[i, j] = state;
                }
            }
        }

        public static void PerformOperations()
        {
            for (int i = 0; i < _iterations; i++)
            {
                PerformOperation();
            }
        }

        public static void PerformOperation()
        {
            int x = _random.Next(0, _world.GetLength(0));
            int y = _random.Next(0, _world.GetLength(1));

            TileType replaceType = _mapType.WalkingTile;
            TileType defaultType = TileType.SPACE;

            bool neighborsMet = (CheckNeighbors(x, y, replaceType) > _neighbors);

            if (_rigid)
            {
                TileType temp = replaceType;
                replaceType = defaultType;
                defaultType = temp;
            }
                if (neighborsMet)
                {
                    _world[x, y] = replaceType;
                }
                else
                {
                    _world[x, y] = defaultType;
                }

        }

        public static TileType CheckCell(int x, int y)
        {
            if (x >= 0 && x < _world.GetLength(0) && y >= 0 && y < _world.GetLength(1))
            {
                return _world[x, y];
            }
            else
            {
                return TileType.SPACE;
            }
        }
        
        public static int CheckNeighbors(int x, int y, TileType type)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (CheckCell(x + i, y + j) == type)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static TileType[,] GetMap()
        {
            return _world;
        }

        public static void SetMap(TileType[,] map)
        {
            _world = map;
        }
    }
}
