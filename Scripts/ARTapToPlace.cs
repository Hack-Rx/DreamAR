using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class ARTapToPlace : MonoBehaviour
{

    public GameObject gameobject;
    private GameObject spawnedObject;
    private ARRaycastManager _arRaycastManager;
    private Vector2 touchposition;

    static List<ARRaycastHit> hits=new List<ARRaycastHit>();
    private void Awake() {
        _arRaycastManager=GetComponent<ARRaycastManager>();

    }

    bool TryGetTouch(out Vector2 touchposition){
        if(Input.touchCount>0){
            touchposition=Input.GetTouch(0).position;
            return true;
        }
        touchposition=default;
        return false;
    }
    // Update is called once per frame
    void Update()
    {
        if(!TryGetTouch(out Vector2 touchposition))
            return;
        if (_arRaycastManager.Raycast(touchposition,hits,TrackableType.PlaneWithinPolygon)){
            var hitPose=hits[0].pose;
            if(spawnedObject==null){
                spawnedObject=Instantiate(gameobject,hitPose.position,hitPose.rotation);
            }
            else{
                spawnedObject.transform.position=hitPose.position;
            }
        } 
    }
}
