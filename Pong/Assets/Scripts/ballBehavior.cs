using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBehavior : MonoBehaviour
{
    public Transform paddle;
    public bool gameStarted; 
    public Rigidbody2D rbBall;
    float ballPosition;
    public AudioSource ballAudio;
    // Start is called before the first frame update
    void Start()
    {
        ballPosition = paddle.position.x - transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameStarted)
        {
            transform.position = new Vector3(paddle.position.x - ballPosition, paddle.position.y, paddle.position.z);
            if(Input.GetMouseButtonDown(0))
            {
                rbBall.velocity = new Vector2(8,8);
                gameStarted = true;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        ballAudio.Play();
    }
}
