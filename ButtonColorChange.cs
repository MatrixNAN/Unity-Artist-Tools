using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorChange : MonoBehaviour 
{
	public bool isClicked = false;

	void Start()
	{
		if (isClicked)
		{
			var colors = GetComponent<Button> ().colors;
			// This code should work but it does not because of a bug in Unity UI Button
			//colors.normalColor = colors.pressedColor;
			//GetComponent<Button> ().colors = colors;
			// So we have to do the line below instead
			GetComponent<Image>().color = colors.pressedColor;
		}
		else
		{
			var colors = GetComponent<Button> ().colors;
			// This code should work but it does not because of a bug in Unity UI Button
			//colors.normalColor = Color.white;
			//GetComponent<Button> ().colors = colors;
			// So we have to do the line below instead
			GetComponent<Image>().color = colors.normalColor;
		}
	}

	public void ActivateButtonColor()
	{
		if (isClicked)
		{
			isClicked = false;
			var colors = GetComponent<Button> ().colors;
			// This code should work but it does not because of a bug in Unity UI Button
			//colors.normalColor = Color.white;
			//GetComponent<Button> ().colors = colors;
			// So we have to do the line below instead
			GetComponent<Image>().color = colors.normalColor;
		}
		else
		{
			isClicked = true;
			var colors = GetComponent<Button> ().colors;
			// This code should work but it does not because of a bug in Unity UI Button
			//colors.normalColor = colors.pressedColor;
			//GetComponent<Button> ().colors = colors;		
			// So we have to do the line below instead
			GetComponent<Image>().color = colors.pressedColor;
		}
	}
}
