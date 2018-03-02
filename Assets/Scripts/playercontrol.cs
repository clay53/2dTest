using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontrol : MonoBehaviour {
	public float move;
	public float jump;
	public Rigidbody2D pl;

	// Use this for initialization
	void Start () {
		pl = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//jump
		if (Input.GetKey(KeyCode.Space) && pl.IsTouchingLayers(LayerMask.GetMask("platforms"))) {
			pl.AddForce (transform.up * jump, ForceMode2D.Impulse);
		}

		//move
		if (Input.GetKey (KeyCode.D) ) {
			pl.AddForce (transform.right * move, ForceMode2D.Impulse);
		}
		if (Input.GetKey (KeyCode.A)) {
			pl.AddForce (-transform.right * move, ForceMode2D.Impulse);
		}

		//detections
		if (pl.IsTouchingLayers(LayerMask.GetMask("killers"))) {
			SceneManager.LoadScene("SimplePlat");
		}

	}
}
