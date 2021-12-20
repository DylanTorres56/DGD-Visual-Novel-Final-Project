using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public SpriteRenderer sr;

    public Sprite openingScreen; 
    public Sprite surroundingWoodland_PartsUnknown1; 
    public Sprite ovidsManor_Exterior1; 
    public Sprite ovidsManor_InteriorFirstFloor1_unlit;
    public Sprite ovidsManor_InteriorFirstFloor1; 
    public Sprite ovidsManor_InteriorFirstFloor2;
    public Sprite ovidsManor_InteriorFirstFloor3;
    public Sprite ovidsManor_InteriorFirstFloor1_Smoked;
    public Sprite ovidsManor_Exterior2; 
    public Sprite surroundingWoodland_PartsUnknown2; 
    public Sprite surroundingWoodland_ThroatOfTheForest;
    public Sprite endScreen;
    public Sprite blackBG;

    public void Imprint(textDialogueLine dL)
    {
        if (dL.where == Locations.OpeningScreen) 
        {
            sr.sprite = openingScreen;
        }

        if (dL.where == Locations.SurroundingWoodland_PartsUnknown1)
        {
            sr.sprite = surroundingWoodland_PartsUnknown1;
        }

        if (dL.where == Locations.OvidsManor_Exterior)
        {
            sr.sprite = ovidsManor_Exterior1;
        }

        if (dL.where == Locations.OvidsManor_InteriorFirstFloor1_unlit)
        {
            sr.sprite = ovidsManor_InteriorFirstFloor1_unlit;
        }

        if (dL.where == Locations.OvidsManor_InteriorFirstFloor1)
        {
            sr.sprite = ovidsManor_InteriorFirstFloor1;
        }

        if (dL.where == Locations.OvidsManor_InteriorFirstFloor2)
        {
            sr.sprite = ovidsManor_InteriorFirstFloor2;
        }

        if (dL.where == Locations.OvidsManor_InteriorFirstFloor3)
        {
            sr.sprite = ovidsManor_InteriorFirstFloor3;
        }

        if (dL.where == Locations.OvidsManor_InteriorFirstFloor1_Smoked)
        {
            sr.sprite = ovidsManor_InteriorFirstFloor1_Smoked;
        }
        
        if (dL.where == Locations.OvidsManor_Exterior2)
        {
            sr.sprite = ovidsManor_Exterior2;
        }

        if (dL.where == Locations.SurroundingWoodland_PartsUnknown2)
        {
            sr.sprite = surroundingWoodland_PartsUnknown2;
        }

        if (dL.where == Locations.SurroundingWoodland_ThroatOfTheForest)
        {
            sr.sprite = surroundingWoodland_ThroatOfTheForest;
        }

        if (dL.where == Locations.EndScreen)
        {
            sr.sprite = endScreen;
        }

        if (dL.where == Locations.None)
        {
            sr.sprite = blackBG;
        }
    }
}
