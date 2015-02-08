using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BombSceneMovement : MonoBehaviour {

	public GameObject Player;
	public float speed = 6.0F;
	public Animator ani;
	private float deltax = 0f;
	private float x = 0f;
	public Canvas bombPuzzle;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		deltax = Player.transform.position.x - x;
		x = Player.transform.position.x;
		if (Player.transform.position.x < 13.23f) {
			Player.transform.position = new Vector3 (Player.transform.position.x + speed, Player.transform.position.y, Player.transform.position.z);
		} else {
			bombPuzzle.enabled = true;
		}
		ani.SetFloat ("horizontal movement", deltax);
	}
}
