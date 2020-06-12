using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowARCamera : MonoBehaviour
{
    //public Camera arCamera;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(Camera.main.transform);
        transform.rotation = Quaternion.LookRotation(transform.position - Camera.main.transform.position);
        // Vector3 desiredAngle = new Vector3(0,transform.localEulerAngles.y,0);
        // transform.rotation=Quaternion.Euler(desiredAngle);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform);
        transform.rotation = Quaternion.LookRotation(transform.position - Camera.main.transform.position);
        // transform.LookAt(arCamera.transform);
        // Vector3 desiredAngle = new Vector3(0,transform.localEulerAngles.y,0);
        // transform.rotation=Quaternion.Euler(desiredAngle);
    }
}
