using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class dragobj : MonoBehaviour
{
    float lerpTime = 1f;
    float currentLerpTime;
    float moveDistance = 10f;
    Plane plane;
    public Vector3 startPos, endPos;
    public bool drag;
    Vector3 position;

    void Start()
    {
        startPos = transform.position;
        endPos = transform.position + transform.up * moveDistance;
    }
    void OnMouseDown()
    {
        plane = new Plane(Vector2.up, transform.position);
        drag = true; // start dragging
    }
    void OnMouseUp()
    {
        lerp();
        drag = false;
    }
    private void lerp()
    {
        currentLerpTime += Time.deltaTime;
        if (currentLerpTime > lerpTime)
        {
            currentLerpTime = lerpTime;
        }

        float perc = currentLerpTime / lerpTime;
        transform.position = Vector3.Lerp(startPos, endPos, perc);
    }
    public void Update()
    {
        position = transform.localPosition;
        if (drag)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            float distance;

            if (plane.Raycast(ray, out distance))
            {
                transform.position = ray.GetPoint(distance);
            }
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        endPos = other.transform.position;
    }
}