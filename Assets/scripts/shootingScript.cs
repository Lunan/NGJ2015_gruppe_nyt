using UnityEngine;
using System.Collections;

public class shootingScript : MonoBehaviour {


	public Rigidbody2D bullet;
	public float speed = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			//Debug.Log("pew?");
			Rigidbody2D bulletClone = (Rigidbody2D)Instantiate(bullet, transform.position, transform.rotation);
			bulletClone.gameObject.SetActive(true);
			Vector2 mousePos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
			bulletClone.velocity = ((mousePos-gameObject.rigidbody2D.position)/(mousePos-gameObject.rigidbody2D.position).magnitude)*5;
		}
	}


}
