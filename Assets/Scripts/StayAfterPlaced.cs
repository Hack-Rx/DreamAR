using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayAfterPlaced : MonoBehaviour
{
    public GameObject Session;
    private Vector3 placed_position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!GlobalVariables.placed){
            placed_position=Session.transform.position;
        }
        else{
            Session.transform.position=placed_position;
        }
        
    }
}
