using UnityEngine;
using System.Collections;

public class DestroyGameObjectClick : MonoBehaviour 
{
	public GameObject GameObjectToDestroy;

	public void DestroyClick()
	{
		Destroy(GameObjectToDestroy);
	}
}
