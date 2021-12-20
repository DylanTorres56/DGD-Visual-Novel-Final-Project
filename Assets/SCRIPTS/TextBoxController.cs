using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBoxController : MonoBehaviour
{
    public TextMeshProUGUI dialogue;
    public TextMeshProUGUI speaker;

    public void Imprint(textDialogueLine dL) 
    {
        Debug.Log("Imprint!");
        string theSpeaker = dL.who.ToString();

        if (dL.who == Characters.None) 
        {
            theSpeaker = "Narrator";
        }

        if (dL.who == Characters.UNDECLARED_30_AND_UNDECLARED_31)
        {
            theSpeaker = "The UNDECLAREDs";
        }

        if (dL.who == Characters.Dr_S_Ovid)
        {
            theSpeaker = "Dr. S. Ovid";
        }

        string theDialogue = dL.text;

        if (dL.nextB > 0) 
        {
            theDialogue += "\n 1)" + dL.choiceA;
            theDialogue += "\n 2)" + dL.choiceB;
        }
        dialogue.text = theDialogue;

        if (dL.who != Characters.sameAsBefore) 
        {
            speaker.text = theSpeaker;
        }
    }
}
