using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess = 500;
	string gameIs;


	// Use this for initialization
	void Start () {
		StartGame();
	}

	
	// Update is called once per frame
	void Update () {
		
		if (!gameIs.Equals("over") && Input.GetKeyDown(KeyCode.UpArrow)) {
			print ("Up Arrow Pressed");
			
			min = guess;
			NextGuess();

			
		} else if (!gameIs.Equals("over") && Input.GetKeyDown(KeyCode.DownArrow)) {
			print ("Down Arrow Pressed");
			
			max = guess;
			NextGuess();
			
		} else if (!gameIs.Equals("over") && Input.GetKeyDown(KeyCode.Return)) {
			print ("Number Wizard Wins!");
			print ("Press Space for New Game!");
			
			gameIs = "over";
		}
		
		if (gameIs.Equals("over") && Input.GetKeyDown(KeyCode.Space)) {
			StartGame();
		}
	}
	
	
	void StartGame() {
		min = 1;
		max = 1000;
		guess = 500;
		gameIs = "live";
	
		print ("=========================");
		print ("Welcome to Number Wizard!");
		print ("Pick a number in your head,\nbut don't tell Number Wizard!");
		print ("The Highest number you can pick is " + max + ",\nthe Lowest is " + min);
		print ("=========================");
		
		print ("Is the number Higher or Lower than " + guess +"?");
		print ("Up = Higher, Down = Lower, Enter = Equal");
		
		
		// Not sure why the below still..
		// Otherwise gets to a max top figure of 999 because of rounding
		// TODO: findout
		max += 1;
		
	}
	
	
	void NextGuess() {
		guess = (max + min) / 2;
		print ("Is the number Higher or Lower than " + guess +"?");
		print ("Up = Higher, Down = Lower, Enter = Equal");
	}
}
