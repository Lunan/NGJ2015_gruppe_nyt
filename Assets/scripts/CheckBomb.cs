using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CheckBomb : MonoBehaviour {

	public Button wire1;
	public Button wire2;
	public Button wire3;
	
	WireColor wireScript1;
	WireColor wireScript2;
	WireColor wireScript3;

	// Use this for initialization
	void Start () {
		wireScript1 = (WireColor)wire1.GetComponent (typeof(WireColor));
		wireScript2 = (WireColor)wire1.GetComponent (typeof(WireColor));
		wireScript3 = (WireColor)wire1.GetComponent (typeof(WireColor));
	}

	public void checkWires()
	{
		Debug.Log ("I made it here!");
		if (wireScript1.isRightColor && wireScript2.isRightColor && wireScript3.isRightColor) {
			Debug.Log("It lives!!!!!!!!!!11!!");
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
