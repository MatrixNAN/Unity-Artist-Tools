using UnityEngine;
using System.Collections;

public class SmartTarget : MonoBehaviour 
{
	public static SmartTarget Instance;

	public GameObject 	Target;

    public float 		X_Smooth = 1f;
	public float 		Y_Smooth = 1f;
	public float 		Z_Smooth = 1f;

	private float 		velX 			= 0f;
	private float 		velY 			= 0f;
	private float 		velZ 			= 0f;
	private Vector3 	calcPosition 	= Vector3.zero;
	
	void MoveToTarget ()
	{
		float posX = Mathf.SmoothDamp(transform.position.x, Target.transform.position.x, ref velX, X_Smooth);
		float posY = Mathf.SmoothDamp(transform.position.y, Target.transform.position.y, ref velY, Y_Smooth);
		float posZ = Mathf.SmoothDamp(transform.position.z, Target.transform.position.z, ref velZ, Z_Smooth);
		transform.position = new Vector3(posX, posY, posZ);
	}

	void JumpToTarget (GameObject jumpTarget)
	{
		Target = jumpTarget;
		transform.position = jumpTarget.transform.position; 
	}

	void Update () 
	{
		if (Target == null)
			return;
		
		MoveToTarget();
	}
}
