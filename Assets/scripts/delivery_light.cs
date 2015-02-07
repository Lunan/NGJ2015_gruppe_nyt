using UnityEngine;
using System.Collections;

public class delivery_light : MonoBehaviour {

	private float timer = 0F;
	private GameObject[] horizontal_Lights;
	private GameObject[] vertical_Lights;
	private bool threesec = true;
	private bool foursec = true;
	private bool fivesec = true;
	private bool sevensec = true;
	private bool tensec = true;
	private bool fifteensec = true;
	private bool twentysec = true;
	private bool thirtysec = true;

	// Use this for initialization
	void Start () {
		horizontal_Lights = GameObject.FindGameObjectsWithTag ("hori");
		vertical_Lights = GameObject.FindGameObjectsWithTag ("verti");
		for (int n = 0; n<horizontal_Lights.Length; n++) {
			horizontal_Lights[n].renderer.material.color = new Color(255f,0f,0f,1f);
		}
		for (int n = 0; n<vertical_Lights.Length; n++) {
			vertical_Lights[n].renderer.material.color = new Color(0f,255f,0f,1f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (Mathf.RoundToInt (timer) % 30 == 0 ) {
			if (thirtysec){
				changejunction(2);
				changejunction(35);
				changejunction(23);
				changejunction(14);
				thirtysec = false;
			}
		} else
			thirtysec = true;
		if (Mathf.RoundToInt (timer) % 20 == 0 ) {
			if (twentysec){
				changejunction(12);
				changejunction(28);
				changejunction(20);
				changejunction(44);
				twentysec = false;
			}
		} else
			twentysec = true;
		if (Mathf.RoundToInt (timer) % 15 == 0 ) {
			if (fifteensec){
				changejunction(6);
				changejunction(19);
				changejunction(33);
				changejunction(42);
				fifteensec = false;
			}
		} else
			fifteensec = true;
		if (Mathf.RoundToInt (timer) % 10 == 0 ) {
			if (tensec){
				changejunction(24);
				changejunction(18);
				changejunction(10);
				changejunction(36);
				changejunction(41);
				tensec = false;
			}
		} else
			tensec = true;
		if (Mathf.RoundToInt (timer) % 7 == 0 ) {
			if (sevensec){
				changejunction(5);
				changejunction(21);
				changejunction(25);
				changejunction(40);
				changejunction(11);
				changejunction(37);
				sevensec = false;
			}
		} else
			sevensec = true;
		if (Mathf.RoundToInt (timer) % 5 == 0 ) {
			if (fivesec){
				changejunction(30);
				changejunction(36);
				changejunction(38);
				changejunction(43);
				changejunction(3);
				changejunction(32);
				changejunction(46);
				fivesec = false;
			}
		} else
			fivesec = true;
		if (Mathf.RoundToInt (timer) % 4 == 0 ) {
			if (foursec){
				changejunction(47);
				changejunction(26);
				changejunction(16);
				changejunction(7);
				changejunction(27);
				changejunction(17);
				changejunction(8);
				changejunction(29);
				changejunction(45);
				foursec = false;
			}
		} else
			foursec = true;
		if (Mathf.RoundToInt (timer) % 3 == 0 ) {
			if (threesec){
				changejunction(1);
				changejunction(4);
				changejunction(9);
				changejunction(13);
				changejunction(15);
				changejunction(31);
				changejunction(39);
				changejunction(22);
				changejunction(34);
				changejunction(0);
				threesec = false;
			}
		} else
			threesec = true;
	}

	void changejunction(int number){
		changeLight (true, number * 2);
		changeLight (true, number * 2 + 1);
		changeLight (false, number * 2);
		changeLight (false, number * 2 + 1);
	}

	void changeLight(bool hori,int number){
		if (hori) {
			if (horizontal_Lights [number].renderer.material.color.Equals (new Color (255f, 0f, 0f, 1f))) {
				horizontal_Lights [number].renderer.material.color = new Color (0f, 255f, 0f, 1f);
				horizontal_Lights [number].collider2D.enabled = false;
			} else {
				horizontal_Lights [number].renderer.material.color = new Color (255f, 0f, 0f, 1f);
				horizontal_Lights [number].collider2D.enabled = true;
			}
		} else {
			if (vertical_Lights[number].renderer.material.color.Equals(new Color(255f,0f,0f,1f))){
				vertical_Lights[number].renderer.material.color = new Color(0f,255f,0f,1f);
				vertical_Lights[number].collider2D.enabled = false;
			}else{
				vertical_Lights[number].renderer.material.color = new Color(255f,0f,0f,1f);
				vertical_Lights[number].collider2D.enabled = true;
			}
		}
	}
}
