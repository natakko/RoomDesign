using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Light : MonoBehaviour
{
    public Light PointL;
    public Light SpotL;
    bool InTrigger = false;


    void OnTriggerEnter(Collider Col)
    {
        InTrigger = true;
    }

    void OnTriggerExit(Collider Col)
    {
        InTrigger = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && (InTrigger == true))
        {
            if (SpotL.enabled == true)
            {
                PointL.enabled = false;
                SpotL.enabled = false;
            }
            else
            {
                PointL.enabled = true;
                SpotL.enabled = true;
            }
        }
    }
}