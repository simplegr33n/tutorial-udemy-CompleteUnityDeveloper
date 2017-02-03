using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    int remaining = 10;
	int max = 1000;
	int min = 1;
	int guess;
	string gameIs;

    public Text GuessText;
    public Text AdvanceText;
    public Text HigherText;
    public Text LowerText;
    public Text RemainingText;

    // Use this for initialization
    void Start () {
		StartGame();
	}

	
	// Update is called once per frame
	void Update () {
		
		if (gameIs.Equals("live") && Input.GetKeyDown(KeyCode.UpArrow)) {

            GuessHigher();

			
		} else if (gameIs.Equals("live") && Input.GetKeyDown(KeyCode.DownArrow)) {

            GuessLower();
			
		} else if (gameIs.Equals("live") && Input.GetKeyDown(KeyCode.Return)) {

            GuessText.text = "Number Wizard Wins with " + guess + "!";

            RemainingText.text = "";

            AdvanceText.text = "Space to Continue";
            HigherText.text = "";
            LowerText.text = "";

            gameIs = "over";
		}

        if (gameIs.Equals("start") && Input.GetKeyDown(KeyCode.Space)) { 
            NextGuess();
        }

        if (gameIs.Equals("over") && Input.GetKeyDown(KeyCode.Space)) {
			StartGame();
		}
	}

    public void GuessHigher() {
        min = guess;
        NextGuess();
    }

    public void GuessLower() {
        max = guess;
        NextGuess();

    }



    void StartGame() {
        remaining = 10;
		min = 1;
		max = 1000;
     
		gameIs = "start";

        GuessText.text = "Pick a number in your head,\nbut don't tell Number Wizard!";
        AdvanceText.text = "Space to Continue";
        HigherText.text = "";
        LowerText.text = "";

        // Not sure why the below still..
        // Otherwise gets to a max top figure of 999 because of rounding
        // TODO: findout
		
	}
	
	
	void NextGuess() {
        gameIs = "live";

        guess = Random.Range(min, max+1);

        remaining -= 1;

        if (remaining >= 0) { 

            GuessText.text = "Is the number " + guess + "?";
            AdvanceText.text = "Correct!\n(Return)";
            HigherText.text = "Higher\n(Up)";
            LowerText.text = "Lower\n(Down)";
            RemainingText.text = remaining + " Guesses Remaining";
        } else {
            GuessText.text = "Number Wizard Loses... !";

            RemainingText.text = "";

            AdvanceText.text = "Space to Continue";
            HigherText.text = "";
            LowerText.text = "";

            gameIs = "over";

        }

    }
}
