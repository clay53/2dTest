using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMenu : MonoBehaviour {

	public void ExitToMenu () {
		gameDat gameData = ((GameObject)Resources.Load("gameDat")).GetComponent<gameDat>();
		gameData.time = 0;
		gameData.deaths = 0;
		SceneManager.LoadScene("StartMenu");
	}
}
