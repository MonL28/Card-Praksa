using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;


public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Vector2 relativeStartPosition;
    public void OnBeginDrag(PointerEventData eventData)
    {
        relativeStartPosition = this.transform.position - Input.mousePosition;
    }
    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position + relativeStartPosition;
    }
    public void OnEndDrag(PointerEventData eventData){}
    
}
