using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	public Text happened;
	
	int room = 1;
	bool sweep;
	bool pagoda;
	bool dragon;

	// Use this for initialization
	void Start () {
		
		text.text = "!";
		
		SetScene();
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(room == 1) {
			RoomOne ();
		}
		
		if(room == 2) {
			RoomTwo ();
		}
		
		if(room == 3) {
			RoomThree();
		}
	
	}
	
	
	void RoomOne() {
	
		if (Input.GetKeyDown(KeyCode.D) && (sweep == false)) {
			happened.text = "The dog gives you a sweep";
			sweep = true;
			SetScene ();
		} else if (Input.GetKeyDown(KeyCode.D) && (sweep == true)) {
			happened.text = "Ruff Ruff!";
			SetScene ();
		}
		
		if (Input.GetKeyDown(KeyCode.P)) {
			happened.text = "Ouch!";
			SetScene ();
		}
		
		if (Input.GetKeyDown(KeyCode.E)) {
			happened.text = "You died...";
			sweep = false;
			pagoda = false;
			dragon = false;
			room = 1;
			SetScene ();
		}
		
		if (Input.GetKeyDown(KeyCode.S) && (sweep = true)) {
			happened.text = "Sweepout!";
			room = 2;
			SetScene ();
		}
		
	}
	
	void RoomTwo() {
	
		if (Input.GetKeyDown(KeyCode.C) && (pagoda == false)) {
			happened.text = "The cat gives you a pagoda";
			pagoda = true;
			SetScene ();
			
		} else if (Input.GetKeyDown(KeyCode.C) && (pagoda ==true)) {
			happened.text = "Reow!";
			SetScene ();
		}
		
		
		if (Input.GetKeyDown(KeyCode.P) && (sweep == true)) {
			happened.text = "Ouch!";
			SetScene ();
		}
		
		if (Input.GetKeyDown(KeyCode.B)) {
			happened.text = "Back down the chimney then";
			room = 1;
			SetScene ();
		}
		
		if (Input.GetKeyDown(KeyCode.P) && (pagoda == true)) {
			happened.text = "Pagoda Pose!";
			room = 3;
			SetScene ();
		}
	
	}
	
	
	void RoomThree() {
	
		if (dragon == false && Input.GetKeyDown(KeyCode.F)) {
			happened.text = "Aww yeah!!";
			dragon = true; 
			SetScene ();
		}
		
		if (dragon == false && Input.GetKeyDown(KeyCode.D)) {
			happened.text = "lol";
			sweep = false;
			pagoda = false;
			dragon = false;
			room = 1;
			SetScene ();
		}
	
	}
	
	void SetScene() {
		switch(room) {
			case 1:
				if (sweep == true) {
					text.text = "Sweep Up Outta Here?\n\n[S] Sweep on Up\n[D] Talk to that Dog again\n[E] to Eat Mushroom";
					
				} else if (sweep == false) {
					text.text = "Awake in a strange place...\n\n[P] to Pinch Self\n[D] Talk to that Dog\n[E] to Eat Mushroom";
				}
				
				break;
				
			case 2:
				if (pagoda == true) {
					text.text = "Pagoda Pose Away?\n\n[P] Pure Pagodes\n[C] Talk to that Cat again\n[B] Back to Room";
			
				
				} else if (pagoda == false) {
					text.text = "There's a cat on that ledge...\n\n[P] to Pinch Self\n[C] Talk to that Cat\n[B] Back to Room";
				
				}
			
				break;
				
			case 3:
				if (dragon == true) {
					text.text = "You win already!";
				} else if (dragon == false) { 
					text.text = "[F] Follow the Meditation Dragon to the\nheart of your prejudice and desire? \n[D] Don't do that.";
				}
				
				break;
		
		}
	}
}
