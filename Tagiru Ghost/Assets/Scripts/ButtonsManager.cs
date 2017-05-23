using UnityEngine;
using System.Collections;

public class ButtonsManager : MonoBehaviour {
	//load the Start Game scene
	public void LOAD_SCENE_START_GAME () {
		Application.LoadLevel ("scene0_StartGame");
	}
	//load the Level 1 playing scene
	public void LOAD_SCENE_LEVEL_1 () {
		Application.LoadLevel ("scene2_Level1");
	}
	//load the Level 2 playing scene
	public void LOAD_SCENE_LEVEL_2 () {
		Application.LoadLevel ("scene4_Level2");
	}
	//load the Level 3 playing scene
	public void LOAD_SCENE_LEVEL_3 () {
		Application.LoadLevel ("scene6_Level3");
	}
	//load the Game Complete scene
	public void LOAD_SCENE_GAME_COMPLETE () {
		Application.LoadLevel ("scene10_GameComplete");
	}
	//quit the game
	public void LOAD_QUIT_GAME () {
		Application.Quit ();
	}
	//load the Instruction scene
	public void LOAD_INSTRUCTIONS () {
		Application.LoadLevel ("scene11_Instructions");
	}
}
