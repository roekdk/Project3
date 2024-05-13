using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements.Experimental;

public class PlayerInputController:MainController //플레이어의 행동
{
    private Camera _camera;
    private void Awake() 
    {
        _camera=Camera.main; //메인카메라를 가져옴
    }
    public void OnMove(InputValue value)
    {
        Vector2 moveInput=value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }
    public void OnLook(InputValue value)
    {
        Vector2 newAim=value.Get<Vector2>();
        Vector2 worldPos=_camera.ScreenToWorldPoint(newAim);
        newAim=(worldPos-(Vector2)transform.position).normalized;
        
        CallLookEvent(newAim);
    }
}
