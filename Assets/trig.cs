using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class trig : MonoBehaviour,IDropHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
 public GameObject central, arm;
    public float d;
    public void Start()
    {
       
    }

    // Update is called once per frame
    public void Update()
    {
        
            d = Mathf.Sqrt(Mathf.Pow(central.transform.position.x - arm.transform.position.x, 2) +
            Mathf.Pow(central.transform.position.y - arm.transform.position.y, 2) +
            Mathf.Pow(central.transform.position.z - arm.transform.position.z, 2));

        if (d <= 0.1)
        {
            
            //objectToBeDragged = eventData.pointerCurrentRaycast.gameObject;
            central.AddComponent(typeof(FixedJoint));
            
            arm.transform.position = central.GetComponent<Transform>().position;
            central.GetComponent<FixedJoint>().connectedBody = arm.GetComponent<Rigidbody>();
            GetComponent<trig>().enabled = false;
        }
        
    }
    public float catchingDistance = 3f;
    private GameObject GetObjectFromMouseRaycast()
    {
        GameObject gmObj = null;
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
        if (hit)
        {
            if (hitInfo.collider.gameObject.GetComponent<Rigidbody>() &&
                Vector3.Distance(hitInfo.collider.gameObject.transform.position,
                transform.position) <= catchingDistance)
            {
                gmObj = hitInfo.collider.gameObject;
            }
        }
        return gmObj;
    }
    public void OnDrop(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        if (eventData.pointerDrag != null)
        {
            Debug.Log("Dropped object was: " + eventData.pointerDrag);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log ("OnDrag");

        this.transform.position = eventData.position;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");

    }
}
