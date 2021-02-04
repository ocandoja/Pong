using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.mousePosition);
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(mousePosition.y, -3.89f, 3.89f), transform.position.z);
    }
}
