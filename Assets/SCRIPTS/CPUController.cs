using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUController : TurnTakerController
{
    // Start is called before the first frame update
    public override IEnumerator handleTurn()
    {
        //This is some real simple AI--just always attack
        //Decide what you want to do and who to target, then run HandleAction
        yield return StartCoroutine(handleTurn(actions.Attack, GameManager.gm.player));
    }
     private void OnMouseDown()
     {
         //If I get clicked on, tell the player
         //Make sure my GameObject has a collider, so this can get called
         GameManager.gm.player.chosenTarget = this;
     }    

}
