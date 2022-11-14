using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
//Roll dice function 
public class RollTest : MonoBehaviour
{
	[SerializeField] List<TextMeshProUGUI> texts;
	[SerializeField] TextMeshProUGUI totalValue;
	public DiceRoll diceRoll;
	public gamecontrol script;
	//Create four dice with 6 faces
	private void Start()
	{
		diceRoll = new DiceRoll();
		for (int i =0; i<5; i++){
			diceRoll.AddDice(6);
		}
		diceRoll.AddDice(6);
	}
	//Roll the dice if roll limit is 0 (each turn has only one roll chance)
	public void Roll()
	{
		if (script.rollLimit == 0)
		{
			diceRoll.Roll();
			UpdateText();
			script.rollLimit = 1;
		}	
	}
	//update the dice with a random number from 1-6
	private void UpdateText()
	{
		for (int i=0; i<texts.Count; i++)
		{
			if(i<diceRoll.dice.Count)
			{
				texts[i].text = diceRoll.dice[i].rollValue.ToString();
			}
		}
	}
}
