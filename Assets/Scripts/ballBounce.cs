using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector3 lastVelocity;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Quaternion rotation = Quaternion.Euler(0, 45, 0);
        transform.rotation = rotation;
    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
        lastVelocity = rb.velocity; 
    }
    private void OnCollisionEnter2D(Collision2D other) {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, other.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed,0f);
    }
    //trường hợp nhiều collider thì nó sẽ trả về 1 mảng
}
