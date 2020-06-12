using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePerson : MonoBehaviour
{
    public GameObject Person;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.placed)
        {
            GameObject gameObject=Instantiate(Person);
        }
        
    }
}
