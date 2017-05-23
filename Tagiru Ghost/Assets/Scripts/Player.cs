using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	private PlayerDisplay playerDisplay;
	public Text scoreText;

	public AudioClip yeaahh;
	public AudioClip scream;

	private int score = 0;
	private int lives = 3;
	
	void Start() {

		//get reference to the PlayerDisplay object to update score
		playerDisplay = GetComponent<PlayerDisplay> ();

		playerDisplay.UpdateScoreText(score);
		playerDisplay.UpdateLifesText (lives);
	}

	//collide with the ball and earn points
	void OnTriggerEnter(Collider hit) {
		//when the character touches the campfire flame, the life is lost
		if (hit.CompareTag ("Fire")) {
			lives--;
			playerDisplay.UpdateLifesText (lives);
			audio.PlayOneShot (scream);
		}
		//the soccerball is collected
		if(hit.CompareTag("SoccerBall")) {
			score++;
			playerDisplay.UpdateScoreText(score);
			Destroy(hit.gameObject);
			audio.PlayOneShot(yeaahh);
		}
		//complete the level 1 game when 5 balls are collected
		if (score == 6) {
			Application.LoadLevel ("scene3_Level1Won");
		}
		//the game is over when there is no lifes left
		if (lives < 0) {
			Application.LoadLevel ("scene1_Level1GameOver");
		}
	}
}
