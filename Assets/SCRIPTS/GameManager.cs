using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;

    public TextMeshProUGUI readout;

    public List<TurnTakerController> everyCharacter;
    public List<TurnTakerController> pendingTurns;
    public PlayerController player;

    private void Start()
    {
        NextTurn();
    }

    private void Awake()
    {
        gm = this;
    }

    public void NextTurn() 
    {
        if (pendingTurns.Count == 0) 
        {
            pendingTurns.AddRange(everyCharacter);
        }
        TurnTakerController next = pendingTurns[0];
        StartCoroutine(routine:RunTurn(next));
    }

    public IEnumerator RunTurn(TurnTakerController upNext) 
    {
        pendingTurns.Remove(upNext);
        Debug.Log("It's " + upNext.name + "'s Turn!");
        yield return StartCoroutine(routine: upNext.handleTurn());
        NextTurn();
    }
}
