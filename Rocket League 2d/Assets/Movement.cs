using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    private float horz;

    private bool grounded;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (true)
        {
            horz = Input.GetAxis("Horizontal");
            rb.MovePosition(transform.position + new Vector3(horz, 0, 0) * Time.deltaTime * speed);
        }
        if(Input.GetButton("Jump"))
        {
            rb.AddForce(new Vector2(0, 1f));
            Debug.Log("pog");
           
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("ground"))
        {
            grounded = true;
        }
    }

    /*
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            grounded = false;
        }
    }

    */
}
