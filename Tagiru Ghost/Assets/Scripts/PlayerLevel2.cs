using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerLevel2 : MonoBehaviour {
	
	public Image AxeImage;
	public Sprite hasAxeSprite;
	public Sprite hasNoAxeSprite;

	private bool carryingAxe = false;

	//private string hasFireAxeMessage = "NO";

	private PlayerDisplay playerDisplay;
	public Text scoreText;

	public AudioClip magicSound;
	public AudioClip yeaahh;
	public AudioClip scream;

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
		//when the character touches the campfire flame, the life is lost
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
		//load next game level when 5 balls are collected
		if (score == 5) {
			Application.LoadLevel ("scene5_Level2Won");
		}
		//the game is over when there is no lifes left
		if (lives < 0) {
			Application.LoadLevel ("scene8_Level2GameOver");
		}
	}

	public bool IsCarryingAxe() {
		return carryingAxe;
	}
	
	public void ReleaseAxe () {
		carryingAxe = false;
		//update UI display
		AxeImage.sprite = hasNoAxeSprite;
	}
}
