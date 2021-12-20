using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRenderController : MonoBehaviour
{
    public SpriteRenderer sr;

    public Sprite beckonSprite;
    public Sprite c1;
    public Sprite c2;
    public Sprite c3;
    public Sprite c4;
    public Sprite c5;

    public void Imprint(textDialogueLine dL)
    {
        if (dL.who == Characters.None) 
        {
            sr.sprite = null;
        }
        if (dL.who == Characters.Beckon)
        {
            sr.sprite = beckonSprite;
        }
        if (dL.who == Characters.UNDECLARED_30)
        {
            sr.sprite = c1;
        }
        if (dL.who == Characters.UNDECLARED_31)
        {
            sr.sprite = c2;
        }
        if (dL.who == Characters.UNDECLARED_30_AND_UNDECLARED_31)
        {
            sr.sprite = c3;
        }
        if (dL.who == Characters.Dr_S_Ovid)
        {
            sr.sprite = c4;
        }
        if (dL.who == Characters.Centri)
        {
            sr.sprite = c5;
        }

    }
}
