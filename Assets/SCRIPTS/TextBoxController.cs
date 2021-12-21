using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextBoxController : MonoBehaviour
{
    public TextMeshProUGUI dialogue;
    public TextMeshProUGUI speaker;
    
    private string thisDialogue;

    public float textTimer;
    public float textTimerMax = .001f;

    public int displayedLetters = 0;

    void Start()
    {
        thisDialogue = dialogue.text;
    }

    void Update()
    {
        textTimer += Time.deltaTime;

        if (textTimer >= textTimerMax) 
        {
            textTimer = 0;
            displayedLetters++;

            if ((displayedLetters < thisDialogue.Length - 1) && thisDialogue.Substring(displayedLetters - 1, 1) == "<" ) 
            {
                Debug.Log("WHILE TEST: " + thisDialogue.Substring(displayedLetters - 1, 1));
                while (thisDialogue.Substring(displayedLetters, 1) != ">") 
                {
                    displayedLetters++;
                }
                displayedLetters++;
            }

            displayedLetters = Mathf.Min(displayedLetters, thisDialogue.Length);
            dialogue.text = thisDialogue.Substring(0, displayedLetters);
        }        
    }

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
        
        thisDialogue = theDialogue;
        displayedLetters = 0;

        if (dL.who != Characters.sameAsBefore) 
        {
            speaker.text = theSpeaker;
        }
    }
}
