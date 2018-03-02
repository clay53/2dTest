using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitscript : MonoBehaviour {
	public BoxCollider2D self;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (self.IsTouchingLayers(LayerMask.GetMask("Default"))) {
			SceneManager.LoadScene ("WinScene");
		}
	}
}
