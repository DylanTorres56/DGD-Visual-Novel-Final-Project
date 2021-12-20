using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : TurnTakerController
{
    // Start is called before the first frame update

    public GameObject choices;
    public actions chosenAction;
    public TurnTakerController chosenTarget;
    
    public override IEnumerator handleTurn() 
    {
        //At the start of my turn, turn on my action choice buttons
        choices.SetActive(true);
        
        //Also reset my chosen action/target
        chosenAction = actions.None;
        chosenTarget = null;
        
        //And give me some UI telling me what to do
        GameManager.gm.readout.text = "Choose your action!";
        while (chosenAction == actions.None)
        {
            //Wait for an action to get chosen
            //This happens in the ActionButton script
            yield return null;
        }
        
        //Update the UI to clear out old buttons and tell me what to do
        GameManager.gm.readout.text = "Choose your target!";
        choices.SetActive(false);
        while (chosenTarget == null)
        {
            //Wait for a target to get clicked on--this happens in EnemyController
            yield return null;
        }
        
        //Okay, we've picked both an action and a target! Do them!
        yield return StartCoroutine(handleTurn(chosenAction, chosenTarget));
    }
}
