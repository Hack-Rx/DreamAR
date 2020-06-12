using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public static bool placed;
    public static bool[] quarantined_blocks={false,false,false,false,false,false, false, false, false, false, false, false , false, false, false, false, false, false};
    // Start is called before the first frame update
    void Start()
    {
        placed=false;
    }

    // Update is called once per frame
    void Update()
    {
          
    }
}
