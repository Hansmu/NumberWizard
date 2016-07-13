using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	private int max;
	private int min;
	private int guess;

	// Use this for initialization
	void Start () {
		StartGame();
    }
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.UpArrow)) {
	        min = guess;
			NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            print("I won!");
			StartGame();
        }
	}

	void StartGame() {
		max = 1000;
		min = 1;
		guess = 500;

		print("Welcome to Number Wizard!");
		print("Pick a number in your head, but don't tell me!");

		print("The highest number you can pick is: " + max);
		print("The highest number you can pick is: " + min);

		print("Is the number higher or lower than " + guess + "?");
		print("Up arrow for higher, down for lower, return for equal");

		max++;
	}

	void NextGuess() {
		print("Higher or lower than " + guess);
		guess = (max + min) / 2;
		print("Up arrow for higher, down for lower, return for equal");
	}
}
