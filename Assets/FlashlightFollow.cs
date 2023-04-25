using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightFollow : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // this things position (flashlight) should be the same as the FPC's position

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position 
                                 + new Vector3 (0.4f,-0.2f,0.4f);
        
    }

}