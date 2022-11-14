using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Dice Class
public class Dice
{
	public int sides;
	public int rollValue;
	//the side of each dice
	public Dice(int sides)
	{
		this.sides =sides;
	}
	//generate a random number from the sides
	public void Roll(){
		rollValue = UnityEngine.Random.Range(1,sides+1);
	}
}
//A list of dice for our game
public class DiceRoll
{
	public List<Dice> dice;

	public DiceRoll()
	{
		dice = new List<Dice>();
	}

	public void AddDice(int sides)
	{
		dice.Add(new Dice(sides));
	}
	//Roll all dice in the list
	public void Roll()
	{
		for (int i=0; i<dice.Count; i++)
		{
			dice[i].Roll();
		}
	}
	//calculate the total value of dice
	public int TotalValue()
	{
		int v=0;
		for(int i =0; i<dice.Count;i++){
			v+=dice[i].rollValue;
		}
		return v;
	}
}