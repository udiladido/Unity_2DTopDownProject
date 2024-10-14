using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{

    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action<float> OnZoomEvent;
    public event Action OnInteractiveEvent;
    public bool isAction;

    public void CallMoveEvent(Vector2 direction)
    { 
        
        if (!isAction) 
        OnMoveEvent?.Invoke(direction);

    }

    public void CallLookEvent(Vector2 direction) 
    {
        if (!isAction)
            OnLookEvent?.Invoke(direction);
    
    }

    public void CallZoomEvent(float zoom)
    {
        if (!isAction)
            OnZoomEvent?.Invoke(zoom);

    }

    public void CallInteractive()
    { 
    
        OnInteractiveEvent?.Invoke();
    
    }
   


}
