using UnityEngine;
using System.Collections;

public class CameraLookAtTarget : MonoBehaviour
{
    public Camera Cam;

	void Start ()
    {
        Cam.transform.LookAt(transform);
    }

    void Update ()
    {
        Cam.transform.LookAt(transform);
    }
}
