using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTakerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    public virtual IEnumerator handleTurn()
    {
        //Virtual function for handling a character's turn
        yield return null;
    }

    public IEnumerator handleTurn(actions act, TurnTakerController target) 
    {
        if (act == actions.Attack)
        {
            yield return StartCoroutine(attackAction(target));
        }
        if (act == actions.Dance)
        {
            yield return StartCoroutine(danceAction(target));
        }

    }

    public IEnumerator attackAction(TurnTakerController target) 
    {
        GameManager.gm.readout.text = name + " attacks " + target.name + "!";
        
        float speed = 1f;
        while (Vector3.Distance(transform.position, target.transform.position) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
            speed *= 1.1f;
            yield return null;
        }

        while (Vector3.Distance(transform.position, startPos) > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, startPos, 3f * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, startPos, 0.01f);
            yield return null;
        }
        transform.position = startPos;


    }

    public IEnumerator danceAction(TurnTakerController target)
    {
        GameManager.gm.readout.text = name + " dances at " + target.name + "!";
        //The exact code here doesn’t really matter

        float spin = 0;
        while (spin < 360 * 5) 
        {
            transform.rotation = Quaternion.Euler(0, 0, spin);
            spin += 10;
            yield return null;
        }
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}

public enum actions 
{
    None,
    Attack,
    Dance,
}
