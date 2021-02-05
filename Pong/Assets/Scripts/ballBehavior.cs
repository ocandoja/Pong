using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBehavior : MonoBehaviour
{
    public Transform paddle;
    bool gameStarted; 
    public Rigidbody2D rbBall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameStarted)
        {
            float ballPosition = paddle.position.x - transform.position.x;
            transform.position = new Vector3(paddle.position.x - ballPosition, paddle.position.y, paddle.position.z);
            if(Input.GetMouseButtonDown(0))
            {
                rbBall.velocity = new Vector2(4,4);
                gameStarted = true;
            }
        }
    }
}
