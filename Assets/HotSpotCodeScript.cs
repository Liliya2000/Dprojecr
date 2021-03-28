using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class HotSpotCodeScript : MonoBehaviour
{
    
    public void OnTriggerEnter(Collider other)
    {
        dragobj ds = other.GetComponent<dragobj>();
        //ds.endPos = this.gameObject.transform.position;
        if (ds.drag)
        {
            Debug.Log("thrth");
        }
    }

}
