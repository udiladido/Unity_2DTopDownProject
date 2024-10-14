using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    private TopDownController controller;
    private Rigidbody2D rigidbody;
   
    public GameObject scanObject;

    private Vector2 movementDirection = Vector2.zero;

    private void Start()
    {
        controller.OnMoveEvent += move;

    }

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();

    }

    private void FixedUpdate()
    {

        ApplyMovement(movementDirection);

    }


    private void move(Vector2 direction)
    { 
    
        movementDirection = direction;
    
    }

    private void ApplyMovement(Vector2 direction)
    {


    
        if(direction.x > 0)
            spriteRenderer.flipX = false;
        else 
            spriteRenderer.flipX = true;


        direction = direction * 5;
        rigidbody.velocity = direction;

        

        Debug.DrawRay(rigidbody.position, direction * 0.7f, new Color(255,0,0));
        RaycastHit2D rayHit = Physics2D.Raycast(rigidbody.position, direction , 0.7f, LayerMask.GetMask("NPC"));

      

        if (rayHit.collider != null)
        {
            scanObject = rayHit.collider.gameObject;
           
        }
  

  
    }


}
