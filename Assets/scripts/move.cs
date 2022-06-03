using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public float speed = 1f;
    private Vector3 moveDelta;
    
    void Start()
    {
        var boxCollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        moveDelta = new Vector3(x,y,0);

        if (moveDelta.x > 0){
            transform.localScale = Vector3.one;
        }
        else if (moveDelta.x < 0){
            transform.localScale = new Vector3(-1, 1, 1);
        }

        transform.Translate(moveDelta * Time.deltaTime * speed);
    }
}