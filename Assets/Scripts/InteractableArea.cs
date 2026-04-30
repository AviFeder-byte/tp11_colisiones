using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableArea : MonoBehaviour
{
    void Start()
    {
        
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    { 
        if(hit.gameObject.CompareTag("Pickable")){ 
            Destroy(hit.gameObject);
        }
    }
}