using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Speech2 : MonoBehaviour {
	
	Text text;
	
	private int textseq = 0;
	
	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();
		text.text = "Thank you for delivering those documents, now my future projects can commence!";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			textseq++;
		}
		if (textseq == 1) {
			text.text = "We have been tasked with demolishing a building, and now we can proceed!";
		}
		else
		{
			if(textseq == 2){
				text.text = "So, I need you to go to the site and fix the demolishion bomb.";
			}
			else
			{

					if (textseq == 3){
						Application.LoadLevel("bombScene");
					}

			}
		}
		
	}
}
