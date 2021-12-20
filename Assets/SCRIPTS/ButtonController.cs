using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    public actions type;
    private void OnMouseDown()
    {
        //If I click the button, set the chosen action
        GameManager.gm.player.chosenAction = type;
    }

}
