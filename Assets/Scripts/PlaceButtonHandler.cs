using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceButtonHandler : MonoBehaviour
{
    public void ConfirmPlaced(){
        GlobalVariables.placed= !GlobalVariables.placed;
        Debug.Log(GlobalVariables.placed.ToString());
    }
}
