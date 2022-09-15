using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float speed = 10.0f;
    public Boundary boundary;
    public float verticalPosition = -4.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, boundary.min, boundary.max), verticalPosition);
        //transform.position += new Vector3(x, 0);
    }

}
