using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DirPa : EventTrigger 

{

    private Vector2 startPosition;
    public bool dragging { get; private set; }
    private Vector2 currentPosition;
    public Vector2 dir { get { return currentPosition - startPosition; } }
    public override void OnBeginDrag(PointerEventData eventData)
    {
        base.OnBeginDrag(eventData);
        startPosition = eventData.position;
        dragging = true;
    }

    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);
        currentPosition = eventData.position;
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        base.OnEndDrag(eventData);
        dragging = false;
    }

    private void Update()
    {
       // Debug.LogFormat("Dragging = {0}, Dir = {1}", dragging, dir);
    }
}
