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
    private Vector3 placed_position;

    static List<ARRaycastHit> hits=new List<ARRaycastHit>();
    private void Awake() {
        _arRaycastManager=GetComponent<ARRaycastManager>();

    }

    int TryGetTouch(out Vector2 touchposition){
        if(Input.touchCount==1){
            touchposition=Input.GetTouch(0).position;
            return 1;
        }
        if(Input.touchCount==2){
            touchposition=default;
            return 2;
        }
        touchposition=default;
        return 0;
    }
    // Update is called once per frame
    void Update()
    {
        if(!GlobalVariables.placed){
            int touches=TryGetTouch(out Vector2 touchposition);
            if(touches==0)
                return;
            else if(touches==1){
                if(touchposition.y<Screen.height*(0.1))
                    return;
                if(_arRaycastManager.Raycast(touchposition,hits,TrackableType.PlaneWithinPolygon)){
                    var hitPose=hits[0].pose;
                    if(spawnedObject==null){
                        spawnedObject=Instantiate(gameobject,hitPose.position,hitPose.rotation);
                    }
                    else{
                        spawnedObject.transform.position=hitPose.position+new Vector3(0,0.2f,0);
                    }
                    placed_position=spawnedObject.transform.position;
                }
            }
            // else{// Store both touches. 
            // Touch touchZero = Input.GetTouch(0); 
            // Touch touchOne = Input.GetTouch(1);

            //     // Find the position in the previous frame of each touch.
            //     Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            //     Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            //     // Find the magnitude of the vector (the distance) between the touches in each frame.
            //     float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            //     float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            //     // Find the difference in the distances between each frame.
            //     float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;


            //     float pinchAmount = -deltaMagnitudeDiff * 0.02f * Time.deltaTime;
            //     if(spawnedObject.transform.localScale.x<0.01 || spawnedObject.transform.localScale.y<0.01 || spawnedObject.transform.localScale.z<0.01)
            //     {
            //         if(pinchAmount<0){return;}
            //     }
            //     spawnedObject.transform.localScale += new Vector3(pinchAmount, pinchAmount, pinchAmount);

            // }
    
        }
        else{
            spawnedObject.transform.position=placed_position;
        }
    }
}