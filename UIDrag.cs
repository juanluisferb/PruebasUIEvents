using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIDrag : MonoBehaviour {

	public void BeginDrag(BaseEventData eventData)
    {
        PointerEventData pointerEvent = (PointerEventData)eventData;
        Debug.Log("Begin Drag " + pointerEvent.position);
    }

    public void EndDrag(BaseEventData eventData)
    {
        PointerEventData pointerEvent = (PointerEventData)eventData;
        Debug.Log("End Drag " + pointerEvent.position);
    }

    public void Drag(BaseEventData eventData)
    {
        PointerEventData pointerEvent = (PointerEventData)eventData;
        Debug.Log("Drag " + pointerEvent.position);
        this.transform.position = pointerEvent.position;
    }
}
