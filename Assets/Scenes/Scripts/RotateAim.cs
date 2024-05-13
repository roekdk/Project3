using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAim : MonoBehaviour
{
    //[SerializeField] private SpriteRenderer armRenderer;
    //[SerializeField] private Transform armPivot;
    //[SerializeField] private SpriteRenderer characterRenderer;
    [SerializeField] private SpriteRenderer playerRenderer1;
    [SerializeField] private SpriteRenderer playerRenderer2;
    private MainController Controller;

    private void Awake() 
    {
        Controller=GetComponent<MainController>();
    }
    private void Start() 
    {        
        Controller.OnLookEvent+=OnAim;
    }
    private void OnAim(Vector2 dire)
    {
        RotateArm(dire);
    }
    private void RotateArm(Vector2 dire)
    {        
        float rotZ=Mathf.Atan2(dire.y,dire.x)*Mathf.Rad2Deg;
        //characterRenderer.flipX=Mathf.Abs(rotZ) > 90f;
        playerRenderer1.flipX=Mathf.Abs(rotZ) >90f;
        playerRenderer2.flipX=Mathf.Abs(rotZ) >90f;
        //armPivot.rotation = Quaternion.Euler(0, 0, rotZ);  
    }
}
