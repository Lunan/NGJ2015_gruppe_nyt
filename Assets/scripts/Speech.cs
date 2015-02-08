using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Speech : MonoBehaviour {

	Text text;

	private int textseq = 0;

	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();
		text.text = "Welcome! It is good to see my new employee all ready for work.";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			textseq++;
		}
		if (textseq == 1) {
			text.text = "Here at OCM you can move up quickly if you do well.";
		}
		else
		{
			if(textseq == 2){
				text.text = "First, I need you to go down to city hall, to deliver these important documents";
			}
			else
			{
				if(textseq == 3)
				{
					text.text = "Since you're new to town I should say that trafficlights in this city doesn't work very well...";
				}
				else{
					if (textseq == 4){
						Application.LoadLevel("delivery");
					}
				}
			}
		}

	}
}
