﻿namespace MegaDesk2_TeamEternal
{
    class Desk
    {
        // Const Values
        public const float MinWidth = 24;
        public const float MaxWidth = 96;
        public const float MinDepth = 12;
        public const float MaxDepth = 48;
        public const float BaseDeskPrice = 200;
        
        // Getter and setter
        public float Width { get; set; }
        public float Depth { get; set; }
        public float NumOfDrawers { get; set; }
        public string DeskType { get; set; }
        public string RushDays { get; set; }

    }

    public enum NumOfDrawers: int
    {
        Zero = 0,
        One = 1, 
        Two = 2, 
        Three = 3, 
        Four = 4, 
        Five = 5, 
        Six = 6, 
        Seven = 7   
    }

    enum DeskType
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    enum RushDays: int
    {
        Fourteen = 14,
        Three = 3,
        Five = 5,
        Seven = 7
    }

    enum MegaConst: int
    {
        MinWidth = 23,
        MaxWidth = 97,
        MinDepth = 11,
        MaxDepth = 49,
        BaseDeskPrice = 200,
        BaseDeskSize = 1000,
        DrawerPrice = 50,
        OakPrice = 200,
        LaminatePrice = 100,
        PinePrice = 50,
        RosewoodPrice = 300,
        VeneerPrice = 125,
    }
}
