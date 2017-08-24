using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 5;

	public Text text;

	// Use this for initialization
	void Start () {
		startGame ();
	}

	void startGame(){
		max = 1000;
		min = 1;
		nextGuess();
	}


	public void GuessLower(){
		max = guess;
		nextGuess();
	}

	public void GuessHigher(){
		min = guess;
		nextGuess();
	}

	void nextGuess(){
		guess = Random.Range(min,max+1);
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}
}
