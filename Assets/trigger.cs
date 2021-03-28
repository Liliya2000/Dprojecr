using UnityEngine;
using UnityEngine.EventSystems;

public class EventTriggerExample : EventTrigger
{
    public override void OnEndDrag(PointerEventData data)
    {
        GameObject central, arm;
        string name = gameObject.name;
        central = GameObject.Find("untitled");
        arm = GameObject.Find(name);

       

        float d = Mathf.Sqrt(Mathf.Pow(central.transform.position.x - arm.transform.position.x, 2) +
        Mathf.Pow(central.transform.position.y - arm.transform.position.y, 2) +
        Mathf.Pow(central.transform.position.z - arm.transform.position.z, 2));
        if (d <= 0.1)
        {
            arm.AddComponent(typeof(FixedJoint));

            GetComponent<FixedJoint>().connectedBody = central.GetComponent<Rigidbody>();
        }
    }
}