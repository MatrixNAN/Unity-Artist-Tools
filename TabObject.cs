using UnityEngine;
using System.Collections;

public class TabObject : MonoBehaviour 
{
	public GameObject[] InactiveTabObject;
	public GameObject[] ActiveTabObject;

	public void ShowHide()
	{
		int count = 0;

		for (count = 0; count < ActiveTabObject.Length; count++)
			ActiveTabObject[count].SetActive(true);
		
		for (count = 0; count < InactiveTabObject.Length; count++)
			InactiveTabObject[count].SetActive(false);
	}
}
