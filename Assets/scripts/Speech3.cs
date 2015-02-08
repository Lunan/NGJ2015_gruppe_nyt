using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Speech3 : MonoBehaviour {
	
	Text text;
	
	private int textseq = 0;
	
	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();
		text.text = "Well, that was a big bang!";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			textseq++;
		}
		if (textseq == 1) {
			text.text = "That calls for a promotion! You are really moving up!";
		}
		else
		{
			if(textseq == 2){
				text.text = "Congratulations! You are the new executive-employee-of-the-month-all-around-great-south-east-asia-branch-manager";
			}
			else
			{
				if(textseq == 3){
					text.text = "Our new task is to wipe out a vipers nest! I must regretfully ask you to kill them all";
				}
				else
				{
				if (textseq == 4){
					Application.LoadLevel("shooting");
				}
				}
				
			}
		}
		
	}
}
