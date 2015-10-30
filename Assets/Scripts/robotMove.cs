using UnityEngine;
using System.Collections;

public class robotMove : MonoBehaviour
{

    public float Speed;
    public float jumpHeight;
    public bool isJumping = false;

    // Use this for initialization
    void Start()
    {

    }


    void Update()
    {
        //Jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isJumping)
            {
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight);
                isJumping = true;
            }
        }

        //Movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * Speed * Time.deltaTime;
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    { 
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ground")
        {
            isJumping = false;
        }
    }



}
