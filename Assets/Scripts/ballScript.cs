using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    [SerializeField] float xSpeed = 250f;
    [SerializeField] float ySpeed = 250f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(xSpeed,ySpeed));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
