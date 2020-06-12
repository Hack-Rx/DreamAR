using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class EnableDisableGroundPlane : MonoBehaviour
{
    private MeshRenderer mesh;
    private LineRenderer linerend;
    private ARPlaneManager arPlaneManager;
    // Start is called before the first frame update
    void Start()
    {
        arPlaneManager=GetComponent<ARPlaneManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalVariables.placed){
        arPlaneManager.enabled=false;
        foreach(ARPlane plane in arPlaneManager.trackables){
                plane.gameObject.SetActive(false);
        }
            // GetComponent<MeshRenderer>().enabled=false;
            // GetComponent<LineRenderer>().enabled=false;
            // Color col=GetComponent<MeshRenderer>().material.color;
            // col.a=0.0f;
            // GetComponent<MeshRenderer>().material.color=col;
            // col=GetComponent<LineRenderer>().startColor;
            // col.a=0.0f;
            // GetComponent<LineRenderer>().startColor=col;
            // col=GetComponent<LineRenderer>().endColor;
            // col.a=0.0f;
            // GetComponent<LineRenderer>().endColor=col;
        }
        else
        {
        arPlaneManager.enabled=true;
        foreach(ARPlane plane in arPlaneManager.trackables){
                plane.gameObject.SetActive(true);
        }
            // GetComponent<MeshRenderer>().enabled=true;
            // GetComponent<LineRenderer>().enabled=true;
            // Color col=GetComponent<MeshRenderer>().material.color;
            // col.a=0.5f;
            // GetComponent<MeshRenderer>().material.color=col;
            // col=GetComponent<LineRenderer>().startColor;
            // col.a=1.0f;
            // GetComponent<LineRenderer>().startColor=col;
            // col=GetComponent<LineRenderer>().endColor;
            // col.a=1.0f;
            // GetComponent<LineRenderer>().endColor=col;
        }
     }
}
