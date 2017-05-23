using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerDisplay : MonoBehaviour {

	public Text scoreText;
	public Text livesText;
	
	// Update the score once the ball is collected
	public void UpdateScoreText(int newScore) {
	
		string scoreMessage = "Score = " + newScore;
		scoreText.text = scoreMessage;
	}

	//Update the lives
	public void UpdateLifesText(int newLives) {

		string livesMessage = "Lives = " + newLives;
		livesText.text = livesMessage;
	}
}
