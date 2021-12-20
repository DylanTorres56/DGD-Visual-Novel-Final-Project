using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public struct textDialogueLine 
    {
        public int id;
        public string text;
        public Characters who;
        public Locations where;
        public int next;
        public int nextB;
        public string choiceA;
        public string choiceB;

        public textDialogueLine(int thisID, string thisText, int theNext, Characters theWho = Characters.sameAsBefore, Locations theWhere = Locations.None) 
        {
            id = thisID;
            text = thisText;
            next = theNext;
            nextB = 0;
            who = theWho;
            where = theWhere;
            choiceA = "";
            choiceB = "";
        }

        public textDialogueLine(int thisID, string thisText, string choice1, int theNext, string choice2, int theNextB, Characters theWho = Characters.sameAsBefore, Locations theWhere = Locations.None)
        {
            id = thisID;
            text = thisText;
            next = theNext;
            nextB = theNextB;
            who = theWho;
            where = theWhere;
            choiceA = choice1;
            choiceB = choice2;
        }

    }

public enum Characters 
{
    None,
    sameAsBefore,
    Beckon,
    UNDECLARED_30,
    UNDECLARED_31,
    UNDECLARED_30_AND_UNDECLARED_31,
    Dr_S_Ovid,
    Centri
}

public enum Locations
{
    None,
    OpeningScreen,
    SurroundingWoodland_PartsUnknown1,
    OvidsManor_Exterior,
    OvidsManor_InteriorFirstFloor1_unlit,
    OvidsManor_InteriorFirstFloor1,
    OvidsManor_InteriorFirstFloor2,
    OvidsManor_InteriorFirstFloor3,
    OvidsManor_InteriorFirstFloor1_Smoked,
    OvidsManor_Exterior2,
    SurroundingWoodland_PartsUnknown2,
    SurroundingWoodland_ThroatOfTheForest,
    EndScreen,
}