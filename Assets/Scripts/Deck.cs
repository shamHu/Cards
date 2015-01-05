using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : MonoBehaviour {

	private List<GameObject> deckList = new List<GameObject>();
	public List<GameObject> DeckList
	{
		get { return deckList; }
		set { deckList = value; }
	}

	// Use this for initialization
	void Start () {
		for (int i = 1; i <= 13; i++) {
			for (int j = 0; j < 4; j++) {
				GameObject newCard = (GameObject) Instantiate (Resources.Load("CardPlane"));
				newCard.GetComponent<Card>().CardValue = i;
				newCard.GetComponent<Card>().CardSuit = j;
				newCard.GetComponent<Card>().FaceUp = false;
				newCard.transform.parent = this.transform;

				deckList.Add (newCard);
			}
		}
		this.Shuffle ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Shuffle() {
		List<GameObject> newList = new List<GameObject> ();
		for (int i = 0; i < deckList.Count; i++) {
			newList.Add (null);
		}

		System.Random random = new System.Random ();

		foreach (GameObject card in deckList) {
			int index = random.Next(0, deckList.Count);
			bool placed = false;

			while (!placed) {
				if (newList[index] == null) {

					placed = true;
					newList[index] = card;
				}
				else {
					if (index >= deckList.Count - 1) {
						index = 0;
					}
					else {
						index++;
					}
				}
			}
		}

		deckList = newList;
	}
}
