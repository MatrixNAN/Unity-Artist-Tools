using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour 
{
    public void Update() 
	{
    	if (Input.GetKeyDown(KeyCode.Escape)) 
		{
    		Application.Quit();
    	}
	}
}
