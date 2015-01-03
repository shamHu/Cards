using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour{

	[SerializeField]
	private int cardValue;
	public int CardValue
	{
		get { return cardValue; }
		set { cardValue = value; }
	}

	[SerializeField]
	private int cardSuit;
	public int CardSuit
	{
		get { return cardSuit; }
		set { cardSuit = value; }
	}

	[SerializeField]
	private bool faceUp;
	public bool FaceUp
	{
		get { return faceUp; }
		set { faceUp = value; }
	}

	public Card(int value, int suit, bool faceUp)
	{
		this.cardValue = value;
		this.cardSuit = suit;
		this.faceUp = faceUp;
	}


}
