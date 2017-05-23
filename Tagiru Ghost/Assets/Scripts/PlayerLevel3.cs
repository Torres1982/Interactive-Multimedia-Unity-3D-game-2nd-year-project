using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerLevel3 : MonoBehaviour {
	
	public Image AxeImage;
	public Sprite hasAxeSprite;
	public Sprite hasNoAxeSprite;

	private bool carryingAxe = false;

	//private string hasFireAxeMessage = "NO";

	private PlayerDisplay playerDisplay;
	public Text scoreText;
	public Text lifesText;

	public AudioClip magicSound;
	public AudioClip yeaahh;
	public AudioClip bomb;
	public AudioClip scream;
	public AudioClip stab;
	
	private int score = 0;
	private int lives = 3;

	/*void Update () {
		string fireAxeMessage = "Do I have a Fire Axe to destroy a Stone Gate? - " + hasFireAxeMessage;
		print(fireAxeMessage);
	}*/

	void Start () {
		//get reference to the PlayerDisplay object to update score
		playerDisplay = GetComponent<PlayerDisplay> ();

		playerDisplay.UpdateScoreText (score);
		playerDisplay.UpdateLifesText (lives);
	}

	//collide with the ball and earn points
	void OnTriggerEnter (Collider hit) {
		//collect an axe
		if(hit.CompareTag ("FireAxe")) {
			//hasFireAxeMessage = "YES";
			Destroy (hit.gameObject);
			audio.PlayOneShot (magicSound);
			carryingAxe = true;
			//update UI display
			AxeImage.sprite = hasAxeSprite;
		}
		//whrn the character touches the campfire flame, the life is lost
		if (hit.CompareTag ("Fire")) {
			lives--;
			playerDisplay.UpdateLifesText (lives);
			audio.PlayOneShot (scream);
		}
		//collect the balls
		if(hit.CompareTag("SoccerBall")) {
			score++;
			playerDisplay.UpdateScoreText (score);
			Destroy (hit.gameObject);
			audio.PlayOneShot (yeaahh);
		}
		//the game is won when 5 soccerballs are collected
		if (score == 5) {
			Application.LoadLevel ("scene7_Level3Won");
		}
		//when the player hit the Mine it loses the life
		if (hit.CompareTag("Mine")) {
			Destroy (hit.gameObject);
			audio.PlayOneShot (bomb);
			LoseLife ();		
		}
		//when the player hits the Tagiru enemy, the life is lost
		if (hit.CompareTag ("Tagiru")) {
			audio.PlayOneShot (stab);
			LoseLife ();	
		}
		//the game is over when there is no lifes left
		if (lives < 0) {
			Application.LoadLevel ("scene9_Level3GameOver");		
		}
	}

	//whe the life is lost, update the life text and respawn the player
	private void LoseLife () {
		lives--;
		playerDisplay.UpdateLifesText (lives);
		MoveToStartPosition ();
	}

	//move the character to the starting position
	private void MoveToStartPosition () {
		Vector3 startPosition = new Vector3 (-18, 5, -20);
		transform.position = startPosition;
	}

	//the axe image is displayed to the screen
	public bool IsCarryingAxe() {
		return carryingAxe;
	}

	//drop the axe (default no-axe image is displayed)
	public void ReleaseAxe () {
		carryingAxe = false;
		//update UI display
		AxeImage.sprite = hasNoAxeSprite;
	}
}
