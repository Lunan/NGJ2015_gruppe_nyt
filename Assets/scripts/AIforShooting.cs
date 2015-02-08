using UnityEngine;
using System.Collections;

public class AIforShooting : MonoBehaviour {

	private float timer = 0f;
	private bool hasShot = false;
	public Rigidbody2D bullet;
	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (Mathf.RoundToInt (timer) % 2 == 0 ) {
			if (!hasShot){
				Rigidbody2D bulletClone = (Rigidbody2D)Instantiate(bullet, transform.position, transform.rotation);
				bulletClone.gameObject.SetActive(true);
				bulletClone.velocity = ((player.rigidbody2D.position-gameObject.rigidbody2D.position)/(player.rigidbody2D.position-gameObject.rigidbody2D.position).magnitude)*5;
				hasShot = true;
			}
		} else
			hasShot = false;
	}
}
