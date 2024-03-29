﻿using Sokoban_2._0_Console.Graphics.Base;
using Sokoban_2._0_Console.Moveables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_2._0_Console.Features
{
    public interface Feature
    {
        FeatureRepresentation Representation{ get; }
        // Interacting with the Moveable object that Gets on any type of feature
        void Interact(Moveable Moveable);

        void Print(string s, int x, int y);

        string GetFeatureString();
    }
}
