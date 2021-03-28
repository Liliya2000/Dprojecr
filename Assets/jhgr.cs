using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class jhgr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

       
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject central;
        GameObject[] arms;
       // arm1 = GameObject.Find("quadArm1");
        central = GameObject.Find("untitled");
        arms = GameObject.FindGameObjectsWithTag("rama");
        //Debug.Log(central.Length);
        //string name = gameObject.name;
        //Debug.Log(name);

        for (int i = 0; i < arms.Length - 1; i++)
        {
            
                Debug.Log(arms[i].activeSelf, arms[i]);
            
        }

        //for (int i=0; i< arms.Length-1;i++)
        //{
        //    if (arms[i].activeInHierarchy)
        //    {
        //        float d = Mathf.Sqrt(Mathf.Pow(central.transform.position.x - arms[i].transform.position.x, 2) +
        //        Mathf.Pow(central.transform.position.y - arms[i].transform.position.y, 2) +
        //        Mathf.Pow(central.transform.position.z - arms[i].transform.position.z, 2));
        //        if (d <= 0.03)
        //        {
        //            central.AddComponent(typeof(FixedJoint));

        //            GetComponent<FixedJoint>().connectedBody = arms[i].GetComponent<Rigidbody>();
        //        }
        //    }
        //}

        //Debug.Log(transform.position);
        // gameo.AddComponent(typeof(FixedJoint));

    }
}
