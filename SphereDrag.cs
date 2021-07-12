using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SphereDrag : MonoBehaviour, IDragHandler {

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 distance = this.transform.position - Camera.main.transform.position;
        Vector3 projectedDistance = Vector3.Project(distance, Camera.main.transform.forward);


        Vector2 mousePosition = eventData.position;
        Vector3 convertPosition = new Vector3(mousePosition.x, mousePosition.y, projectedDistance.magnitude);
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(convertPosition);
        this.transform.position = worldPosition;

        //this.transform.position = eventData.position; No funciona
    }

    
}
