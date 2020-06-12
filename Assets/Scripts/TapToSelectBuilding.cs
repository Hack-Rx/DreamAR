using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
[RequireComponent(typeof(ARRaycastManager))]
public class TapToSelectBuilding : MonoBehaviour
{
    [SerializeField]
    private Camera arCamera;
    bool selected=false;

    private Vector3 touchPosition;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Awake() {

    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalVariables.placed){
            if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Ended))
            {
                Ray raycast = arCamera.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit raycastHit;
                if (Physics.Raycast(raycast, out raycastHit))
                {
                    Debug.Log("Clicked: ");
                    // Debug.Log(raycastHit.collider.tag);
                    // Debug.Log(raycastHit.collider.name);
                    Debug.Log(raycastHit.transform.name);
                    if (raycastHit.collider.tag == "Block1")
                    {
                        GlobalVariables.quarantined_blocks[0]=!GlobalVariables.quarantined_blocks[0];
                        GameObject block1=GameObject.Find("Lock1");
                        GameObject Lock = block1.transform.GetChild(0).gameObject;
                        GameObject UnLock = block1.transform.GetChild(1).gameObject;
                        UnLock.GetComponent<Renderer>().enabled=!GlobalVariables.quarantined_blocks[0];
                        Lock.GetComponent<Renderer>().enabled=GlobalVariables.quarantined_blocks[0];
                    }
                    else if (raycastHit.collider.tag == "Block2")
                    {
                        GlobalVariables.quarantined_blocks[1]=!GlobalVariables.quarantined_blocks[1];
                        GameObject block1=GameObject.Find("Lock2");
                        GameObject Lock = block1.transform.GetChild(0).gameObject;
                        GameObject UnLock = block1.transform.GetChild(1).gameObject;
                        UnLock.GetComponent<Renderer>().enabled=!GlobalVariables.quarantined_blocks[1];
                        Lock.GetComponent<Renderer>().enabled=GlobalVariables.quarantined_blocks[1];
                    }
                    else if (raycastHit.collider.tag == "Block3")
                    {
                        GlobalVariables.quarantined_blocks[2]=!GlobalVariables.quarantined_blocks[2];
                        GameObject block1=GameObject.Find("Lock3");
                        GameObject Lock = block1.transform.GetChild(0).gameObject;
                        GameObject UnLock = block1.transform.GetChild(1).gameObject;
                        UnLock.GetComponent<Renderer>().enabled=!GlobalVariables.quarantined_blocks[2];
                        Lock.GetComponent<Renderer>().enabled=GlobalVariables.quarantined_blocks[2];
                    }
                    else if (raycastHit.collider.tag == "Block4")
                    {
                        GlobalVariables.quarantined_blocks[3] = !GlobalVariables.quarantined_blocks[3];
                        GameObject block1 = GameObject.Find("Lock4");
                        GameObject Lock = block1.transform.GetChild(0).gameObject;
                        GameObject UnLock = block1.transform.GetChild(1).gameObject;
                        UnLock.GetComponent<Renderer>().enabled = !GlobalVariables.quarantined_blocks[3];
                        Lock.GetComponent<Renderer>().enabled = GlobalVariables.quarantined_blocks[3];
                    }
                    else if (raycastHit.collider.tag == "Block5")
                    {
                        GlobalVariables.quarantined_blocks[4] = !GlobalVariables.quarantined_blocks[4];
                        GameObject block1 = GameObject.Find("Lock5");
                        GameObject Lock = block1.transform.GetChild(0).gameObject;
                        GameObject UnLock = block1.transform.GetChild(1).gameObject;
                        UnLock.GetComponent<Renderer>().enabled = !GlobalVariables.quarantined_blocks[4];
                        Lock.GetComponent<Renderer>().enabled = GlobalVariables.quarantined_blocks[4];
                    }
                    else if (raycastHit.collider.tag == "Block6")
                    {
                        GlobalVariables.quarantined_blocks[5] = !GlobalVariables.quarantined_blocks[5];
                        GameObject block1 = GameObject.Find("Lock6");
                        GameObject Lock = block1.transform.GetChild(0).gameObject;
                        GameObject UnLock = block1.transform.GetChild(1).gameObject;
                        UnLock.GetComponent<Renderer>().enabled = !GlobalVariables.quarantined_blocks[5];
                        Lock.GetComponent<Renderer>().enabled = GlobalVariables.quarantined_blocks[5];
                    }
                    else if (raycastHit.collider.tag == "Block7")
                    {
                        GlobalVariables.quarantined_blocks[6] = !GlobalVariables.quarantined_blocks[6];
                        GameObject block1 = GameObject.Find("Lock7");
                        GameObject Lock = block1.transform.GetChild(0).gameObject;
                        GameObject UnLock = block1.transform.GetChild(1).gameObject;
                        UnLock.GetComponent<Renderer>().enabled = !GlobalVariables.quarantined_blocks[6];
                        Lock.GetComponent<Renderer>().enabled = GlobalVariables.quarantined_blocks[6];
                    }
                    else if (raycastHit.collider.tag == "Block8")
                    {
                        GlobalVariables.quarantined_blocks[7] = !GlobalVariables.quarantined_blocks[7];
                        GameObject block1 = GameObject.Find("Lock8");
                        GameObject Lock = block1.transform.GetChild(0).gameObject;
                        GameObject UnLock = block1.transform.GetChild(1).gameObject;
                        UnLock.GetComponent<Renderer>().enabled = !GlobalVariables.quarantined_blocks[7];
                        Lock.GetComponent<Renderer>().enabled = GlobalVariables.quarantined_blocks[7];
                    }
                    else if (raycastHit.collider.tag == "Block9")
                    {
                        GlobalVariables.quarantined_blocks[8] = !GlobalVariables.quarantined_blocks[8];
                        GameObject block1 = GameObject.Find("Lock9");
                        GameObject Lock = block1.transform.GetChild(0).gameObject;
                        GameObject UnLock = block1.transform.GetChild(1).gameObject;
                        UnLock.GetComponent<Renderer>().enabled = !GlobalVariables.quarantined_blocks[8];
                        Lock.GetComponent<Renderer>().enabled = GlobalVariables.quarantined_blocks[8];
                    }
                    else if (raycastHit.collider.tag == "Block10")
                    {
                        GlobalVariables.quarantined_blocks[9] = !GlobalVariables.quarantined_blocks[9];
                        GameObject block1 = GameObject.Find("Lock10");
                        GameObject Lock = block1.transform.GetChild(0).gameObject;
                        GameObject UnLock = block1.transform.GetChild(1).gameObject;
                        UnLock.GetComponent<Renderer>().enabled = !GlobalVariables.quarantined_blocks[9];
                        Lock.GetComponent<Renderer>().enabled = GlobalVariables.quarantined_blocks[9];
                    }
                    else if (raycastHit.collider.tag == "Block11")
                    {
                        GlobalVariables.quarantined_blocks[10] = !GlobalVariables.quarantined_blocks[10];
                        GameObject block1 = GameObject.Find("Lock11");
                        GameObject Lock = block1.transform.GetChild(0).gameObject;
                        GameObject UnLock = block1.transform.GetChild(1).gameObject;
                        UnLock.GetComponent<Renderer>().enabled = !GlobalVariables.quarantined_blocks[10];
                        Lock.GetComponent<Renderer>().enabled = GlobalVariables.quarantined_blocks[10];
                    }
                    else if (raycastHit.collider.tag == "Block12")
                    {
                        GlobalVariables.quarantined_blocks[11] = !GlobalVariables.quarantined_blocks[11];
                        GameObject block1 = GameObject.Find("Lock12");
                        GameObject Lock = block1.transform.GetChild(0).gameObject;
                        GameObject UnLock = block1.transform.GetChild(1).gameObject;
                        UnLock.GetComponent<Renderer>().enabled = !GlobalVariables.quarantined_blocks[11];
                        Lock.GetComponent<Renderer>().enabled = GlobalVariables.quarantined_blocks[11];
                    }
                    else if (raycastHit.collider.tag == "Block13")
                    {
                        GlobalVariables.quarantined_blocks[12] = !GlobalVariables.quarantined_blocks[12];
                        GameObject block1 = GameObject.Find("Lock13");
                        GameObject Lock = block1.transform.GetChild(0).gameObject;
                        GameObject UnLock = block1.transform.GetChild(1).gameObject;
                        UnLock.GetComponent<Renderer>().enabled = !GlobalVariables.quarantined_blocks[12];
                        Lock.GetComponent<Renderer>().enabled = GlobalVariables.quarantined_blocks[12];
                    }
                }
            }
        }
    }

    // void ChangeSelectedObject(PlacementObject selected)
    // {
    //     foreach (PlacementObject current in placedObjects)
    //     {   
    //         MeshRenderer meshRenderer = current.GetComponent<MeshRenderer>();
    //         if(selected != current) 
    //         {
    //             current.Selected = false;
    //             meshRenderer.material.color = inactiveColor;
    //         }
    //         else 
    //         {
    //             current.Selected = true;
    //             meshRenderer.material.color = activeColor;  
    //         }
    //     }
    // }
}
