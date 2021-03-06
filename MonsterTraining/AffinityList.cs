﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining
{
    public static class AffinityList
    {
        //Elements
        public const int Wind           = 0;
        public const int Water          = 1;
        public const int Fire           = 2;
        public const int Earth          = 3;
        public const int Light          = 4;
        public const int Dark           = 5;

        //Sub-elements
        public const int Wood           = 6;  //Earth + Water
        public const int Lava           = 7;  //Earth + Fire
        public const int Meteor         = 8;  //Earth + Wind    ???
        public const int Metal          = 9;  //Earth + Light
        public const int Oil            = 10; //Earth + Dark    ???

        public const int Steam          = 11; //Water + Fire
        public const int Mist           = 12; //Water + Wind
        public const int Life           = 13; //Water + Light
        public const int Corrosion      = 14; //Water + Dark

        public const int Combustion     = 15; //Fire + Wind     ???
        public const int Plasma         = 16; //Fire + Light
        public const int Consumption    = 17; //Fire + Dark     ???

        public const int Lightning      = 18; //Wind + Light
        public const int Miasma         = 19; //Wind + Dark     ???

        public const int Balance        = 20; //Light + Dark
        
        //stats    
        public const int Strength       = 21;
        public const int Vitality       = 22;
        public const int Dexterity      = 23;
        public const int Agility        = 24;
        public const int Mind           = 25;
        public const int Perception     = 26;
            

        //Number of fields in this class
        public const int ArrayLength    = 27;


    }
}
