using System;
using UnityEngine;

public class TopDownMovement:MonoBehaviour //실제 움직임 동작부
{
    private MainController controller;
    private Rigidbody2D moveRb;    
    private Vector2 movementDire=Vector2.zero;
    private void Awake()
    {
        // 같은 게임오브젝트의 MainController, Rigidbody를 가져올 것 
        controller=GetComponent<MainController>();
        moveRb=GetComponent<Rigidbody2D>();
    }
    private void Start() 
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 dire)
    {
        movementDire=dire;
    }    
    private void FixedUpdate()  //물리 업데이트에서 진행(rigidbody)
    {
        ApplyMovement(movementDire); //실제 물리 움직임 적용
    }
    private void ApplyMovement(Vector2 dire)
    {
        dire=dire*15;
        moveRb.velocity=dire;
    }
}
