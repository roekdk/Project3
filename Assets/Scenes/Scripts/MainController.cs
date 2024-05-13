using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MainController : MonoBehaviour //종합
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    
    public void CallMoveEvent(Vector2 dire)
    {
        OnMoveEvent?.Invoke(dire); //있으면 실행 없으면 넘김
    }
    public void CallLookEvent(Vector2 dire)
    {
        OnLookEvent?.Invoke(dire);
    }
}
