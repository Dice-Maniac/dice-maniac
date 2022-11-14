using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDice4 : MonoBehaviour
{
    public RollTest script;
    public gamecontrol script2;
    public GameObject Image;
    public GameObject Image2;
    public GameObject Image3;
    public GameObject Image4;
    // Select the point of dice 3 as move point (update the moveLimit)
    public void UpdateMovePoints4()
    {
        script2.moveLimit = script.diceRoll.dice[3].rollValue;
        Image.SetActive(false);
        Image2.SetActive(false);
        Image3.SetActive(false);
        Image4.SetActive(false);
    }
}
