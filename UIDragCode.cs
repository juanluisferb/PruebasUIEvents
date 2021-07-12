using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class UIDragCode : MonoBehaviour ,IBeginDragHandler,IEndDragHandler,IDragHandler{
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag " + eventData.position);
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
        Debug.Log("End Drag " + eventData.position);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Drag " + eventData.position);
    }

   
}
