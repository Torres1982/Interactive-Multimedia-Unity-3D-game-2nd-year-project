using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(CountdownTimer))]
public class GameManagerLevel3 : MonoBehaviour {

	//Text Object reference
	public Text timerText;
	public Slider timeSlider;

	//Declare global variables
	public int time = 180;
	private CountdownTimer timer;

	//Restart the timer at the start of the game
	void Start () {

		timer = GetComponent<CountdownTimer>();
		timer.ResetTimer(time);
	}

	void Update () {

		int remainingTime = timer.GetSecondsRemaining ();
		GameOver (remainingTime);
		UpdateTimer (remainingTime);
		UpdateSlider ();
	}

	private void UpdateTimer(int remainingTime) {

		string timerMessage = "Time Remained = " + remainingTime;
		timerText.text = timerMessage;
	}

	private void UpdateSlider() {

		float ratioRemaining = timer.GetProportionTimeRemaining ();
		timeSlider.value = ratioRemaining;
	}

	private void GameOver(int remainingTime) {

		if (remainingTime < 0) {
			Application.LoadLevel ("scene9_Level3GameOver");
		}
	}
}
