using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace DesignPatternBL.CreationalDesignPatterns
{
    public interface IHouseBuilder
    {
        void BuildWalls(int counter);
        void BuildDoors(int counter);
        void BuildWindows(int counter);
        void BuildRoof(int counter);
        void BuildGarage(bool buildGarage);
    }
    public class House{
        private List<object> wallList = new List<object>();
        private List<object> windowList = new List<object>();
        private List<object> roofList = new List<object>();
        private List<object> doorList = new List<object>();
        private bool hasGrage;

        public void AddWalls(string wall)
        {
            this.wallList.Add(wall);
        }
        public void AddWindows(string window)
        {
            this.windowList.Add(window);
        }
        public void AddRoofs(string roof)
        {
            this.roofList.Add(roof);
        }
        public void AddDoors(string door)
        {
            this.doorList.Add(door);
        }

        public void AddGarage(bool addGarage)
        {
            hasGrage = addGarage;
        }

        public string HouseInfo()
        {
            return $"House has {wallList.Capacity} walls, {windowList.Count} windows, {roofList.Count} roofs, has garage: {hasGrage}";
        }

    }
    public class HouseBuilder : IHouseBuilder
    {
        private House _houses = new House();

        public HouseBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._houses = new House();
        }
        public void BuildWalls(int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                _houses.AddWalls($"Wall #{i + 1}");
            }
        }

        public void BuildDoors(int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                _houses.AddDoors($"Door #{i + 1}");
            }
        }

        public void BuildWindows(int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                _houses.AddWindows($"Window #{i + 1}");
            }
        }

        public void BuildRoof(int counter)
        {
            for (int i = 0; i < counter; i++)
            {
                _houses.AddRoofs($"Roof #{i + 1}");
            }
        }
        public void BuildGarage(bool buildGarage)
        {
            _houses.AddGarage(buildGarage);
        }

        public House GetHouse()
        {
            House builtHouse = this._houses;
            this.Reset();
            return builtHouse;
        }
    }

    public class Director
    {
        private IHouseBuilder _builder;

        public IHouseBuilder Builder
        {
            set { _builder = value; }
        }

        public void buildHugeHouse()
        {
            this._builder.BuildDoors(2);
            this._builder.BuildRoof(3);
            this._builder.BuildWindows(14);
            this._builder.BuildWalls(8);
            this._builder.BuildGarage(true);
        }
        public void buildSmallHouse()
        {
            this._builder.BuildDoors(1);
            this._builder.BuildRoof(1);
            this._builder.BuildWindows(5);
            this._builder.BuildWalls(4);
            this._builder.BuildGarage(false);
        }

    }

}
