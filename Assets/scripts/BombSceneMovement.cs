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
	public bool solved = false;
	public AudioClip beep;
	private bool hasPlayed = false;
	private float timer = 0f;
	private bool blownUp = false;
	public GameObject building;
	public GameObject explosion;
	public GameObject smoke1;
	public GameObject smoke2;
	public GameObject rubble;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (!solved) {
			deltax = Player.transform.position.x - x;
			x = Player.transform.position.x;
			if (Player.transform.position.x < 13.23f) {
				Player.transform.position = new Vector3 (Player.transform.position.x + speed, Player.transform.position.y, Player.transform.position.z);
			} else {
				bombPuzzle.gameObject.SetActive (true);
				Player.gameObject.SetActive (false);
			}
			ani.SetFloat ("horizontal movement", deltax);
		} else {
			if (!hasPlayed){
				Debug.Log("Playing");
				audio.Play();
				hasPlayed = true;
			}
			Player.transform.position = new Vector3 (Player.transform.position.x + speed, Player.transform.position.y, Player.transform.position.z);
			deltax = Player.transform.position.x - x;
			x = Player.transform.position.x;
			ani.SetFloat ("horizontal movement", Mathf.Abs(deltax));
			timer += Time.deltaTime;
			if (timer > 5f && !blownUp){
				audio.Stop();
				building.audio.Play();
				explosion.SetActive(true);
				blownUp = true;
			}
			if (timer > 7f){
				smoke1.SetActive(true);
				smoke2.SetActive(true);
			}
			if (timer > 9f && timer < 16f){
				explosion.SetActive(false);
				building.transform.position = new Vector3 (building.transform.position.x,building.transform.position.y -speed,building.transform.position.z);
			}
			if (timer > 16f){
				rubble.SetActive(true);
				building.SetActive(false);
				smoke1.SetActive(false);
				smoke2.SetActive(false);
			}
			if (timer > 20f){
				Application.LoadLevel("scene3");
			}
		}
	}
}
