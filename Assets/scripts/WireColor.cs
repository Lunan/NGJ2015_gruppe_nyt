using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WireColor: MonoBehaviour {

	public Button wire;
	public Sprite[] wireColor;
	private int currentColor = 0;
	public int rightColor;
	public bool isRightColor = false;


	// Use this for initialization
	void Start () {
	}

	public void ChangeColour()
	{
		if (currentColor != 8) {
			currentColor++;
		} else {
			currentColor = 1;
		}
		wire.image.overrideSprite = wireColor[currentColor];
		if (currentColor == rightColor) {
			isRightColor = true;
		}
	}

	// Update is called once per frame
	void Update () {

	
	}
}
