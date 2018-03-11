using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public string TimePrefix;
	public Text TimeText;
	public string DeathsPrefix;
	public Text DeathsText;

	public gameDat gameData;

	// Use this for initialization
	void Start () {
		gameData = ((GameObject)Resources.Load("gameDat")).GetComponent<gameDat>();
	}

	void Update () {
		float time = ((float)Mathf.RoundToInt(gameData.time*100))/100;
		int deaths = gameData.deaths;

		TimeText.text = (TimePrefix + time.ToString());
		DeathsText.text = (DeathsPrefix + deaths.ToString());
	}
}
