using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class RollTest : MonoBehaviour
{
	[SerializeField] List<TextMeshProUGUI> texts;
	[SerializeField] TextMeshProUGUI totalValue;
	public DiceRoll diceRoll;
	public gamecontrol script;
	private void Start()
	{
		diceRoll = new DiceRoll();
		for (int i =0; i<5; i++){
			diceRoll.AddDice(6);
		}
		diceRoll.AddDice(6);
	}
	public void Roll()
	{
		if (script.rollLimit == 0)
		{
			diceRoll.Roll();
			UpdateText();
			script.rollLimit = 1;
		}	
	}
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
