using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagerMovement : MonoBehaviour
{
    Rigidbody2D rigidbody;
    [SerializeField] private float speed;// private이지만 인스펙터 표출은 하고 싶어!
        
    void Start()
    {        
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {        
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector2 direction = new Vector2(horizontal, vertical);
        direction = direction.normalized; //정규화

        // rigidbody.velocity는 해당 물체가 1초당 움직이는 거리를 말합니다.
        rigidbody.velocity = direction * speed;
    }
}
