using UnityEngine;
using System.Collections;

public class bulletScript : MonoBehaviour {

	private GameObject player_Prefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.tag == "destroyable") {
			//Debug.Log ("I hit something!");
			Destroy (col.gameObject);
			//Instantiate (player_Prefab, col.contacts [0].point, col.gameObject.transform.rotation);
			Destroy (gameObject);
		} else {
			//Debug.Log ("I hit something! Too" + col.gameObject);
			Destroy (gameObject);
		}
	}
}
