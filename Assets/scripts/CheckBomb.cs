using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckBomb : MonoBehaviour {

	public Button wire1;
	public Button wire2;
	public Button wire3;
	public Canvas bomb;
	public GameObject player;


	public ParticleSystem[] particles;
	
	WireColor wireScript1;
	WireColor wireScript2;
	WireColor wireScript3;
	BombSceneMovement playerScript;

	// Use this for initialization
	void Start () {
		wireScript1 = (WireColor)wire1.GetComponent (typeof(WireColor));
		wireScript2 = (WireColor)wire1.GetComponent (typeof(WireColor));
		wireScript3 = (WireColor)wire1.GetComponent (typeof(WireColor));
		playerScript = (BombSceneMovement)player.GetComponent (typeof(BombSceneMovement));
	}

	public void checkWires()
	{

		if (wireScript1.isRightColor && wireScript2.isRightColor && wireScript3.isRightColor) {

			bomb.gameObject.SetActive(false);
			player.gameObject.SetActive(true);
			playerScript.solved = true;
		} else {
			for(int i = 0; i < particles.Length; i++)
			{
				particles[i].Play();
			}
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
